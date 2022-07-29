using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_WebForm_RepeaterWithClass
{
    public partial class Index : System.Web.UI.Page
    {
        List<Departments> departments;
        protected void Page_Load(object sender, EventArgs e)
        {
            //F7 ile komut satırına geçilir.
            departments = new List<Departments>
            {
                new Departments{Id=1,Name="Üretim",EmployeeCount=5},
                new Departments{Id=2,Name="Satın Alma",EmployeeCount=3},
                new Departments{Id=3,Name="Yönetim",EmployeeCount=4},
                new Departments{Id=4,Name="Muhasebe",EmployeeCount=10}
            }.OrderBy(x => x.Id).ToList();

            Repeater1.DataSource = departments;
            Repeater1.DataBind();
        }

        protected void Repeater1_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Footer)
            {
                var footer = e.Item.FindControl("lblFooter") as Label;
                footer.Text = "Toplam " + departments.Count.ToString() + " kayıt listelendi";
            }
            if (e.Item.ItemType == ListItemType.Header)
            {
                var header = e.Item.FindControl("lblHeader") as Label;
                header.Text = "Perosnel Sayısı : " + departments.Sum(x => x.EmployeeCount);
            }
        }
    }
}