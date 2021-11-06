﻿// <auto-generated />
using System;
using AudioBoos.Data.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AudioBoos.Data.Migrations
{
    [DbContext(typeof(AudioBoosContext))]
    partial class AudioBoosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("app")
                .HasAnnotation("ProductVersion", "6.0.0-rc.2.21480.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AudioBoos.Data.Store.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("AlternativeNames")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alternative_names");

                    b.Property<Guid>("ArtistId")
                        .HasColumnType("uuid")
                        .HasColumnName("artist_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime>("FirstScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("first_scan_date");

                    b.Property<string>("LargeImage")
                        .HasColumnType("text")
                        .HasColumnName("large_image");

                    b.Property<DateTime>("LastScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_scan_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("ReleaseDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("release_date");

                    b.Property<string>("SiteId")
                        .HasColumnType("text")
                        .HasColumnName("site_id");

                    b.Property<string>("SmallImage")
                        .HasColumnType("text")
                        .HasColumnName("small_image");

                    b.Property<int>("TaggingStatus")
                        .HasColumnType("integer")
                        .HasColumnName("tagging_status");

                    b.HasKey("Id")
                        .HasName("pk_albums");

                    b.HasIndex("ArtistId", "Name")
                        .IsUnique()
                        .HasDatabaseName("ix_albums_artist_id_name");

                    b.ToTable("albums", (string)null);
                });

            modelBuilder.Entity("AudioBoos.Data.Store.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("access_failed_count");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("email_confirmed");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout_enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lockout_end");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_email");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_user_name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("password_hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phone_number_confirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text")
                        .HasColumnName("security_stamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("two_factor_enabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("user_name");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("AudioBoos.Data.Store.Artist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Aliases")
                        .HasColumnType("text")
                        .HasColumnName("aliases");

                    b.Property<string>("AlternativeNames")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alternative_names");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("DiscogsId")
                        .HasColumnType("text")
                        .HasColumnName("discogs_id");

                    b.Property<string>("Fanart")
                        .HasColumnType("text")
                        .HasColumnName("fanart");

                    b.Property<DateTime>("FirstScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("first_scan_date");

                    b.Property<string>("Genre")
                        .HasColumnType("text")
                        .HasColumnName("genre");

                    b.Property<string>("HeaderImage")
                        .HasColumnType("text")
                        .HasColumnName("header_image");

                    b.Property<string>("LargeImage")
                        .HasColumnType("text")
                        .HasColumnName("large_image");

                    b.Property<DateTime>("LastScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_scan_date");

                    b.Property<string>("MusicBrainzId")
                        .HasColumnType("text")
                        .HasColumnName("music_brainz_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("SmallImage")
                        .HasColumnType("text")
                        .HasColumnName("small_image");

                    b.Property<string>("Style")
                        .HasColumnType("text")
                        .HasColumnName("style");

                    b.Property<int>("TaggingStatus")
                        .HasColumnType("integer")
                        .HasColumnName("tagging_status");

                    b.HasKey("Id")
                        .HasName("pk_artists");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasDatabaseName("ix_artists_name");

                    b.ToTable("artists", (string)null);
                });

            modelBuilder.Entity("AudioBoos.Data.Store.AudioFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("AlbumId")
                        .HasColumnType("uuid")
                        .HasColumnName("album_id");

                    b.Property<string>("AlternativeNames")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alternative_names");

                    b.Property<Guid?>("ArtistId")
                        .HasColumnType("uuid")
                        .HasColumnName("artist_id");

                    b.Property<string>("Checksum")
                        .HasColumnType("text")
                        .HasColumnName("checksum");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime>("FirstScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("first_scan_date");

                    b.Property<string>("ID3AlbumName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("id3album_name");

                    b.Property<string>("ID3ArtistName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("id3artist_name");

                    b.Property<string>("ID3TrackName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("id3track_name");

                    b.Property<DateTime>("LastScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_scan_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("physical_path");

                    b.Property<int>("TaggingStatus")
                        .HasColumnType("integer")
                        .HasColumnName("tagging_status");

                    b.Property<Guid?>("TrackId")
                        .HasColumnType("uuid")
                        .HasColumnName("track_id");

                    b.HasKey("Id")
                        .HasName("pk_audio_files");

                    b.HasIndex("AlbumId")
                        .HasDatabaseName("ix_audio_files_album_id");

                    b.HasIndex("ArtistId")
                        .HasDatabaseName("ix_audio_files_artist_id");

                    b.HasIndex("PhysicalPath")
                        .IsUnique()
                        .HasDatabaseName("ix_audio_files_physical_path");

                    b.HasIndex("TrackId")
                        .HasDatabaseName("ix_audio_files_track_id");

                    b.ToTable("audio_files", (string)null);
                });

            modelBuilder.Entity("AudioBoos.Data.Store.Setting", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("text")
                        .HasColumnName("key");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("Key")
                        .HasName("pk_settings");

                    b.HasIndex("Key")
                        .IsUnique()
                        .HasDatabaseName("ix_settings_key");

                    b.ToTable("settings", (string)null);
                });

            modelBuilder.Entity("AudioBoos.Data.Store.Track", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uuid")
                        .HasColumnName("album_id");

                    b.Property<string>("AlternativeNames")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alternative_names");

                    b.Property<string>("AudioUrl")
                        .HasColumnType("text")
                        .HasColumnName("audio_url");

                    b.Property<string>("Comments")
                        .HasColumnType("text")
                        .HasColumnName("comments");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime>("FirstScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("first_scan_date");

                    b.Property<DateTime>("LastScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_scan_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhysicalPath")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("physical_path");

                    b.Property<DateTime>("ScanDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("scan_date");

                    b.Property<int>("TaggingStatus")
                        .HasColumnType("integer")
                        .HasColumnName("tagging_status");

                    b.Property<int>("TrackNumber")
                        .HasColumnType("integer")
                        .HasColumnName("track_number");

                    b.HasKey("Id")
                        .HasName("pk_tracks");

                    b.HasIndex("AlbumId")
                        .HasDatabaseName("ix_tracks_album_id");

                    b.HasIndex("PhysicalPath")
                        .IsUnique()
                        .HasDatabaseName("ix_tracks_physical_path");

                    b.ToTable("tracks", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text")
                        .HasColumnName("concurrency_stamp");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("normalized_name");

                    b.HasKey("Id")
                        .HasName("pk_identity_role");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("IdentityRole", "auth");

                    b.HasData(
                        new
                        {
                            Id = "a667cd0a-b675-46a4-a003-e7deab7e0a1a",
                            ConcurrencyStamp = "65e5ac0f-5fec-4568-9550-789e60ea676d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "8d9d41ab-e1b9-4a39-8033-1443da3f4609",
                            ConcurrencyStamp = "398a2dc4-704a-4460-8e9f-a633082ac4ed",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "5cf299f1-b384-4c42-b95a-e47e4d791b43",
                            ConcurrencyStamp = "38cd4065-71a4-476b-b03e-6bc49a0ab491",
                            Name = "Viewer",
                            NormalizedName = "VIEWER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claim_value");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("pk_identity_role_claim");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_identity_role_claim_role_id");

                    b.ToTable("IdentityRoleClaim", "auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim_type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claim_value");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_identity_user_claim");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_identity_user_claim_user_id");

                    b.ToTable("IdentityUserClaim", "auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("login_provider");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("provider_key");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasColumnName("provider_display_name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("user_id");

                    b.HasKey("LoginProvider", "ProviderKey")
                        .HasName("pk_identity_user_login");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_identity_user_login_user_id");

                    b.ToTable("IdentityUserLogin", "auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text")
                        .HasColumnName("user_id");

                    b.Property<string>("RoleId")
                        .HasColumnType("text")
                        .HasColumnName("role_id");

                    b.HasKey("UserId", "RoleId")
                        .HasName("pk_identity_user_role");

                    b.HasIndex("RoleId")
                        .HasDatabaseName("ix_identity_user_role_role_id");

                    b.ToTable("IdentityUserRole", "auth");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text")
                        .HasColumnName("user_id");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("login_provider");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("name");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("value");

                    b.HasKey("UserId", "LoginProvider", "Name")
                        .HasName("pk_identity_user_token");

                    b.ToTable("IdentityUserToken", "auth");
                });

            modelBuilder.Entity("AudioBoos.Data.Store.Album", b =>
                {
                    b.HasOne("AudioBoos.Data.Store.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_albums_artists_artist_id");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("AudioBoos.Data.Store.AudioFile", b =>
                {
                    b.HasOne("AudioBoos.Data.Store.Album", "Album")
                        .WithMany()
                        .HasForeignKey("AlbumId")
                        .HasConstraintName("fk_audio_files_albums_album_id");

                    b.HasOne("AudioBoos.Data.Store.Artist", "Artist")
                        .WithMany()
                        .HasForeignKey("ArtistId")
                        .HasConstraintName("fk_audio_files_artists_artist_id");

                    b.HasOne("AudioBoos.Data.Store.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .HasConstraintName("fk_audio_files_tracks_track_id");

                    b.Navigation("Album");

                    b.Navigation("Artist");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("AudioBoos.Data.Store.Track", b =>
                {
                    b.HasOne("AudioBoos.Data.Store.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_tracks_albums_album_id");

                    b.Navigation("Album");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_identity_role_claim_identity_role_role_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AudioBoos.Data.Store.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_identity_user_claim_users_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AudioBoos.Data.Store.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_identity_user_login_users_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_identity_user_role_identity_role_role_id");

                    b.HasOne("AudioBoos.Data.Store.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_identity_user_role_users_user_id");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AudioBoos.Data.Store.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_identity_user_token_users_user_id");
                });

            modelBuilder.Entity("AudioBoos.Data.Store.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("AudioBoos.Data.Store.Artist", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
