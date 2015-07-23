using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using talker.logic;
using talker.Models;

namespace talker
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<CartItem> GetShoppingCartItems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {

        }

        protected void CheckoutBtn_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}