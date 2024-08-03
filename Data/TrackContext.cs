// Using directive for the models in the application
using PlaylistApi.Models;
// Using directive for Entity Framework Core
using Microsoft.EntityFrameworkCore;

//Namespace
namespace PlaylistApi.Data
{

    // Adding DbContext to create database table for Track
    public class TrackContext : DbContext
    {
        public TrackContext(DbContextOptions<TrackContext> options) : base(options)
        {

        }
        public DbSet<Track> Tracks { get; set; }
    }
}
