using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using talker.Models;

namespace talker
{
    public partial class CreateBid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ListItem> categories = new List<ListItem>();
            var _db = new talker.Models.DataContext();
            IQueryable<Category> query = _db.Categories;
            List<Category> dd_categories = (from records in _db.Categories
                                         select records).ToList();
            foreach (Category cat in dd_categories){
                categories.Add(new ListItem(cat.CategoryName));
            }
            CategoriesDropDown.DataSource = categories;
            CategoriesDropDown.DataBind();
        }

        protected void Advertize_Click(object sender, EventArgs e)
        {
            string LoggedInUser = HttpContext.Current.User.Identity.Name;
            DateTime StartDate = Calendar1.SelectedDate;
            
            string StartTimeTxt = txtStartTime.Text;
            DateTime StartTime = DateTime.ParseExact(StartTimeTxt, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
            StartDate = StartDate.AddHours(StartTime.Hour);
            StartDate = StartDate.AddMinutes(StartTime.Minute);

            string EndTimeTxt = txtEndTime.Text;
            DateTime EndTime = DateTime.ParseExact(EndTimeTxt, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
            DateTime EndDate = Calendar2.SelectedDate;
            EndDate = EndDate.AddHours(EndTime.Hour);
            EndDate = EndDate.AddMinutes(EndTime.Minute);

            string CategoryName = CategoriesDropDown.SelectedValue;
            DataContext _db = new DataContext();
            LiveBid BidToPlace = new LiveBid {
                ProvidingUserName = LoggedInUser,
                AvailableStartTime = StartDate,
                AvailableEndTime = EndDate,
                DesiredBidPrice = Convert.ToDouble(TextBox1.Text),
                Status = true,
                Category = _db.Categories.SingleOrDefault(c => c.CategoryName == CategoryName),//fix - What if calendar entries are empty
                AppUser = _db.Users.Single(u => u.Id == LoggedInUser)
            };
            _db.LiveBids.Add(BidToPlace);
            _db.SaveChanges();
            Response.Redirect("LiveBids.aspx");
        }
        public IQueryable<Category> GetCategoriesForList() {
            var _db = new talker.Models.DataContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

    }
}