using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmirMarket.DAL;

namespace AmirMarket.BLL
{
    public class UserManager
    {
        UserDao userDao = new UserDao();

        public Tuple<string, string> Login(string username , string password)
        {
            string returnType = "";
            string result = userDao.Login(username, password);

            if (result != "error")
            {

                if(username == "root" && password == "root")
                {
                    returnType = "AdminPage.aspx";
                } else
                {
                    returnType = "MarketPage.aspx";
                }

            } else
            {
                returnType = "error";
            }


            return new Tuple<string, string>(returnType, result);
        }


    }
}
