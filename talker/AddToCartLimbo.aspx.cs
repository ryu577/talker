using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using talker.logic;
using talker.Models;

namespace talker
{
    public partial class AddToCartLimbo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string RawId = Request.QueryString["bidId"];
            DataContext _db = new DataContext();
            int OriginatingBidId = Convert.ToInt32(RawId);
            
            Discussion newDiscussion = new Discussion
            {
                ProvidingUserName = _db.LiveBids.SingleOrDefault(p => p.BidID == OriginatingBidId).ProvidingUserName,
                ReceivingUserName = HttpContext.Current.User.Identity.Name,
                DiscussionStartTime = _db.LiveBids.SingleOrDefault(p => p.BidID == OriginatingBidId).AvailableStartTime,
                DiscussionEndTime = _db.LiveBids.SingleOrDefault(p => p.BidID == OriginatingBidId).AvailableEndTime,
                TransactionAmount = _db.LiveBids.SingleOrDefault(p => p.BidID == OriginatingBidId).DesiredBidPrice,
                Status = true,
                DateCreated = DateTime.Now
            };
            LiveBid soldBid = _db.LiveBids.SingleOrDefault(p => p.BidID == OriginatingBidId);
            _db.LiveBids.Remove(soldBid);
            _db.Discussions.Add(newDiscussion);
            _db.SaveChanges();
            Response.Redirect("AddToCart.aspx?discussionId=" + newDiscussion.DiscussionID);
        }
    }
}