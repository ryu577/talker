using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using talker.Models;
using talker.Account;
using System.Web.ModelBinding;

namespace talker
{
    public partial class UpcomingDiscussions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Discussion> GetUpcomingDiscussions(
                        [QueryString("UserId")] int? UserId)
        {
            var _db = new talker.Models.DataContext();
            IQueryable<Discussion> query = _db.Discussions;
            string loggedInUser = HttpContext.Current.User.Identity.Name;
            if (!string.IsNullOrWhiteSpace(loggedInUser))
            {
                query = query.Where(p => p.ProvidingUserName == loggedInUser);
                query = query.Where(p => p.DiscussionStartTime > DateTime.Now);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}