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
    public partial class AdminPage : System.Web.UI.Page
    {
        ProductManager productManager = new ProductManager();


        protected void Page_Load(object sender, EventArgs e)
        {

            var dataToShow = productManager.GetAllProducts();
            gridServiceAdmin.DataSource = dataToShow;
            gridServiceAdmin.DataBind();

        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {

            var name = TextBoxName.Text.ToString();
            var price = TextBoxPrice.Text.ToString();
            var teacher = TextBoxTeacher.Text.ToString();

            var product = new Product();
            product.name = name;
            product.price = price;
            product.teacher = teacher;

            productManager.AddToDatabase(product);

            var dataToShow = productManager.GetAllProducts();
            gridServiceAdmin.DataSource = dataToShow;
            gridServiceAdmin.DataBind();

        }

        protected void ButtonRemove_Click(object sender, EventArgs e)
        {

            var name = TextBoxNameRemove.Text.ToString();

            productManager.RemoveFromDatabase(name);

            
            var dataToShow = productManager.GetAllProducts();
            gridServiceAdmin.DataSource = dataToShow;
            gridServiceAdmin.DataBind();
            gridServiceAdmin.DataBind();

        }
    }
}