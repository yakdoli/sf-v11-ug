using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Box-and-Whisker Chart";
            Image1.ImageUrl = "~/Chart Types/Box-and-Whisker Chart/images/sample.png";
           
        }
    }
}
