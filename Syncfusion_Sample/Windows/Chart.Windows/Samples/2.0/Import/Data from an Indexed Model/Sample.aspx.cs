using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Data from an Indexed Model";
            Image1.ImageUrl = "~/Import/Data from an Indexed Model/images/sample.png";
           
        }
    }
}
