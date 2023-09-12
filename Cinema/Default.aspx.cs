using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Application["username"] = "username";
                Application["password"] = "psw";
                Application["IsLogged"] = "false";
            }
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string Username = UsernameBox.Text;
            string Password = PasswordBox.Text;
            CompareUser(Username, Password);
           

        }
        protected void CreateCookie(string user, string psw)
        {
            HttpCookie cookie = new HttpCookie("CINEMA_COOKIE");
            cookie.Values["username"] = user;
            cookie.Values["password"] = psw;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
        }
        protected void CompareUser(string username, string password)
        {
            if(username == Application["username"].ToString() && password == Application["password"].ToString()) {
                CreateCookie(username, password);
                Application["IsLogged"] = "true";
                Response.Redirect("BuyTicket");
                
            }
            else {
                
                          
            }
        }
    }
}