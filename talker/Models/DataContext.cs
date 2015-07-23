using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace talker.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DiscussionsDB")
        {
        }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<LiveBid> LiveBids { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PlacedBid> PlacedBids { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
