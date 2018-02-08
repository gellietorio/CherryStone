using CherryStone.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CherryStone.Domain.Infrastructure
{
    public class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {
            Database.SetInitializer(new CherryStone.Domain.Infrastructure.DataInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserExternalLogin> UserExternalLogins { get; set; }
        public DbSet<Models.Post> Posts { get; set; }
        public DbSet<Models.PostComment> PostComments { get; set; }
        public DbSet<Models.PostHashtag> PostHashtags { get; set; }
        public DbSet<Models.PostLike> PostLikes { get; set; }
        public DbSet<Models.PostUserTag> PostUserTags { get; set; }
    }
}
