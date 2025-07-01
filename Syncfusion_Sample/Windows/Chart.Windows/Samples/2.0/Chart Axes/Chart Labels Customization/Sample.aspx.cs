using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Chart Labels Customization";
            Image1.ImageUrl = "~/Chart Axes/Chart Labels Customization/images/sample.png";
           
        }
    }
}
