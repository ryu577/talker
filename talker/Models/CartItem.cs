using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace talker.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }
        public string CartId { get; set; }
        public DateTime DateCreated { get; set; }
        public int DiscussionId { get; set; }
        public virtual Discussion Discussion { get; set; }
    }
}