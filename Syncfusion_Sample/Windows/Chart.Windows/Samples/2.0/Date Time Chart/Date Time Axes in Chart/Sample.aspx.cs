using System;
using System.Web.UI;

public partial class ScheduleTemplteSample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.Master != null)
        {
            samplebrowser master = Page.Master as samplebrowser;
            master.TogglePanelTitle = "Date Time Axes in Chart";
            Image1.ImageUrl = "~/Date Time Chart/Date Time Axes in Chart/images/sample.png";
           
        }
    }
}
