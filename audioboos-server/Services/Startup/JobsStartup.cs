﻿using AudioBoos.Server.Services.Jobs;
using AudioBoos.Server.Services.Jobs.Scanners;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace AudioBoos.Server.Services.Startup {
    public static class JobsStartup {
        public static IServiceCollection AddAudioBoosJobs(this IServiceCollection services, IConfiguration config) {
            services.AddQuartz(q => {
                q.SchedulerId = "AudioBoos-Server-Core";
                q.SchedulerName = "AudioBoos Scheduler";

                q.UseMicrosoftDependencyInjectionJobFactory();

                var jobKey = new JobKey("UpdateLibrary");
                q.AddJob<UpdateLibraryJob>(opts => opts.WithIdentity(jobKey).StoreDurably());
                q.AddTrigger(opts => opts
                    .ForJob(jobKey)
                    .WithIdentity("UpdateLibrary-trigger")
                    .WithDailyTimeIntervalSchedule(x => x.WithInterval(24, IntervalUnit.Hour)));
            });

            services.AddQuartzServer(options => {
                // when shutting down we want jobs to complete gracefully
                options.WaitForJobsToComplete = true;
            });

            services.AddTransient<ILibraryScanner, FastFilesystemLibraryScanner>();
            return services;
        }

        public static IApplicationBuilder UseAudioBoosJobs(this IApplicationBuilder app) {
            return app;
        }
    }
}
