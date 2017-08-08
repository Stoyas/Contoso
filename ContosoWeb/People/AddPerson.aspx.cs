using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Service;

namespace ContosoWeb.People
{
    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStates.DataSource = Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            Contoso.Model.People peo = new Contoso.Model.People();
            peo.ID = 5;
            peo.FirstName = txtFirstName.Text;
            peo.LastName = txtLastName.Text;
            peo.MiddleName = txtMiddleName.Text;
            peo.Age = Convert.ToInt32(TextAge.Text);
            peo.AddressLine1 = TextAdderss.Text;
            peo.State = ddlStates.SelectedValue;
            PersonService service = new PersonService();
            service.SavePerson(peo);
            
        }
    }
}