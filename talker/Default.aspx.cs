using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using talker.Models;

namespace talker
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CreateBid_Click(object sender, EventArgs e)
        {
            //string RawId = Request.QueryString["LiveBidId"];
            //int OriginatingBidId = Convert.ToInt32(RawId);
            //System.Threading.Timer delayThenPlaceBid = new System.Threading.Timer(obj => { AddBidToDiscussions(OriginatingBidId); }, null, 1000, System.Threading.Timeout.Infinite);
            
            Response.Redirect("CreateBid.aspx");
        }
        public void AddBidToDiscussions(int BidId) {
            /*DataContext _db = new DataContext();
            ICollection<PlacedBid> bidsSoFar = _db.LiveBids.SingleOrDefault(p => p.BidID == BidId).PlacedBids;
            PlacedBid winningBid = null;
            double winningPrice = 0;
            foreach (PlacedBid pb in bidsSoFar) { 
                if(pb.)
            }*/
        }
    }
}