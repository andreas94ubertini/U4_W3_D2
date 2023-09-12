using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class BuyTicket : System.Web.UI.Page
    {
        public static List<Room> Rooms = new List<Room>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["CINEMA_COOKIE"] != null && Application["IsLogged"].ToString() == "true")
            {
                string nome = Request.Cookies["CINEMA_COOKIE"]["username"];
                string cognome = Request.Cookies["CINEMA_COOKIE"]["password"];

                user.InnerHtml = $"Bentornato {nome}";
                if (!IsPostBack)
                {
                    Room Nord = new Room();
                    Room Sud = new Room();
                    Room Est = new Room();
                    Rooms.Add(Nord);
                    Rooms.Add(Sud);
                    Rooms.Add(Est);
                }
                WriteTable();
            }
            else
            {
                Response.Redirect("Default");
            }

        }

        protected void RoomSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(RoomSelectionList.SelectedItem.Value);
            bool Isreducted = flexCheckDefault.Checked;
            BuyOne(index, Isreducted);
            desc.InnerHtml = "";
            WriteTable();



        }
        protected void BuyOne(int index, bool Isreducted)
        {
            Rooms[index].newTicket(Isreducted);
        }
        protected void WriteTable()
        {
            desc.InnerHtml = $"<table class='table table-secondary mt-5'>" +
                $"  <thead>\r\n <tr>\r\n <th scope=\"col\">Sala</th>\r\n <th scope=\"col\">Disponibili</th>\r\n <th scope=\"col\">Interi venduti</th>\r\n <th scope=\"col\">Ridotti Venduti</th>\r\n </tr>\r\n </thead>" +
                $"  <tbody>\r\n <tr>\r\n <th scope=\"row\">Sala Nord</th>\r\n <td>{Rooms[0].GetAvailable()}</td>\r\n <td>{Rooms[0].GetSold()[0]}</td>\r\n <td>{Rooms[0].GetSold()[1]}</td>\r\n </tr>" +
                $"  <tbody>\r\n <tr>\r\n <th scope=\"row\">Sala Sud</th>\r\n <td>{Rooms[1].GetAvailable()}</td>\r\n <td>{Rooms[1].GetSold()[0]}</td>\r\n <td>{Rooms[1].GetSold()[1]}</td>\r\n </tr>" +
                $"  <tbody>\r\n <tr>\r\n <th scope=\"row\">Sala Est</th>\r\n <td>{Rooms[2].GetAvailable()}</td>\r\n <td>{Rooms[2].GetSold()[0]}</td>\r\n <td>{Rooms[2].GetSold()[1]}</td>\r\n </tr>   </tbody>\r\n</table>\r\n";

        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            HttpCookie httpCookie = new HttpCookie("CINEMA _COOKIE");
            httpCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(httpCookie);
            Application["IsLogged"] = "false";
            Response.Redirect("Default");

        }
    }
}