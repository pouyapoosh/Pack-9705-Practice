using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema_Reservation
{
    public partial class AjaxSavingData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var name = Request.QueryString["name"];
            var family = Request.QueryString["family"];
            var seats=Request.QueryString["seats"];
            using (StreamWriter sw = new StreamWriter(Server.MapPath("~/SubmitedData/Rezerv.dat"),true))
            {
                sw.WriteLine($"{name},{family},{seats}");
            }
        }
    }
}