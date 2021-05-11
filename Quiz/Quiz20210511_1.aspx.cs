using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Quiz {
    public partial class Quiz20210511_1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Id"] != null && Session["Name"] != null) {
                Response.Write((string)Session["Id"] + "<br />"+ (string)Session["Name"]);
            }
        }
    }
}