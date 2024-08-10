using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Validator
{
    public partial class WebForm2: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblName.Text = Request.QueryString["name"];
                lblFamilyName.Text = Request.QueryString["familyName"];
                lblAddress.Text = Request.QueryString["address"];
                lblCity.Text = Request.QueryString["city"];
                lblZipCode.Text = Request.QueryString["zipCode"];
                lblPhone.Text = Request.QueryString["phone"];
                lblEmail.Text = Request.QueryString["email"];
            }
        }
    }
}