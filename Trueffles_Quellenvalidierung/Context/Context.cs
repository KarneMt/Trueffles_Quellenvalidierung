using Microsoft.EntityFrameworkCore;
using Trueffles_Quellenvalidierung.Models;

namespace Trueffles_Quellenvalidierung.ContextDb
{
public class Context : DbContext
    {
        public string DbPath { get; }

        public Context()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "quellen.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");



        public DbSet<Quellen>? Quellen { get; set; }

    }
}

