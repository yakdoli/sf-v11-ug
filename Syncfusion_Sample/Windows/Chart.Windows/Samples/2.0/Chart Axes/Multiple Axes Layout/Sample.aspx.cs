using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Multiple Axes Layout";
            Image1.ImageUrl = "~/Chart Axes/Multiple Axes Layout/images/sample.png";
           
        }
    }
}
