using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AmirMarket.BLL;
using AmirMarket.Entities;

namespace AmirNews.UIL
{
    public partial class MarketPage : System.Web.UI.Page
    {
        ProductManager productManager = new ProductManager();


        protected void Page_Load(object sender, EventArgs e)
        {

            var dataToShow = productManager.GetAllProducts();
            gridService.DataSource = dataToShow;
            gridService.DataBind();

        }


    }
}