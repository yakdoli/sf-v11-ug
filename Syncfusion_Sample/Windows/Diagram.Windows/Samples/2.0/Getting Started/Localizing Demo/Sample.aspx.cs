using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Localizing Dialogs";
            Image1.ImageUrl = "~/Getting Started/Localizing Dialogs/Images/sample.png";
           
        }
    }
}
