using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Embed Custom Control";
            Image1.ImageUrl = "~/Embed Controls in Chart/Embed Custom Control/Images/sample.png";
           
        }
    }
}
