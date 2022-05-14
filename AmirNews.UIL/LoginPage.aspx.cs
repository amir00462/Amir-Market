using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AmirMarket.BLL;

namespace AmirNews.UIL
{
    public partial class LoginPage : System.Web.UI.Page
    {
        UserManager userManager = new UserManager();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            Tuple<string, string> resultPage = userManager.Login(username, password);

            if (resultPage.Item1 == "error")
            {
                Response.Write("<script>alert('خطای ناشناخته')</script>");
            }
            else
            {

                if (resultPage.Item1 != "AdminPage.aspx")
                {

                    if (resultPage.Item2 == "signUp")
                    {

                        //Response.Write("<script>alert('اکانت کاربری شما ساخته شد از این به بعد با همین اکانت میتوانید لاگین کنید')</script>");
                        ScriptManager.RegisterStartupScript(this, this.GetType(),"alert","alert('اکانت کاربری شما ساخته شد از این به بعد با همین اکانت میتوانید لاگین کنید');window.location ='MarketPage.aspx';",true);

                    }
                    else
                    {

                        //Response.Write("<script>alert('شما قبلا ثبت نام کرده اید و با موفقیت وارد شدید')</script>");
                        ScriptManager.RegisterStartupScript(this, this.GetType(),"alert","alert('شما قبلا ثبت نام کرده اید و با موفقیت وارد شدید');window.location ='MarketPage.aspx';",true);

                    }


                }
                else
                {

                    //Response.Write("<script>alert('ادمین جان خوش آمدید')</script>");
                    ScriptManager.RegisterStartupScript(this, this.GetType(),"alert","alert('ادمین جان خوش آمدید');window.location ='AdminPage.aspx';",true);

                }

                //Response.Redirect(resultPage.Item1);
                //Response.End();
                //Server.Transfer(resultPage.Item1);

            }

        }
    }
}