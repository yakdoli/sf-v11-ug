using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Right-to-Left Support";
            Image1.ImageUrl = "~/Chart Styles/Right-to-Left Support/images/sample.png";
           
        }
    }
}
