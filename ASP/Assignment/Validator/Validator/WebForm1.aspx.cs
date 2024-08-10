using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Validator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string familyName = txtFamilyName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string zipCode = txtZipCode.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            Response.Redirect($"ValidationResult.aspx?name={name}&familyName={familyName}&address={address}&city={city}&zipCode={zipCode}&phone={phone}&email={email}");
        }
    }
}