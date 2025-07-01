using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Chart Drag and Drop";
            Image1.ImageUrl = "~/User Interaction/Chart Drag and Drop/Images/Sample.png";
           
        }
    }
}
