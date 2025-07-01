using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Axes Label Position";
            Image1.ImageUrl = "~/Chart Axes/Axes Label Position/images/AxisLabel.png";
           
        }
    }
}
