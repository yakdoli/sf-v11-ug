#region Namespaces Used
using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Data;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Xml.Serialization;

using Syncfusion.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Tools.XPMenus ; 
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
#endregion


namespace CustomCodeEditorDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
	{
		#region Components on the Form

		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem22;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem27;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem28;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem29;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem30;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem31;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem25;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem26;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem23;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem44;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem45;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem46;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem47;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem48;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem49;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem50;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem52;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem53;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem54;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem55;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem56;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem57;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem58;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem59;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem61;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem60;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem62;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem63;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem64;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem65;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem66;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem67;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem68;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem69;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem70;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem71;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem72;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem73;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem74;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem24;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem75;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem76;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem77;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem78;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem79;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem80;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem81;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem82;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem83;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem84;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem85;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem86;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem87;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem88;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem89;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem90;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem91;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem92;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem93;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem94;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem95;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem96;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem97;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem98;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem99;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem100;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem101;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem102;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem103;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem104;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem105;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem106;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem107;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem108;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem109;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem110;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem111;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem112;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem114;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem113;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem115;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem117;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem118;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem119;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem120;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem116;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem121;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem32;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem33;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem34;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem35;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem36;

		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem11;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem12;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem13;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem14;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem15;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem16;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem17;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem18;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem19;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem20;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem21;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem22;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem23;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem24;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;

		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;

		private System.ComponentModel.IContainer components = null;

		private InsertText inputdialog;
		private string inputString = string.Empty;
		private bool accepted = false;
		private System.Windows.Forms.ImageList imageList1;
		private Bitmap image1, image2, image3, image4, selectedImage;

		private Cursor currentCursor = Cursors.Default;

		static Form1 form1 = null;

		#endregion


        #region Declaration
        private XmlTextReader reader;
        private string intellisensePath = Path.GetDirectoryName( Application.ExecutablePath ) + @"\..\..\Intellisense.xml";
        private string imagePath = Path.GetDirectoryName( Application.ExecutablePath ) + @"\..\..\Images\";
		private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\";
		private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\CSharpSource.cs";
		private string generatedFilesPath=Path.GetDirectoryName(Application.ExecutablePath ) + @"\..\..\Generated Files";
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem37;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem38;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem39;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem40;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem41;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem42;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem43;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem51;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RadioButton radioButton16;
		private System.Windows.Forms.RadioButton radioButton15;
		private System.Windows.Forms.RadioButton radioButton14;
		private System.Windows.Forms.RadioButton radioButton13;
		private System.Windows.Forms.RadioButton radioButton12;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton radioButton9;
		private System.Windows.Forms.RadioButton radioButton10;
		private System.Windows.Forms.RadioButton radioButton11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton radioButton25;
		private System.Windows.Forms.RadioButton radioButton26;
		private System.Windows.Forms.RadioButton radioButton27;
		private System.Windows.Forms.RadioButton radioButton28;
		private System.Windows.Forms.RadioButton radioButton29;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.RadioButton radioButton30;
		private System.Windows.Forms.RadioButton radioButton31;
		private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;		
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton radioButton17;
		private System.Windows.Forms.RadioButton radioButton18;
		private System.Windows.Forms.RadioButton radioButton19;
		private System.Windows.Forms.RadioButton radioButton20;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.RadioButton radioButton21;
		private System.Windows.Forms.RadioButton radioButton22;
		private System.Windows.Forms.RadioButton radioButton23;
		private System.Windows.Forms.RadioButton radioButton24;
		private System.Windows.Forms.Panel panel1;
        public Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.PropertyGrid propertyEditor;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private ParentBarItem parentBarItem25;
        private BarItem barItem122;
		private string exportPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Generated Files\";
        private BarItem barItem123;
        private BarItem barItem124;
        private ImageList imageList2;
        private ArrayList arr;

        #endregion

        #region Initialization code

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            mainFrameBarManager1.InternalDocking = false;
            image1 = new Bitmap( imagePath + "Image1.png" );
            image2 = new Bitmap( imagePath + "Image2.png" );
            image3 = new Bitmap( imagePath + "Image3.png" );
            image4 = new Bitmap( imagePath + "Image4.png" );

            selectedImage = image4;

            this.editControl1.ShowHorizontalSplitters = true;
            this.editControl1.ShowVerticalSplitters = true;

            inputdialog = new InsertText();
            inputdialog.AcceptButton.Click += new EventHandler( AcceptButton_Clicked );
            inputdialog.CancelButton.Click += new EventHandler( CancelButton_Clicked );

            this.barItem10.Enabled = false;
            this.barItem11.Enabled = false;

            this.editControl1.StatusBarSettings.StatusPanel.Visible = false;
            this.editControl1.LoadFile( filePath );
            Directory.CreateDirectory( generatedFilesPath );
            generatedFilesPath += "\\";

            arr = new ArrayList();

            #region Property grid settings
            this.propertyEditor.BackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.CommandsBackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.CommandsForeColor = System.Drawing.Color.MidnightBlue;
            this.propertyEditor.Font = new System.Drawing.Font( "Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( System.Byte )( 0 ) ) );
            this.propertyEditor.HelpBackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.HelpForeColor = System.Drawing.Color.MidnightBlue;
            this.propertyEditor.LineColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 185 ) ), ( ( System.Byte )( 216 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.ViewBackColor = System.Drawing.Color.FromArgb( ( ( System.Byte )( 227 ) ), ( ( System.Byte )( 239 ) ), ( ( System.Byte )( 255 ) ) );
            this.propertyEditor.ViewForeColor = System.Drawing.Color.MidnightBlue;
            #endregion

            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler( this.editControl1_ContextChoiceOpen );
            this.editControl1.ContextPromptBeforeOpen += new System.ComponentModel.CancelEventHandler( this.editControl1_ContextPromptBeforeOpen );
            this.editControl1.ContextChoiceBeforeOpen += new System.ComponentModel.CancelEventHandler( this.editControl1_ContextChoiceBeforeOpen );
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler( this.editControl1_ContextChoiceClose );
            this.editControl1.ContextPromptOpen += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler( this.editControl1_ContextPromptOpen );
            this.editControl1.ContextChoiceItemSelected += new Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventHandler( this.editControl1_ContextChoiceItemSelected );

            int index = 0;
            foreach ( Image img in this.imageList2.Images )
            {
                // Populating images using an external ImageList
                this.editControl1.ContextChoiceController.AddImage( "Image" + index.ToString(), img );
                index++;
            }

        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if ( disposing )
            {
                if ( components != null )
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }
        #endregion         
		
        private void AcceptButton_Clicked (object sender, EventArgs args)
		{
			this.inputString = this.inputdialog.InputString;
			this.accepted = true;
			this.inputdialog.Close();
		}

		private void CancelButton_Clicked (object sender, EventArgs args)
		{
			this.accepted = false;
			this.inputdialog.Close();
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Mainmenu");
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem52 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem53 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem54 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem120 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem48 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem49 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem50 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem29 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem30 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem33 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem34 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem35 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem36 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem32 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem55 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem56 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem57 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem61 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem119 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem58 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem59 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem60 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem116 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem84 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem121 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem62 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem63 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem64 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem65 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem66 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem67 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem68 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem69 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem70 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem71 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem72 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem73 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem74 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem89 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem90 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem99 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem100 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem93 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem94 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem91 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem92 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem97 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem98 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem95 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem96 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem112 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem75 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem86 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem87 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem88 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem77 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem78 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem79 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem115 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem114 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem113 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem109 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem110 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem111 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem106 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem107 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem108 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem101 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem102 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem103 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem104 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem105 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem123 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem124 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem80 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem81 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem82 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem83 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem44 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem45 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem46 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem47 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem38 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem37 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem39 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem40 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem41 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem42 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem43 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem118 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem117 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem122 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Standered");
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem31 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barItem76 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem85 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem51 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.parentBarItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.propertyEditor = new System.Windows.Forms.PropertyGrid();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("&File");
            this.mainFrameBarManager1.Categories.Add("&Edit");
            this.mainFrameBarManager1.Categories.Add("Window");
            this.mainFrameBarManager1.Categories.Add("&Language");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.Categories.Add("Property Grid");
            this.mainFrameBarManager1.Categories.Add("Print");
            this.mainFrameBarManager1.CurrentBaseFormType = "";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.ImageList = this.imageList1;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.barItem15,
            this.barItem1,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.parentBarItem4,
            this.barItem2,
            this.barItem21,
            this.barItem22,
            this.parentBarItem7,
            this.barItem27,
            this.barItem28,
            this.barItem29,
            this.barItem3,
            this.barItem30,
            this.barItem31,
            this.barItem4,
            this.barItem5,
            this.parentBarItem5,
            this.barItem6,
            this.parentBarItem3,
            this.barItem26,
            this.barItem25,
            this.parentBarItem11,
            this.barItem44,
            this.parentBarItem1,
            this.barItem45,
            this.barItem46,
            this.barItem47,
            this.barItem49,
            this.barItem48,
            this.barItem7,
            this.barItem50,
            this.parentBarItem13,
            this.barItem62,
            this.barItem63,
            this.parentBarItem2,
            this.barItem64,
            this.barItem65,
            this.barItem66,
            this.barItem67,
            this.barItem68,
            this.barItem8,
            this.barItem69,
            this.barItem70,
            this.barItem71,
            this.barItem72,
            this.barItem73,
            this.barItem74,
            this.barItem9,
            this.barItem75,
            this.barItem76,
            this.parentBarItem14,
            this.barItem77,
            this.barItem78,
            this.barItem79,
            this.parentBarItem15,
            this.barItem20,
            this.barItem80,
            this.barItem81,
            this.barItem82,
            this.barItem83,
            this.barItem86,
            this.barItem87,
            this.parentBarItem17,
            this.barItem88,
            this.parentBarItem10,
            this.barItem23,
            this.barItem24,
            this.barItem52,
            this.barItem53,
            this.barItem54,
            this.parentBarItem12,
            this.barItem55,
            this.barItem56,
            this.barItem57,
            this.barItem58,
            this.barItem59,
            this.barItem61,
            this.barItem60,
            this.barItem84,
            this.barItem85,
            this.parentBarItem18,
            this.barItem89,
            this.barItem90,
            this.barItem91,
            this.barItem92,
            this.barItem93,
            this.barItem94,
            this.barItem95,
            this.barItem96,
            this.barItem97,
            this.barItem98,
            this.barItem99,
            this.barItem100,
            this.parentBarItem19,
            this.parentBarItem20,
            this.parentBarItem21,
            this.parentBarItem22,
            this.barItem101,
            this.barItem102,
            this.barItem103,
            this.barItem104,
            this.barItem105,
            this.barItem106,
            this.barItem107,
            this.barItem108,
            this.barItem109,
            this.barItem110,
            this.barItem111,
            this.barItem112,
            this.parentBarItem23,
            this.barItem114,
            this.barItem113,
            this.barItem115,
            this.barItem116,
            this.barItem117,
            this.barItem118,
            this.barItem119,
            this.barItem120,
            this.parentBarItem24,
            this.barItem121,
            this.barItem32,
            this.parentBarItem6,
            this.barItem33,
            this.barItem34,
            this.barItem35,
            this.barItem36,
            this.barItem37,
            this.barItem38,
            this.parentBarItem8,
            this.barItem39,
            this.barItem40,
            this.barItem41,
            this.parentBarItem9,
            this.barItem42,
            this.barItem43,
            this.barItem51,
            this.barItem122,
            this.parentBarItem25,
            this.barItem123,
            this.barItem124});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "Mainmenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
            this.bar1.Caption = "Mainmenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem2,
            this.parentBarItem3,
            this.parentBarItem10,
            this.parentBarItem12,
            this.parentBarItem24,
            this.parentBarItem11,
            this.barItem118,
            this.parentBarItem25});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "&File";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem52,
            this.barItem53,
            this.barItem54,
            this.barItem120,
            this.barItem20});
            this.parentBarItem2.SeparatorIndices.AddRange(new int[] {
            2,
            4,
            7});
            this.parentBarItem2.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "&New";
            this.barItem1.ImageIndex = 0;
            this.barItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.barItem1.Text = "&New";
            this.barItem1.Tooltip = "New Document";
            this.barItem1.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "&Open";
            this.barItem2.ImageIndex = 43;
            this.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.barItem2.Text = "&Open";
            this.barItem2.Tooltip = "Open Document";
            this.barItem2.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "&Save";
            this.barItem3.ImageIndex = 44;
            this.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.barItem3.Text = "&Save";
            this.barItem3.Tooltip = "Save File";
            this.barItem3.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Save &As";
            this.barItem4.ImageIndex = 53;
            this.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftA;
            this.barItem4.Text = "Save &As";
            this.barItem4.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem52
            // 
            this.barItem52.CategoryIndex = 0;
            this.barItem52.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem52.ID = "Save As &HTML";
            this.barItem52.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH;
            this.barItem52.Text = "Save As &HTML";
            this.barItem52.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem53
            // 
            this.barItem53.CategoryIndex = 0;
            this.barItem53.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem53.ID = "Save As &XML";
            this.barItem53.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftX;
            this.barItem53.Text = "Save As &XML";
            this.barItem53.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem54
            // 
            this.barItem54.CategoryIndex = 0;
            this.barItem54.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem54.ID = "Save As &RTF";
            this.barItem54.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftR;
            this.barItem54.Text = "Save As &RTF";
            this.barItem54.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem120
            // 
            this.barItem120.CategoryIndex = 0;
            this.barItem120.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem120.ID = "Close";
            this.barItem120.Text = "C&lose";
            this.barItem120.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // barItem20
            // 
            this.barItem20.CategoryIndex = 0;
            this.barItem20.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem20.ID = "E&xit";
            this.barItem20.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.barItem20.Text = "E&xit";
            this.barItem20.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.CategoryIndex = 1;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "&Edit";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.barItem16,
            this.barItem15,
            this.barItem48,
            this.barItem49,
            this.barItem50,
            this.barItem17,
            this.barItem18,
            this.barItem19,
            this.parentBarItem4});
            this.parentBarItem3.SeparatorIndices.AddRange(new int[] {
            2,
            7,
            10});
            this.parentBarItem3.Text = "&Edit";
            // 
            // barItem10
            // 
            this.barItem10.CategoryIndex = 1;
            this.barItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem10.Enabled = false;
            this.barItem10.ID = "&Undo";
            this.barItem10.ImageIndex = 45;
            this.barItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.barItem10.Text = "&Undo";
            this.barItem10.Tooltip = "Undo";
            this.barItem10.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem11
            // 
            this.barItem11.CategoryIndex = 1;
            this.barItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem11.Enabled = false;
            this.barItem11.ID = "&Redo";
            this.barItem11.ImageIndex = 46;
            this.barItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.barItem11.Text = "&Redo";
            this.barItem11.Tooltip = "Redo";
            this.barItem11.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem12
            // 
            this.barItem12.CategoryIndex = 1;
            this.barItem12.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem12.ID = "Cu&t";
            this.barItem12.ImageIndex = 47;
            this.barItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.barItem12.Text = "Cu&t";
            this.barItem12.Tooltip = "Cut";
            this.barItem12.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem13
            // 
            this.barItem13.CategoryIndex = 1;
            this.barItem13.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem13.ID = "&Copy";
            this.barItem13.ImageIndex = 48;
            this.barItem13.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.barItem13.Text = "&Copy";
            this.barItem13.Tooltip = "Copy";
            this.barItem13.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem14
            // 
            this.barItem14.CategoryIndex = 1;
            this.barItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem14.ID = "&Paste";
            this.barItem14.ImageIndex = 49;
            this.barItem14.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.barItem14.Text = "&Paste";
            this.barItem14.Tooltip = "Paste";
            this.barItem14.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem16
            // 
            this.barItem16.CategoryIndex = 1;
            this.barItem16.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem16.ID = "Select &All";
            this.barItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.barItem16.Text = "Select &All";
            this.barItem16.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem15
            // 
            this.barItem15.CategoryIndex = 1;
            this.barItem15.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem15.ID = "Delete";
            this.barItem15.ImageIndex = 51;
            this.barItem15.ShortcutText = "Del";
            this.barItem15.Text = "Delete";
            this.barItem15.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem48
            // 
            this.barItem48.CategoryIndex = 1;
            this.barItem48.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem48.ID = "CollapseAll";
            this.barItem48.Text = "CollapseAll";
            this.barItem48.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem49
            // 
            this.barItem49.CategoryIndex = 1;
            this.barItem49.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem49.ID = "ExpandAll";
            this.barItem49.Text = "ExpandAll";
            this.barItem49.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem50
            // 
            this.barItem50.CategoryIndex = 1;
            this.barItem50.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem50.ID = "Show Collapsers";
            this.barItem50.Text = "Show Collapsers";
            this.barItem50.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem17
            // 
            this.barItem17.CategoryIndex = 1;
            this.barItem17.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem17.ID = "Find";
            this.barItem17.ImageIndex = 54;
            this.barItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
            this.barItem17.Text = "Find";
            this.barItem17.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem18
            // 
            this.barItem18.CategoryIndex = 1;
            this.barItem18.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem18.ID = "Replace";
            this.barItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.barItem18.Text = "Replace";
            this.barItem18.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem19
            // 
            this.barItem19.CategoryIndex = 1;
            this.barItem19.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem19.ID = "Goto";
            this.barItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.barItem19.Text = "GoTo";
            this.barItem19.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.CategoryIndex = 1;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "&Book Marks";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem5,
            this.parentBarItem6,
            this.barItem25,
            this.barItem26,
            this.barItem35,
            this.barItem36});
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem4.Text = "&Book Marks";
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.CategoryIndex = 1;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "Custom";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem7,
            this.barItem21});
            this.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem5.Text = "Custom";
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.CategoryIndex = 1;
            this.parentBarItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem7.ID = "Select Image";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem27,
            this.barItem28,
            this.barItem29,
            this.barItem30});
            this.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem7.Text = "Select Image";
            // 
            // barItem27
            // 
            this.barItem27.CategoryIndex = 1;
            this.barItem27.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem27.ID = "Image1";
            this.barItem27.ImageIndex = 70;
            this.barItem27.Text = "Image1";
            this.barItem27.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem28
            // 
            this.barItem28.CategoryIndex = 1;
            this.barItem28.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem28.ID = "Image2";
            this.barItem28.ImageIndex = 71;
            this.barItem28.Text = "Image2";
            this.barItem28.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem29
            // 
            this.barItem29.CategoryIndex = 1;
            this.barItem29.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem29.ID = "Image3";
            this.barItem29.ImageIndex = 72;
            this.barItem29.Text = "Image3";
            this.barItem29.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem30
            // 
            this.barItem30.CategoryIndex = 1;
            this.barItem30.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem30.ID = "Image4";
            this.barItem30.ImageIndex = 73;
            this.barItem30.Text = "Image4";
            this.barItem30.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem21
            // 
            this.barItem21.CategoryIndex = 1;
            this.barItem21.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem21.ID = "Insert CustomBookMark";
            this.barItem21.Text = "Insert CustomBookMark";
            this.barItem21.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.CategoryIndex = 1;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "Default_1";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem33,
            this.barItem34});
            this.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem6.Text = "Default";
            // 
            // barItem33
            // 
            this.barItem33.CategoryIndex = 1;
            this.barItem33.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem33.ID = "Add BookMark";
            this.barItem33.Text = "Add BookMark";
            this.barItem33.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem34
            // 
            this.barItem34.CategoryIndex = 1;
            this.barItem34.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem34.ID = "Remove BookMark";
            this.barItem34.Text = "Remove BookMark";
            this.barItem34.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem25
            // 
            this.barItem25.CategoryIndex = 1;
            this.barItem25.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem25.ID = "&Next BookMark";
            this.barItem25.ImageIndex = 9;
            this.barItem25.Text = "&Next BookMark";
            this.barItem25.Tooltip = "Next BookMark";
            this.barItem25.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem26
            // 
            this.barItem26.CategoryIndex = 1;
            this.barItem26.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem26.ID = "&Previous BookMark";
            this.barItem26.ImageIndex = 10;
            this.barItem26.Text = "&Previous BookMark";
            this.barItem26.Tooltip = "Previous Bookmark";
            this.barItem26.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem35
            // 
            this.barItem35.CategoryIndex = 1;
            this.barItem35.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem35.ID = "Toggle BookMark_1";
            this.barItem35.Text = "Toggle BookMark";
            this.barItem35.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem36
            // 
            this.barItem36.CategoryIndex = 1;
            this.barItem36.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem36.ID = "Clear All BookMarks";
            this.barItem36.Text = "Clear All BookMarks";
            this.barItem36.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // parentBarItem10
            // 
            this.parentBarItem10.CategoryIndex = 2;
            this.parentBarItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem10.ID = "&Window";
            this.parentBarItem10.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem23,
            this.barItem24,
            this.barItem32});
            this.parentBarItem10.Text = "&Window";
            // 
            // barItem23
            // 
            this.barItem23.CategoryIndex = 2;
            this.barItem23.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem23.ID = "Split Vertically";
            this.barItem23.ImageIndex = 57;
            this.barItem23.Text = "Split Vertically";
            this.barItem23.Click += new System.EventHandler(this.WindowMenuClick);
            // 
            // barItem24
            // 
            this.barItem24.CategoryIndex = 2;
            this.barItem24.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem24.ID = "Split Horizontally";
            this.barItem24.ImageIndex = 56;
            this.barItem24.Text = "Split Horizontally";
            this.barItem24.Click += new System.EventHandler(this.WindowMenuClick);
            // 
            // barItem32
            // 
            this.barItem32.CategoryIndex = 2;
            this.barItem32.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem32.ID = "Split Into Quadrants";
            this.barItem32.ImageIndex = 55;
            this.barItem32.Text = "Split Into Quadrants";
            this.barItem32.Click += new System.EventHandler(this.WindowMenuClick);
            // 
            // parentBarItem12
            // 
            this.parentBarItem12.CategoryIndex = 3;
            this.parentBarItem12.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem12.ID = "&Language";
            this.parentBarItem12.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem55,
            this.barItem56,
            this.barItem57,
            this.barItem61,
            this.barItem119,
            this.barItem58,
            this.barItem59,
            this.barItem60,
            this.barItem116,
            this.barItem84});
            this.parentBarItem12.SeparatorIndices.AddRange(new int[] {
            9});
            this.parentBarItem12.Text = "&Language";
            // 
            // barItem55
            // 
            this.barItem55.CategoryIndex = 3;
            this.barItem55.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem55.ID = "CSharp";
            this.barItem55.Text = "CSharp";
            this.barItem55.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem56
            // 
            this.barItem56.CategoryIndex = 3;
            this.barItem56.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem56.ID = "HTML";
            this.barItem56.Text = "HTML";
            this.barItem56.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem57
            // 
            this.barItem57.CategoryIndex = 3;
            this.barItem57.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem57.ID = "XML";
            this.barItem57.Text = "XML";
            this.barItem57.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem61
            // 
            this.barItem61.CategoryIndex = 3;
            this.barItem61.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem61.ID = "VB .Net";
            this.barItem61.Text = "VB.NET";
            this.barItem61.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem119
            // 
            this.barItem119.CategoryIndex = 3;
            this.barItem119.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem119.ID = "SQL";
            this.barItem119.Text = "SQL";
            this.barItem119.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem58
            // 
            this.barItem58.CategoryIndex = 3;
            this.barItem58.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem58.ID = "Pascal";
            this.barItem58.Text = "Pascal";
            this.barItem58.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem59
            // 
            this.barItem59.CategoryIndex = 3;
            this.barItem59.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem59.ID = "Delphi";
            this.barItem59.Text = "VBScript";
            this.barItem59.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem60
            // 
            this.barItem60.CategoryIndex = 3;
            this.barItem60.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem60.ID = "HTML with embedded JScript";
            this.barItem60.Text = "JScript";
            this.barItem60.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem116
            // 
            this.barItem116.CategoryIndex = 3;
            this.barItem116.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem116.ID = "Default Language";
            this.barItem116.Text = "Default Language";
            this.barItem116.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // barItem84
            // 
            this.barItem84.CategoryIndex = 3;
            this.barItem84.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem84.ID = "Modify Text  Properties";
            this.barItem84.ImageIndex = 69;
            this.barItem84.Text = "Configuration Editor";
            this.barItem84.Tooltip = "Configuration Editor";
            this.barItem84.Click += new System.EventHandler(this.LanguageMenuClick);
            // 
            // parentBarItem24
            // 
            this.parentBarItem24.CategoryIndex = 6;
            this.parentBarItem24.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem24.ID = "Print_1";
            this.parentBarItem24.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem121,
            this.barItem5,
            this.barItem6,
            this.parentBarItem1});
            this.parentBarItem24.Text = "Printing";
            // 
            // barItem121
            // 
            this.barItem121.CategoryIndex = 6;
            this.barItem121.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem121.ID = "&Print";
            this.barItem121.Text = "&Print";
            this.barItem121.Click += new System.EventHandler(this.PrintingMenuClick);
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 6;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "&Print Preview";
            this.barItem5.ImageIndex = 52;
            this.barItem5.Text = "Print Preview";
            this.barItem5.Tooltip = "Print Preview";
            this.barItem5.Click += new System.EventHandler(this.PrintingMenuClick);
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = 6;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "&Show Print Dialog";
            this.barItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.barItem6.Text = "Print Dialog";
            this.barItem6.Click += new System.EventHandler(this.PrintingMenuClick);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 6;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "Print";
            this.parentBarItem1.ImageIndex = 50;
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9,
            this.barItem8,
            this.barItem7});
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem1.Text = "Print Options";
            this.parentBarItem1.Tooltip = "print";
            // 
            // barItem9
            // 
            this.barItem9.CategoryIndex = 6;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "Print Current Page";
            this.barItem9.Text = "Print Current Page";
            this.barItem9.Click += new System.EventHandler(this.PrintingMenuClick);
            // 
            // barItem8
            // 
            this.barItem8.CategoryIndex = 6;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "Print Selected Text";
            this.barItem8.Text = "Print Selected Text";
            this.barItem8.Click += new System.EventHandler(this.PrintingMenuClick);
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = 6;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "Print To document";
            this.barItem7.Text = "Print To File";
            this.barItem7.Click += new System.EventHandler(this.PrintingMenuClick);
            // 
            // parentBarItem11
            // 
            this.parentBarItem11.CategoryIndex = 1;
            this.parentBarItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem11.ID = "Ad&vanced";
            this.parentBarItem11.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem13,
            this.parentBarItem18,
            this.barItem112,
            this.barItem75,
            this.barItem86,
            this.parentBarItem17,
            this.parentBarItem14,
            this.parentBarItem23,
            this.parentBarItem19,
            this.barItem123,
            this.barItem124,
            this.parentBarItem15,
            this.barItem83,
            this.barItem44,
            this.barItem45,
            this.barItem46,
            this.barItem47,
            this.barItem38,
            this.barItem37,
            this.parentBarItem8,
            this.parentBarItem9});
            this.parentBarItem11.SeparatorIndices.AddRange(new int[] {
            11,
            13,
            17});
            this.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem11.Text = "Ad&vanced";
            // 
            // parentBarItem13
            // 
            this.parentBarItem13.CategoryIndex = 1;
            this.parentBarItem13.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem13.ID = "Custom Cursor";
            this.parentBarItem13.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem62,
            this.barItem63,
            this.barItem64,
            this.barItem65,
            this.barItem66,
            this.barItem67,
            this.barItem68,
            this.barItem69,
            this.barItem70,
            this.barItem71,
            this.barItem72,
            this.barItem73,
            this.barItem74});
            this.parentBarItem13.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem13.Text = "Custom Cursor";
            // 
            // barItem62
            // 
            this.barItem62.CategoryIndex = 1;
            this.barItem62.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem62.ID = "AppStarting";
            this.barItem62.Text = "AppStarting";
            this.barItem62.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem63
            // 
            this.barItem63.CategoryIndex = 1;
            this.barItem63.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem63.ID = "Arrow";
            this.barItem63.Text = "Arrow";
            this.barItem63.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem64
            // 
            this.barItem64.CategoryIndex = 1;
            this.barItem64.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem64.ID = "Cross";
            this.barItem64.Text = "Cross";
            this.barItem64.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem65
            // 
            this.barItem65.CategoryIndex = 1;
            this.barItem65.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem65.ID = "Default";
            this.barItem65.Text = "Default";
            this.barItem65.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem66
            // 
            this.barItem66.CategoryIndex = 1;
            this.barItem66.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem66.ID = "Hand";
            this.barItem66.Text = "Hand";
            this.barItem66.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem67
            // 
            this.barItem67.CategoryIndex = 1;
            this.barItem67.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem67.ID = "Help";
            this.barItem67.Text = "Help";
            this.barItem67.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem68
            // 
            this.barItem68.CategoryIndex = 1;
            this.barItem68.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem68.ID = "HSplit";
            this.barItem68.Text = "HSplit";
            this.barItem68.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem69
            // 
            this.barItem69.CategoryIndex = 1;
            this.barItem69.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem69.ID = "IBeam";
            this.barItem69.Text = "IBeam";
            this.barItem69.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem70
            // 
            this.barItem70.CategoryIndex = 1;
            this.barItem70.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem70.ID = "No";
            this.barItem70.Text = "No";
            this.barItem70.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem71
            // 
            this.barItem71.CategoryIndex = 1;
            this.barItem71.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem71.ID = "SizeAll";
            this.barItem71.Text = "SizeAll";
            this.barItem71.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem72
            // 
            this.barItem72.CategoryIndex = 1;
            this.barItem72.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem72.ID = "UpArrow";
            this.barItem72.Text = "UpArrow";
            this.barItem72.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem73
            // 
            this.barItem73.CategoryIndex = 1;
            this.barItem73.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem73.ID = "VSplit";
            this.barItem73.Text = "VSplit";
            this.barItem73.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // barItem74
            // 
            this.barItem74.CategoryIndex = 1;
            this.barItem74.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem74.ID = "WaitCursor";
            this.barItem74.Text = "WaitCursor";
            this.barItem74.Click += new System.EventHandler(this.CustomCursorMenuClick);
            // 
            // parentBarItem18
            // 
            this.parentBarItem18.CategoryIndex = 1;
            this.parentBarItem18.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem18.ID = "NavigationMenu";
            this.parentBarItem18.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem89,
            this.barItem90,
            this.barItem99,
            this.barItem100,
            this.barItem93,
            this.barItem94,
            this.barItem91,
            this.barItem92,
            this.barItem97,
            this.barItem98,
            this.barItem95,
            this.barItem96});
            this.parentBarItem18.SeparatorIndices.AddRange(new int[] {
            4,
            6,
            8,
            10});
            this.parentBarItem18.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem18.Text = "NavigationMenu";
            // 
            // barItem89
            // 
            this.barItem89.CategoryIndex = 1;
            this.barItem89.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem89.ID = "Move Up";
            this.barItem89.ImageIndex = 64;
            this.barItem89.Text = "Move Up";
            this.barItem89.Click += new System.EventHandler(this.NavigationMenu_Click);
            // 
            // barItem90
            // 
            this.barItem90.CategoryIndex = 1;
            this.barItem90.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem90.ID = "Move Down";
            this.barItem90.ImageIndex = 65;
            this.barItem90.Text = "Move Down";
            this.barItem90.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem99
            // 
            this.barItem99.CategoryIndex = 1;
            this.barItem99.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem99.ID = "Move to Line Start";
            this.barItem99.Text = "Move to Line Start";
            this.barItem99.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem100
            // 
            this.barItem100.CategoryIndex = 1;
            this.barItem100.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem100.ID = "Move to Line End";
            this.barItem100.Text = "Move to Line End";
            this.barItem100.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem93
            // 
            this.barItem93.CategoryIndex = 1;
            this.barItem93.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem93.ID = "Page Up";
            this.barItem93.ImageIndex = 66;
            this.barItem93.Text = "Page Up";
            this.barItem93.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem94
            // 
            this.barItem94.CategoryIndex = 1;
            this.barItem94.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem94.ID = "Page Down";
            this.barItem94.ImageIndex = 67;
            this.barItem94.Text = "Page Down";
            this.barItem94.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem91
            // 
            this.barItem91.CategoryIndex = 1;
            this.barItem91.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem91.ID = "Move Left";
            this.barItem91.ImageIndex = 63;
            this.barItem91.Text = "Move Left";
            this.barItem91.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem92
            // 
            this.barItem92.CategoryIndex = 1;
            this.barItem92.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem92.ID = "Move Right";
            this.barItem92.ImageIndex = 62;
            this.barItem92.Text = "Move Right";
            this.barItem92.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem97
            // 
            this.barItem97.CategoryIndex = 1;
            this.barItem97.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem97.ID = "Move Left One Word";
            this.barItem97.Text = "Move Left One Word";
            this.barItem97.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem98
            // 
            this.barItem98.CategoryIndex = 1;
            this.barItem98.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem98.ID = "Move Right One Word";
            this.barItem98.Text = "Move Right One Word";
            this.barItem98.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem95
            // 
            this.barItem95.CategoryIndex = 1;
            this.barItem95.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem95.ID = "Move to Start";
            this.barItem95.Text = "Move to Start";
            this.barItem95.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem96
            // 
            this.barItem96.CategoryIndex = 1;
            this.barItem96.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem96.ID = "Move to End";
            this.barItem96.Text = "Move to End";
            this.barItem96.Click += new System.EventHandler(this.moveMenuItem_Click);
            // 
            // barItem112
            // 
            this.barItem112.CategoryIndex = 1;
            this.barItem112.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem112.ID = "Bind Keys";
            this.barItem112.ImageIndex = 58;
            this.barItem112.Text = "Bind Keys";
            this.barItem112.Tooltip = "Keyboard Binding";
            this.barItem112.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem75
            // 
            this.barItem75.CategoryIndex = 1;
            this.barItem75.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem75.ID = "SetLineBackColor";
            this.barItem75.ImageIndex = 59;
            this.barItem75.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem75.Text = "LineBackColor";
            this.barItem75.Tooltip = "Set Line Color";
            this.barItem75.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem86
            // 
            this.barItem86.CategoryIndex = 1;
            this.barItem86.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem86.ID = "Set Underlines";
            this.barItem86.ImageIndex = 60;
            this.barItem86.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem86.Text = "Underlines";
            this.barItem86.Tooltip = "Underlines";
            this.barItem86.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // parentBarItem17
            // 
            this.parentBarItem17.CategoryIndex = 1;
            this.parentBarItem17.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem17.ID = "Editor BackColor";
            this.parentBarItem17.ImageIndex = 61;
            this.parentBarItem17.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem87,
            this.barItem88});
            this.parentBarItem17.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem17.Text = "Editor BackColor";
            this.parentBarItem17.Tooltip = "Editor BackColor";
            // 
            // barItem87
            // 
            this.barItem87.CategoryIndex = 1;
            this.barItem87.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem87.ID = "GradientBackGround";
            this.barItem87.ImageIndex = 68;
            this.barItem87.Text = "GradientBackGround";
            this.barItem87.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem88
            // 
            this.barItem88.CategoryIndex = 1;
            this.barItem88.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem88.ID = "Regular_1";
            this.barItem88.ImageIndex = 30;
            this.barItem88.Text = "Regular";
            this.barItem88.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // parentBarItem14
            // 
            this.parentBarItem14.CategoryIndex = 1;
            this.parentBarItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem14.ID = "Modify Text";
            this.parentBarItem14.ImageIndex = 24;
            this.parentBarItem14.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem77,
            this.barItem78,
            this.barItem79,
            this.barItem115});
            this.parentBarItem14.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem14.Text = "Modify Text";
            this.parentBarItem14.Tooltip = "Modify Text";
            // 
            // barItem77
            // 
            this.barItem77.CategoryIndex = 1;
            this.barItem77.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem77.ID = "SetText";
            this.barItem77.Text = "SetText";
            this.barItem77.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem78
            // 
            this.barItem78.CategoryIndex = 1;
            this.barItem78.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem78.ID = "AppendText";
            this.barItem78.Text = "AppendText";
            this.barItem78.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem79
            // 
            this.barItem79.CategoryIndex = 1;
            this.barItem79.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem79.ID = "InsertText";
            this.barItem79.Text = "InsertText";
            this.barItem79.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem115
            // 
            this.barItem115.CategoryIndex = 1;
            this.barItem115.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem115.ID = "Insert XML Tag";
            this.barItem115.Text = "Insert XML Tag";
            this.barItem115.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // parentBarItem23
            // 
            this.parentBarItem23.CategoryIndex = 1;
            this.parentBarItem23.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem23.ID = "IndentationGuidelines";
            this.parentBarItem23.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem114,
            this.barItem113});
            this.parentBarItem23.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem23.Text = "IndentationGuidelines";
            // 
            // barItem114
            // 
            this.barItem114.CategoryIndex = 1;
            this.barItem114.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem114.ID = "MoveToBeginingOfBlock";
            this.barItem114.Text = "MoveToBeginingOfBlock";
            this.barItem114.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem113
            // 
            this.barItem113.CategoryIndex = 1;
            this.barItem113.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem113.ID = "MoveToEndOfBlock";
            this.barItem113.Text = "MoveToEndOfBlock";
            this.barItem113.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // parentBarItem19
            // 
            this.parentBarItem19.CategoryIndex = 1;
            this.parentBarItem19.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem19.ID = "Selection Margin";
            this.parentBarItem19.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem22,
            this.parentBarItem21,
            this.parentBarItem20});
            this.parentBarItem19.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem19.Text = "Selection Margin";
            // 
            // parentBarItem22
            // 
            this.parentBarItem22.CategoryIndex = 1;
            this.parentBarItem22.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem22.ID = "BackGroundColor";
            this.parentBarItem22.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem109,
            this.barItem110,
            this.barItem111});
            this.parentBarItem22.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem22.Text = "BackGroundColor";
            // 
            // barItem109
            // 
            this.barItem109.CategoryIndex = 1;
            this.barItem109.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem109.ID = "LightBlue";
            this.barItem109.Text = "LightBlue";
            this.barItem109.Click += new System.EventHandler(this.BackgroundColor_menuItem_Click);
            // 
            // barItem110
            // 
            this.barItem110.CategoryIndex = 1;
            this.barItem110.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem110.ID = "IndianRed";
            this.barItem110.Text = "IndianRed";
            this.barItem110.Click += new System.EventHandler(this.BackgroundColor_menuItem_Click);
            // 
            // barItem111
            // 
            this.barItem111.CategoryIndex = 1;
            this.barItem111.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem111.ID = "Beige";
            this.barItem111.Text = "Beige";
            this.barItem111.Click += new System.EventHandler(this.BackgroundColor_menuItem_Click);
            // 
            // parentBarItem21
            // 
            this.parentBarItem21.CategoryIndex = 1;
            this.parentBarItem21.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem21.ID = "ForeGroundColor";
            this.parentBarItem21.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem106,
            this.barItem107,
            this.barItem108});
            this.parentBarItem21.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem21.Text = "ForeGroundColor";
            // 
            // barItem106
            // 
            this.barItem106.CategoryIndex = 1;
            this.barItem106.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem106.ID = "Gray";
            this.barItem106.Text = "Gray";
            this.barItem106.Click += new System.EventHandler(this.ForegroundColor_menuItem_Click);
            // 
            // barItem107
            // 
            this.barItem107.CategoryIndex = 1;
            this.barItem107.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem107.ID = "Maroon";
            this.barItem107.Text = "Maroon";
            this.barItem107.Click += new System.EventHandler(this.ForegroundColor_menuItem_Click);
            // 
            // barItem108
            // 
            this.barItem108.CategoryIndex = 1;
            this.barItem108.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem108.ID = "Navy";
            this.barItem108.Text = "Navy";
            this.barItem108.Click += new System.EventHandler(this.ForegroundColor_menuItem_Click);
            // 
            // parentBarItem20
            // 
            this.parentBarItem20.CategoryIndex = 1;
            this.parentBarItem20.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem20.ID = "Width";
            this.parentBarItem20.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem101,
            this.barItem102,
            this.barItem103,
            this.barItem104,
            this.barItem105});
            this.parentBarItem20.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem20.Text = "Width";
            // 
            // barItem101
            // 
            this.barItem101.CategoryIndex = 1;
            this.barItem101.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem101.ID = "25";
            this.barItem101.Text = "25";
            this.barItem101.Click += new System.EventHandler(this.Width_menuItem_Click);
            // 
            // barItem102
            // 
            this.barItem102.CategoryIndex = 1;
            this.barItem102.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem102.ID = "50";
            this.barItem102.Text = "50";
            this.barItem102.Click += new System.EventHandler(this.Width_menuItem_Click);
            // 
            // barItem103
            // 
            this.barItem103.CategoryIndex = 1;
            this.barItem103.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem103.ID = "75";
            this.barItem103.Text = "75";
            this.barItem103.Click += new System.EventHandler(this.Width_menuItem_Click);
            // 
            // barItem104
            // 
            this.barItem104.CategoryIndex = 1;
            this.barItem104.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem104.ID = "100";
            this.barItem104.Text = "100";
            this.barItem104.Click += new System.EventHandler(this.Width_menuItem_Click);
            // 
            // barItem105
            // 
            this.barItem105.CategoryIndex = 1;
            this.barItem105.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem105.ID = "125";
            this.barItem105.Text = "125";
            this.barItem105.Click += new System.EventHandler(this.Width_menuItem_Click);
            // 
            // barItem123
            // 
            this.barItem123.CategoryIndex = 1;
            this.barItem123.Checked = true;
            this.barItem123.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem123.ID = "SelectFullLine On LineNumberClick";
            this.barItem123.Text = "SelectFullLine On LineNumberClick";
            this.barItem123.Click += new System.EventHandler(this.barItem123_Click);
            // 
            // barItem124
            // 
            this.barItem124.CategoryIndex = 1;
            this.barItem124.Checked = true;
            this.barItem124.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem124.ID = "ExtendMultilineSelectionToFarRight";
            this.barItem124.Text = "ExtendMultilineSelectionToFarRight";
            this.barItem124.Click += new System.EventHandler(this.barItem124_Click);
            // 
            // parentBarItem15
            // 
            this.parentBarItem15.CategoryIndex = 1;
            this.parentBarItem15.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem15.ID = "Action Grouping";
            this.parentBarItem15.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem80,
            this.barItem81,
            this.barItem82});
            this.parentBarItem15.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem15.Text = "Action Grouping";
            // 
            // barItem80
            // 
            this.barItem80.CategoryIndex = 1;
            this.barItem80.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem80.ID = "Open Group";
            this.barItem80.Text = "Open Group";
            this.barItem80.Click += new System.EventHandler(this.ActionGroupingClick);
            // 
            // barItem81
            // 
            this.barItem81.CategoryIndex = 1;
            this.barItem81.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem81.ID = "Close Group";
            this.barItem81.Text = "Close Group";
            this.barItem81.Click += new System.EventHandler(this.ActionGroupingClick);
            // 
            // barItem82
            // 
            this.barItem82.CategoryIndex = 1;
            this.barItem82.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem82.ID = "Cancel Group";
            this.barItem82.Text = "Cancel Group";
            this.barItem82.Click += new System.EventHandler(this.ActionGroupingClick);
            // 
            // barItem83
            // 
            this.barItem83.CategoryIndex = 1;
            this.barItem83.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem83.ID = "Reset Undo Info";
            this.barItem83.Text = "Reset Undo Info";
            this.barItem83.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem44
            // 
            this.barItem44.CategoryIndex = 1;
            this.barItem44.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem44.ID = "WordWrap";
            this.barItem44.Text = "WordWrap";
            this.barItem44.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem45
            // 
            this.barItem45.CategoryIndex = 1;
            this.barItem45.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem45.ID = "Show&WhiteSpace";
            this.barItem45.Text = "Show&WhiteSpace";
            this.barItem45.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem46
            // 
            this.barItem46.CategoryIndex = 1;
            this.barItem46.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem46.ID = "Show User &Margin";
            this.barItem46.Text = "Show User &Margin";
            this.barItem46.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem47
            // 
            this.barItem47.CategoryIndex = 1;
            this.barItem47.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem47.ID = "Show Markers Area";
            this.barItem47.Text = "Show Markers Area";
            this.barItem47.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem38
            // 
            this.barItem38.CategoryIndex = 1;
            this.barItem38.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem38.ID = "Outdent Selection";
            this.barItem38.ImageIndex = 41;
            this.barItem38.Text = "Outdent Selection";
            this.barItem38.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem37
            // 
            this.barItem37.CategoryIndex = 1;
            this.barItem37.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem37.ID = "Indent Selection";
            this.barItem37.ImageIndex = 40;
            this.barItem37.Text = "Indent Selection";
            this.barItem37.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.CategoryIndex = 1;
            this.parentBarItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem8.ID = "Indent Menu";
            this.parentBarItem8.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem39,
            this.barItem40,
            this.barItem41});
            this.parentBarItem8.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem8.Text = "Indent Menu";
            // 
            // barItem39
            // 
            this.barItem39.CategoryIndex = 1;
            this.barItem39.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem39.ID = "None";
            this.barItem39.Text = "None";
            this.barItem39.Click += new System.EventHandler(this.IndentMenuClick);
            // 
            // barItem40
            // 
            this.barItem40.CategoryIndex = 1;
            this.barItem40.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem40.ID = "Block";
            this.barItem40.Text = "Block";
            this.barItem40.Click += new System.EventHandler(this.IndentMenuClick);
            // 
            // barItem41
            // 
            this.barItem41.CategoryIndex = 1;
            this.barItem41.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem41.ID = "Smart";
            this.barItem41.Text = "Smart";
            this.barItem41.Click += new System.EventHandler(this.IndentMenuClick);
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.CategoryIndex = 1;
            this.parentBarItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem9.ID = "ReadOnly";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem42,
            this.barItem43});
            this.parentBarItem9.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem9.Text = "ReadOnly";
            // 
            // barItem42
            // 
            this.barItem42.CategoryIndex = 1;
            this.barItem42.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem42.ID = "MarkAsReadOnly";
            this.barItem42.Text = "MarkAsReadOnly";
            this.barItem42.Click += new System.EventHandler(this.ReadOnlyMenuClick);
            // 
            // barItem43
            // 
            this.barItem43.CategoryIndex = 1;
            this.barItem43.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem43.ID = "RemoveReadOnly";
            this.barItem43.Text = "RemoveReadOnly";
            this.barItem43.Click += new System.EventHandler(this.ReadOnlyMenuClick);
            // 
            // barItem118
            // 
            this.barItem118.CategoryIndex = 5;
            this.barItem118.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem118.ID = "Properties ";
            this.barItem118.Text = "Properties ";
            this.barItem118.Click += new System.EventHandler(this.PropertiesMenuClick);
            // 
            // parentBarItem25
            // 
            this.parentBarItem25.CategoryIndex = 4;
            this.parentBarItem25.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem25.ID = "Help_2";
            this.parentBarItem25.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem117,
            this.barItem122});
            this.parentBarItem25.Text = "Help";
            // 
            // barItem117
            // 
            this.barItem117.CategoryIndex = 4;
            this.barItem117.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem117.ID = "Help_1";
            this.barItem117.Text = "Help Edit";
            this.barItem117.Click += new System.EventHandler(this.HelpMenuClick);
            // 
            // barItem122
            // 
            this.barItem122.CategoryIndex = 4;
            this.barItem122.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem122.ID = "About";
            this.barItem122.Text = "About";
            this.barItem122.Click += new System.EventHandler(this.barItem122_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "Standered";
            this.bar2.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar2.Caption = "Standered";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.parentBarItem1,
            this.barItem5,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.barItem10,
            this.barItem11,
            this.barItem22,
            this.barItem31,
            this.barItem26,
            this.barItem25,
            this.barItem75,
            this.barItem86,
            this.barItem84,
            this.parentBarItem17,
            this.parentBarItem14,
            this.barItem112,
            this.barItem37,
            this.barItem38});
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            0,
            3,
            5,
            8,
            10,
            14,
            18});
            // 
            // barItem22
            // 
            this.barItem22.CategoryIndex = 1;
            this.barItem22.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem22.ID = "Toggle BookMark";
            this.barItem22.ImageIndex = 8;
            this.barItem22.Text = "Toggle BookMark";
            this.barItem22.Tooltip = "Toggle BookMark";
            this.barItem22.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // barItem31
            // 
            this.barItem31.CategoryIndex = 1;
            this.barItem31.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem31.ID = "Clear All bookMarks";
            this.barItem31.ImageIndex = 11;
            this.barItem31.Text = "Clear All BookMarks";
            this.barItem31.Tooltip = "Clear BookMarks";
            this.barItem31.Click += new System.EventHandler(this.EditMenuClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "NewDocumentHS.png");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            this.imageList1.Images.SetKeyName(29, "");
            this.imageList1.Images.SetKeyName(30, "");
            this.imageList1.Images.SetKeyName(31, "");
            this.imageList1.Images.SetKeyName(32, "");
            this.imageList1.Images.SetKeyName(33, "");
            this.imageList1.Images.SetKeyName(34, "");
            this.imageList1.Images.SetKeyName(35, "");
            this.imageList1.Images.SetKeyName(36, "");
            this.imageList1.Images.SetKeyName(37, "");
            this.imageList1.Images.SetKeyName(38, "");
            this.imageList1.Images.SetKeyName(39, "");
            this.imageList1.Images.SetKeyName(40, "");
            this.imageList1.Images.SetKeyName(41, "");
            this.imageList1.Images.SetKeyName(42, "");
            this.imageList1.Images.SetKeyName(43, "openfolderHS.png");
            this.imageList1.Images.SetKeyName(44, "saveHS.png");
            this.imageList1.Images.SetKeyName(45, "Edit_UndoHS.png");
            this.imageList1.Images.SetKeyName(46, "Edit_RedoHS.png");
            this.imageList1.Images.SetKeyName(47, "CutHS.png");
            this.imageList1.Images.SetKeyName(48, "CopyHS.png");
            this.imageList1.Images.SetKeyName(49, "PasteHS.png");
            this.imageList1.Images.SetKeyName(50, "PrintHS.png");
            this.imageList1.Images.SetKeyName(51, "DeleteHS.png");
            this.imageList1.Images.SetKeyName(52, "PrintPreviewHS.png");
            this.imageList1.Images.SetKeyName(53, "SaveAllHS.png");
            this.imageList1.Images.SetKeyName(54, "FindHS.png");
            this.imageList1.Images.SetKeyName(55, "border3.gif");
            this.imageList1.Images.SetKeyName(56, "window2.gif");
            this.imageList1.Images.SetKeyName(57, "wib25e1.gif");
            this.imageList1.Images.SetKeyName(58, "key.gif");
            this.imageList1.Images.SetKeyName(59, "LineColorHS.png");
            this.imageList1.Images.SetKeyName(60, "underl1.gif");
            this.imageList1.Images.SetKeyName(61, "backgr1.gif");
            this.imageList1.Images.SetKeyName(62, "DataContainer_MoveNextHS.png");
            this.imageList1.Images.SetKeyName(63, "DataContainer_MovePreviousHS.png");
            this.imageList1.Images.SetKeyName(64, "GoToPreviousMessage.png");
            this.imageList1.Images.SetKeyName(65, "GoToNextMessage.png");
            this.imageList1.Images.SetKeyName(66, "FillUpHS.png");
            this.imageList1.Images.SetKeyName(67, "FillDownHS.png");
            this.imageList1.Images.SetKeyName(68, "EditBrightContrastHS.png");
            this.imageList1.Images.SetKeyName(69, "Color_font.png");
            this.imageList1.Images.SetKeyName(70, "BreakpointHS.png");
            this.imageList1.Images.SetKeyName(71, "Flag_redHS.png");
            this.imageList1.Images.SetKeyName(72, "RadialChartHS.png");
            this.imageList1.Images.SetKeyName(73, "Book_angleHS.png");
            // 
            // barItem76
            // 
            this.barItem76.CategoryIndex = 1;
            this.barItem76.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem76.ID = "Single Line Mode";
            this.barItem76.ImageIndex = 23;
            this.barItem76.Text = "Single Line Mode";
            this.barItem76.Tooltip = "Single Line Mode";
            this.barItem76.Click += new System.EventHandler(this.AdvancedMenuClick);
            // 
            // barItem85
            // 
            this.barItem85.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem85.ID = "_2";
            // 
            // barItem51
            // 
            this.barItem51.CategoryIndex = 0;
            this.barItem51.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem51.ID = "Autoformatting";
            this.barItem51.ImageIndex = 42;
            this.barItem51.Text = "Autoformatting";
            this.barItem51.Click += new System.EventHandler(this.barItem51_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.parentBarItem3;
            // 
            // popupMenusManager1
            // 
            this.popupMenusManager1.ParentForm = this;
            // 
            // editControl1
            // 
            this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.editControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.Configurator = config1;
            this.editControl1.ContextMenuEnabled = false;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(432, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.ScrollPosition = new System.Drawing.Point(155, 0);
            this.editControl1.Size = new System.Drawing.Size(80, 498);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.StatusBarSettings.Visible = true;
            this.editControl1.TabIndex = 4;
            this.editControl1.Text = "editControl1";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 13;
            this.popupMenusManager1.SetXPContextMenu(this.editControl1, this.popupMenu1);
            this.editControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editControl1_MouseMove);
            this.editControl1.TextChanged += new System.EventHandler(this.editControl1_TextChanged);
            this.editControl1.CursorPositionChanged += new System.EventHandler(this.editControl1_CursorPositionChanged);
            this.editControl1.UpdateContextToolTip += new Syncfusion.Windows.Forms.Edit.UpdateTooltipEventHandler(this.editControl1_UpdateContextToolTip);
            // 
            // parentBarItem16
            // 
            this.parentBarItem16.ID = "_1";
            this.parentBarItem16.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem85});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Remove UnderLine";
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 32);
            this.button3.TabIndex = 9;
            this.button3.Text = "UnderLine Selection";
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // radioButton16
            // 
            this.radioButton16.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton16.Location = new System.Drawing.Point(24, 120);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(104, 24);
            this.radioButton16.TabIndex = 4;
            this.radioButton16.Text = "Dash";
            this.radioButton16.UseVisualStyleBackColor = false;
            // 
            // radioButton15
            // 
            this.radioButton15.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton15.Location = new System.Drawing.Point(24, 96);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(104, 24);
            this.radioButton15.TabIndex = 3;
            this.radioButton15.Text = "Dot";
            this.radioButton15.UseVisualStyleBackColor = false;
            // 
            // radioButton14
            // 
            this.radioButton14.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton14.Location = new System.Drawing.Point(24, 72);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(104, 24);
            this.radioButton14.TabIndex = 2;
            this.radioButton14.Text = "Wave";
            this.radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton13
            // 
            this.radioButton13.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton13.Location = new System.Drawing.Point(24, 48);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(104, 24);
            this.radioButton13.TabIndex = 1;
            this.radioButton13.Text = "DashDot";
            this.radioButton13.UseVisualStyleBackColor = false;
            // 
            // radioButton12
            // 
            this.radioButton12.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton12.Location = new System.Drawing.Point(24, 24);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(104, 24);
            this.radioButton12.TabIndex = 0;
            this.radioButton12.Text = "Solid";
            this.radioButton12.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(8, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(192, 176);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // radioButton9
            // 
            this.radioButton9.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(100)))), ((int)(((byte)(19)))));
            this.radioButton9.Location = new System.Drawing.Point(24, 24);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(144, 24);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.Text = "Red";
            this.radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton10
            // 
            this.radioButton10.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton10.ForeColor = System.Drawing.Color.Navy;
            this.radioButton10.Location = new System.Drawing.Point(24, 48);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(144, 24);
            this.radioButton10.TabIndex = 3;
            this.radioButton10.Text = "Blue";
            this.radioButton10.UseVisualStyleBackColor = false;
            // 
            // radioButton11
            // 
            this.radioButton11.BackColor = System.Drawing.SystemColors.Control;
            this.radioButton11.ForeColor = System.Drawing.Color.Green;
            this.radioButton11.Location = new System.Drawing.Point(24, 72);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(144, 24);
            this.radioButton11.TabIndex = 4;
            this.radioButton11.Text = "Green";
            this.radioButton11.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(8, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(192, 112);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.checkBox2.Location = new System.Drawing.Point(8, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Double";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 0;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(25, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Set Selection BackColor";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(25, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Set Line BackColor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 23);
            this.label2.TabIndex = 14;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 11;
            // 
            // radioButton5
            // 
            this.radioButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(111)))));
            this.radioButton5.Location = new System.Drawing.Point(8, 24);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(160, 24);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Orange";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton6
            // 
            this.radioButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.radioButton6.Location = new System.Drawing.Point(8, 48);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(160, 24);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.Text = "LightBlue";
            this.radioButton6.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            this.radioButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(117)))));
            this.radioButton7.Location = new System.Drawing.Point(8, 72);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(160, 24);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.Text = "LightOliveGreen";
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton8.Location = new System.Drawing.Point(8, 96);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(160, 24);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.Text = "none";
            this.radioButton8.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(8, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 136);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton4.Location = new System.Drawing.Point(8, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(160, 24);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "none";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(161)))), ((int)(((byte)(195)))));
            this.radioButton2.Location = new System.Drawing.Point(8, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "SteelBlue";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.radioButton3.Location = new System.Drawing.Point(8, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(160, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "DarkGray";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(8, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(160, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Crimson";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(8, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.gradientPanel2);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.groupBox7);
            this.panel3.Controls.Add(this.groupBox8);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(216, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 498);
            this.panel3.TabIndex = 32;
            this.panel3.Visible = false;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.label6);
            this.gradientPanel2.Location = new System.Drawing.Point(8, 16);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(192, 26);
            this.gradientPanel2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Set Underlines";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button7.Location = new System.Drawing.Point(24, 440);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 27);
            this.button7.TabIndex = 10;
            this.button7.Text = "Remove UnderLine";
            this.button7.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button8.Location = new System.Drawing.Point(24, 392);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(136, 27);
            this.button8.TabIndex = 9;
            this.button8.Text = "UnderLine Selection";
            this.button8.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox7.Controls.Add(this.radioButton25);
            this.groupBox7.Controls.Add(this.radioButton26);
            this.groupBox7.Controls.Add(this.radioButton27);
            this.groupBox7.Controls.Add(this.radioButton28);
            this.groupBox7.Controls.Add(this.radioButton29);
            this.groupBox7.Location = new System.Drawing.Point(8, 200);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(192, 149);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Style";
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton25.Location = new System.Drawing.Point(24, 120);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(50, 17);
            this.radioButton25.TabIndex = 4;
            this.radioButton25.Text = "Dash";
            this.radioButton25.UseVisualStyleBackColor = false;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton26.Location = new System.Drawing.Point(24, 96);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(42, 17);
            this.radioButton26.TabIndex = 3;
            this.radioButton26.Text = "Dot";
            this.radioButton26.UseVisualStyleBackColor = false;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton27.Location = new System.Drawing.Point(24, 72);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(54, 17);
            this.radioButton27.TabIndex = 2;
            this.radioButton27.Text = "Wave";
            this.radioButton27.UseVisualStyleBackColor = false;
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton28.Location = new System.Drawing.Point(24, 48);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(67, 17);
            this.radioButton28.TabIndex = 1;
            this.radioButton28.Text = "DashDot";
            this.radioButton28.UseVisualStyleBackColor = false;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton29.Checked = true;
            this.radioButton29.Location = new System.Drawing.Point(24, 24);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(48, 17);
            this.radioButton29.TabIndex = 0;
            this.radioButton29.TabStop = true;
            this.radioButton29.Text = "Solid";
            this.radioButton29.UseVisualStyleBackColor = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox8.Controls.Add(this.radioButton30);
            this.groupBox8.Controls.Add(this.radioButton31);
            this.groupBox8.Controls.Add(this.radioButton32);
            this.groupBox8.Location = new System.Drawing.Point(8, 80);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(192, 112);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Color";
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton30.Checked = true;
            this.radioButton30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(100)))), ((int)(((byte)(19)))));
            this.radioButton30.Location = new System.Drawing.Point(24, 24);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(45, 17);
            this.radioButton30.TabIndex = 2;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "Red";
            this.radioButton30.UseVisualStyleBackColor = false;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton31.ForeColor = System.Drawing.Color.Navy;
            this.radioButton31.Location = new System.Drawing.Point(24, 48);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(46, 17);
            this.radioButton31.TabIndex = 3;
            this.radioButton31.Text = "Blue";
            this.radioButton31.UseVisualStyleBackColor = false;
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.radioButton32.ForeColor = System.Drawing.Color.Green;
            this.radioButton32.Location = new System.Drawing.Point(24, 72);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(54, 17);
            this.radioButton32.TabIndex = 4;
            this.radioButton32.Text = "Green";
            this.radioButton32.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.gradientPanel1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 498);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Location = new System.Drawing.Point(12, 16);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(188, 22);
            this.gradientPanel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Set Line Colors";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(25, 440);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 27);
            this.button5.TabIndex = 16;
            this.button5.Text = "Set Selection BackColor";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(25, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(136, 27);
            this.button6.TabIndex = 15;
            this.button6.Text = "Set Line BackColor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "HashStyle:";
            // 
            // comboBox2
            // 
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Location = new System.Drawing.Point(8, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox5.Controls.Add(this.radioButton17);
            this.groupBox5.Controls.Add(this.radioButton18);
            this.groupBox5.Controls.Add(this.radioButton19);
            this.groupBox5.Controls.Add(this.radioButton20);
            this.groupBox5.Location = new System.Drawing.Point(8, 240);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(192, 136);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select background";
            // 
            // radioButton17
            // 
            this.radioButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(111)))));
            this.radioButton17.Location = new System.Drawing.Point(8, 24);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(160, 24);
            this.radioButton17.TabIndex = 4;
            this.radioButton17.Text = "Orange";
            this.radioButton17.UseVisualStyleBackColor = false;
            // 
            // radioButton18
            // 
            this.radioButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(231)))), ((int)(((byte)(242)))));
            this.radioButton18.Checked = true;
            this.radioButton18.Location = new System.Drawing.Point(8, 48);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(160, 24);
            this.radioButton18.TabIndex = 5;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "LightBlue";
            this.radioButton18.UseVisualStyleBackColor = false;
            // 
            // radioButton19
            // 
            this.radioButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(191)))), ((int)(((byte)(117)))));
            this.radioButton19.Location = new System.Drawing.Point(8, 72);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(160, 24);
            this.radioButton19.TabIndex = 6;
            this.radioButton19.Text = "LightOliveGreen";
            this.radioButton19.UseVisualStyleBackColor = false;
            // 
            // radioButton20
            // 
            this.radioButton20.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton20.Location = new System.Drawing.Point(8, 96);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(160, 24);
            this.radioButton20.TabIndex = 7;
            this.radioButton20.Text = "none";
            this.radioButton20.UseVisualStyleBackColor = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.groupBox6.Controls.Add(this.radioButton21);
            this.groupBox6.Controls.Add(this.radioButton22);
            this.groupBox6.Controls.Add(this.radioButton23);
            this.groupBox6.Controls.Add(this.radioButton24);
            this.groupBox6.Location = new System.Drawing.Point(8, 96);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(192, 144);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Select Color";
            // 
            // radioButton21
            // 
            this.radioButton21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton21.Location = new System.Drawing.Point(8, 96);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(160, 24);
            this.radioButton21.TabIndex = 3;
            this.radioButton21.Text = "none";
            this.radioButton21.UseVisualStyleBackColor = false;
            // 
            // radioButton22
            // 
            this.radioButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(161)))), ((int)(((byte)(195)))));
            this.radioButton22.Location = new System.Drawing.Point(8, 48);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(160, 24);
            this.radioButton22.TabIndex = 1;
            this.radioButton22.Text = "SteelBlue";
            this.radioButton22.UseVisualStyleBackColor = false;
            // 
            // radioButton23
            // 
            this.radioButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(110)))), ((int)(((byte)(120)))));
            this.radioButton23.ForeColor = System.Drawing.Color.White;
            this.radioButton23.Location = new System.Drawing.Point(8, 72);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(160, 24);
            this.radioButton23.TabIndex = 2;
            this.radioButton23.Text = "DarkGray";
            this.radioButton23.UseVisualStyleBackColor = false;
            // 
            // radioButton24
            // 
            this.radioButton24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.radioButton24.Checked = true;
            this.radioButton24.ForeColor = System.Drawing.Color.White;
            this.radioButton24.Location = new System.Drawing.Point(8, 24);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(160, 24);
            this.radioButton24.TabIndex = 0;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "Crimson";
            this.radioButton24.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editControl1);
            this.panel1.Controls.Add(this.propertyEditor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 498);
            this.panel1.TabIndex = 6;
            // 
            // propertyEditor
            // 
            this.propertyEditor.BackColor = System.Drawing.SystemColors.Control;
            this.propertyEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyEditor.LineColor = System.Drawing.SystemColors.Control;
            this.propertyEditor.Location = new System.Drawing.Point(512, 0);
            this.propertyEditor.Name = "propertyEditor";
            this.propertyEditor.SelectedObject = this.editControl1;
            this.propertyEditor.Size = new System.Drawing.Size(232, 498);
            this.propertyEditor.TabIndex = 35;
            this.propertyEditor.Visible = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "function_locked.png");
            this.imageList2.Images.SetKeyName(1, "function_unlocked.png");
            this.imageList2.Images.SetKeyName(2, "property_protected.png");
            this.imageList2.Images.SetKeyName(3, "property_public.png");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(744, 550);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Code Editor ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			form1 = new Form1();
            Application.EnableVisualStyles();
			Application.Run(form1);
		}

        #region MenuClicks

        private void FileMenuClick( object sender, System.EventArgs e ) {
            BarItem bi = sender as BarItem;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            switch ( bi.Text )
            {
                case "&New":
                    this.editControl1.NewFile();
                    break;
                case "&Open":
                    this.editControl1.LoadFile();
                    this.editControl1.StatusBarSettings.TextPanel.Panel.Text = this.editControl1.FileName;
                    break;
                case "&Save":
                    this.editControl1.Save();
                    break;
                case "Save &As":
                    this.editControl1.SaveAs();
                    break;
                case "Save As &RTF":

                    saveFileDialog.Filter = "RitchTextDocuments (*.rtf)|*.rtf";
                    if ( saveFileDialog.ShowDialog() == DialogResult.OK )
                    {
                        this.editControl1.SaveAsRTF( saveFileDialog.FileName );
                    }
                    break;
                case "Save As &XML":
                    saveFileDialog.Filter = "XML Documents (*.xml)|*.xml";
                    if ( saveFileDialog.ShowDialog() == DialogResult.OK )
                    {
                        this.editControl1.SaveAsXML( saveFileDialog.FileName );
                    }
                    break;
                case "Save As &HTML":
                    saveFileDialog.Filter = "HTML Documents (*.html)|*.html";
                    if ( saveFileDialog.ShowDialog() == DialogResult.OK )
                    {
                        this.editControl1.SaveAsHTML( saveFileDialog.FileName );
                    }
                    break;
                case "C&lose":
                    this.editControl1.Close();
                    break;
                case "E&xit":
                    this.Close();
                    break;
            }
        }


        private void WindowMenuClick( object sender, System.EventArgs e ) {
            BarItem bi = sender as BarItem;

            switch ( bi.Text )
            {
                case "Split Horizontally":
                    this.editControl1.SplitHorizontally();
                    break;
                case "Split Vertically":
                    this.editControl1.SplitVertically();
                    break;
                case "Split Into Quadrants":
                    this.editControl1.SplitFourQuadrants();
                    break;
            }
        }


        private void PrintingMenuClick( object sender, System.EventArgs e ) {
            BarItem bi = sender as BarItem;

            switch ( bi.Text )
            {
                case "&Print":
                    this.editControl1.PrintNoDialog();
                    break;
                case "Print Preview":
                    this.editControl1.PrintPreview();
                    break;
                case "Print Dialog":
                    this.editControl1.Print();
                    break;
                case "Print To File":
                    PrintDocument printdoc = this.editControl1.PrintDocument;
                    printdoc.Print();
                    break;
                case "Print Current Page":
                    this.editControl1.PrintCurrentPage();
                    break;
                case "Print Selected Text":
                    this.editControl1.PrintSelection();
                    break;
            }
        }


        private void LanguageMenuClick( object sender, System.EventArgs e ) {
            BarItem bi = sender as BarItem;

            switch ( bi.Text )
            {
                case "CSharp":
                    this.editControl1.LoadFile( BasePath + "\\CSharpSource.cs" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.CSharp );
                    break;
                case "XML":
                    this.editControl1.LoadFile( BasePath + "\\XMLSource.xml" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.XML );
                    break;
                case "VB.NET":
                    this.editControl1.LoadFile( BasePath + "\\VBSource.vb" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.VBNET );
                    break;
                case "SQL":
                    this.editControl1.LoadFile( BasePath + "\\SQLSource.sql" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.SQL );
                    break;
                case "Pascal":
                    this.editControl1.LoadFile( BasePath + @"..\..\..\..\..\..\..\..\Common\Data\DelphiSource.pas" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.Delphi );
                    break;
                case "HTML":
                    this.editControl1.LoadFile( BasePath + "\\HTMLSource.html" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.HTML );
                    break;
                case "Java":
                    this.editControl1.LoadFile( BasePath + "\\JavaSource.Java" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.Java );
                    break;
                case "JScript":
                    this.editControl1.LoadFile( BasePath + "\\JScriptSource.js" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.JScript );
                    break;
                case "VBScript":
                    this.editControl1.LoadFile( BasePath + "\\VBScriptSource.vbs" );
                    this.editControl1.ApplyConfiguration( KnownLanguages.VBScript );
                    break;
                case "Configuration Editor":
                    try
                    {
                        IConfigLanguage activeLang = this.editControl1.Parser.Formats as IConfigLanguage;

                        ConfigurationDialog editConfig = new ConfigurationDialog( this.editControl1.Configurator,
                            activeLang );

                        if ( editConfig.ShowDialog( this ) == DialogResult.OK && activeLang != null )
                        {
                            IConfigLanguage newLang = editConfig.Configurator.KnownLanguageNames.Contains( activeLang.Language ) ?
                                editConfig.Configurator[activeLang.Language] : editConfig.Configurator.DefaultLanguage;

                            if ( newLang != null )
                            {
                                this.editControl1.Configurator = editConfig.Configurator;
                                //this.editControl1.ResetColoring( newLang );
                                this.editControl1.ApplyConfiguration( newLang );
                            }
                        }
                    }
                    catch ( ArgumentException )
                    {
                    }
                    break;
                case "Default Language":
                    this.editControl1.ApplyConfiguration( KnownLanguages.Text );
                    break;
            }
        }


        private void EditMenuClick( object sender, System.EventArgs e ) {
            BarItem bi = sender as BarItem;

            switch ( bi.Text )
            {
                case "&Undo":
                    this.editControl1.Undo();
                    break;
                case "&Redo":
                    this.editControl1.Redo();
                    break;
                case "Cu&t":
                    this.editControl1.Cut();
                    break;
                case "&Copy":
                    this.editControl1.Copy();
                    break;
                case "&Paste":
                    this.editControl1.Paste();
                    break;
                case "Select &All":
                    this.editControl1.SelectAll();
                    break;
                case "Delete":
                    if ( editControl1.Selection != null )
                        this.editControl1.DeleteText( this.editControl1.Selection.Top, this.editControl1.Selection.Bottom );
                    else
                        MessageBox.Show( "Please select the text to be deleted" );
                    break;
                case "Delete All":
                    this.editControl1.DeleteAll();
                    break;
                case "CollapseAll":
                    this.editControl1.CollapseAll();
                    break;
                case "ExpandAll":
                    this.editControl1.ExpandAll();
                    break;
                case "Show Collapsers":
                    barItem50.Checked = !barItem50.Checked;
                    this.editControl1.ShowOutliningCollapsers = barItem50.Checked;
                    break;
                case "Find":
                    this.editControl1.ShowFindDialog();
                    break;
                case "Replace":
                    this.editControl1.ShowReplaceDialog();
                    break;
                case "GoTo":
                    this.editControl1.ShowGoToDialog();
                    break;
                case "Insert CustomBookMark":
                    this.InsertCustomBookMark();
                    break;
                case "&Next BookMark":
                    this.editControl1.BookmarkNext();
                    break;
                case "&Previous BookMark":
                    this.editControl1.BookmarkPrevious();
                    break;
                case "Toggle BookMark":
                    this.editControl1.BookmarkToggle();
                    break;
                case "Clear All BookMarks":
                    this.editControl1.BookmarkClear();
                    for ( int i = 0 ; i < arr.Count ; i++ )
                    {
                        int line = ( int )arr[i];
                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter1 ) );
                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter2 ) );
                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter3 ) );
                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter4 ) );

                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter1 ) );
                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter2 ) );
                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter3 ) );
                        this.editControl1.RemoveCustomBookmark( line, new BookmarkPaintEventHandler( CustomBookmarkPainter4 ) );
                    }
                    break;
                case "Add BookMark":
                    this.editControl1.BookmarkAdd( this.editControl1.CurrentLine );
                    break;
                case "Remove BookMark":
                    this.editControl1.BookmarkToggle();
                    break;
                case "Image1":
                    this.selectedImage = image1;
                    break;
                case "Image2":
                    this.selectedImage = image2;
                    break;
                case "Image3":
                    this.selectedImage = image3;
                    break;
                case "Image4":
                    this.selectedImage = image4;
                    break;
                default:
                    MessageBox.Show( "Handler does not exist" );
                    break;
            }
        }

        #region BookMarks Helper Methods
        private void InsertCustomBookMark() {
            if ( this.selectedImage == image1 )
            {
                this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter1 ) );
                ICustomBookmark customBookmark1 = this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter1 ) );
                customBookmark1.UseInBookmarkSearch = true;
                arr.Add( this.editControl1.CurrentLine );
            }
            else if ( this.selectedImage == image2 )
            {

                this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter2 ) );
                ICustomBookmark customBookmark2 = this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter2 ) );
                customBookmark2.UseInBookmarkSearch = true;
                arr.Add( this.editControl1.CurrentLine );
            }
            else if ( this.selectedImage == image3 )
            {
                this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter3 ) );
                ICustomBookmark customBookmark3 = this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter3 ) );
                customBookmark3.UseInBookmarkSearch = true;
                arr.Add( this.editControl1.CurrentLine );
            }
            else if ( this.selectedImage == image4 )
            {
                this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter4 ) );
                ICustomBookmark customBookmark4 = this.editControl1.SetCustomBookmark( this.editControl1.CurrentLine, new BookmarkPaintEventHandler( CustomBookmarkPainter4 ) );
                customBookmark4.UseInBookmarkSearch = true;
                arr.Add( this.editControl1.CurrentLine );
            }
        }

        private void CustomBookmarkPainter1( object sender, BookmarkPaintEventArgs args ) {
            args.Graphics.DrawImage( image1, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16 );
        }

        private void CustomBookmarkPainter2( object sender, BookmarkPaintEventArgs args ) {
            args.Graphics.DrawImage( image2, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16 );
        }

        private void CustomBookmarkPainter3( object sender, BookmarkPaintEventArgs args ) {
            args.Graphics.DrawImage( image3, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16 );
        }

        private void CustomBookmarkPainter4( object sender, BookmarkPaintEventArgs args ) {
            args.Graphics.DrawImage( image4, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16 );
        }
        #endregion

        private void PropertiesMenuClick( object sender, System.EventArgs e ) {
            this.propertyEditor.Visible = !this.propertyEditor.Visible;
        }


        private void HelpMenuClick( object sender, System.EventArgs e ) {
            Process.Start( "http://www.syncfusion.com/products/edit/windows/default.aspx" );
        }
        
        #endregion		

        #region EditControl Events

        private void editControl1_CursorPositionChanged( object sender, System.EventArgs e ) {
            //this.PositionPanel.Text = "Ln  " + this.editControl1.CurrentLine + "  Col "+this.editControl1.CurrentColumn +"  Pos  "+this.editControl1.CurrentPosition;
        }


        private void editControl1_MouseMove( object sender, System.Windows.Forms.MouseEventArgs e ) {
            this.editControl1.Cursor = this.currentCursor;
        }

        private void LineColor( object sender, System.EventArgs e ) {
            this.panel3.Visible = false;

            if ( !this.panel1.Visible )
            {
                this.panel1.Visible = true;
                //	this.editControl1.Width = 710;
            }
            else
            {
                this.panel1.Visible = false;
                //	this.editControl1.Width = 912;
            }

        }
        
        #endregion
		
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.editControl1.Text = "panel active";
		}

		private IBackgroundFormat RegisterFormat()
		{
			Color background = Color.Empty, foreground = Color.Empty;

			if( radioButton22.Checked )
				foreground = radioButton22.BackColor;
			else if( radioButton23.Checked )
				foreground = radioButton23.BackColor;
			else if( radioButton24.Checked )
				foreground = radioButton24.BackColor;
			else if( radioButton21.Checked )
				foreground = Color.Empty;

			if( radioButton17.Checked )
				background = radioButton17.BackColor;
			else if( radioButton18.Checked )
				background = radioButton18.BackColor;
			else if( radioButton19.Checked )
				background = radioButton19.BackColor;
			else if( radioButton20.Checked )
				background = Color.White;

			bool bUseHatchFille = comboBox2.SelectedIndex > 0;
			HatchStyle style = ( bUseHatchFille ) 
				? ( HatchStyle )Enum.Parse( typeof( HatchStyle ), 
				comboBox2.SelectedItem.ToString() )
				: HatchStyle.Min;

			IBackgroundFormat format = 
				editControl1.RegisterBackColorFormat( background, foreground, 
				style, bUseHatchFille );
			return format;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			comboBox2.Items.Clear();
        
			comboBox2.Items.Add( "Solid" );
                       
			foreach( string name in Enum.GetNames( typeof( HatchStyle) ) )
				comboBox2.Items.Add( name );
      
			comboBox2.SelectedText = "Percent05";
			comboBox2.SelectedIndex = 0;
		}

		

		private void button2_Click(object sender, System.EventArgs e)
		{
				
			IBackgroundFormat format = RegisterFormat();
			editControl1.SetSelectionBackColor( format );
		}

	
		
		
		private void editControl1_TextChanged(object sender, System.EventArgs e)
		{
			this.barItem10.Enabled = true;
			this.barItem11.Enabled = true;
		}

		

		
		private Color SelectedColor
		{
			get
			{
				if( radioButton30.Checked )
					return radioButton9.ForeColor;
        
				if( radioButton31.Checked )
					return radioButton10.ForeColor;

				if( radioButton32.Checked )
					return radioButton11.ForeColor;

				return Color.Black;
			}
		}

		private UnderlineStyle SelectedStyle
		{
			get
			{
				if( radioButton29.Checked )
					return UnderlineStyle.Solid;
        
				if( radioButton28.Checked )
					return UnderlineStyle.DashDot;

				if( radioButton27.Checked )
					return UnderlineStyle.Wave;

				if( radioButton26.Checked )
					return UnderlineStyle.Dot;
				
				if( radioButton25.Checked )
					return UnderlineStyle.Dash;

				return UnderlineStyle.Solid;
			}
		}

		private UnderlineWeight SelectedWeight
		{
			get
			{
				if( checkBox2.Checked )
					return UnderlineWeight.Double;

				return UnderlineWeight.Bold;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			
		
		}

		private void editControl1_UpdateContextToolTip(object sender, Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs e)
		{
			if( e.Text == string.Empty )
			{
				Point pointVirtual = editControl1.PointToVirtualPosition( new Point( e.X, e.Y ) );

				if( pointVirtual.Y > 0 )
				{
					// Get the current line
					ILexemLine line = editControl1.GetLine( pointVirtual.Y );

					if( line != null )
					{
						// Get tokens from the current line
						ILexem lexem = line.FindLexemByColumn( pointVirtual.X );

						if( lexem != null )
						{
							e.Text = lexem.Text;
						}
					}
				}
			}
		
		}

	private void moveMenuItem_Click(object sender, System.EventArgs e)
		{
			//MenuItem item = sender as MenuItem;
			BarItem item = sender as BarItem;
			switch (item.Text)
			{
				case "Move Up" :
					this.editControl1.MoveUp();
					break;
				case "Move Down" :
					this.editControl1.MoveDown();
					break;
				case "Move Left" :
					this.editControl1.MoveLeft();
					break;
				case "Move Right" :
					this.editControl1.MoveRight();
					break;
				case "Move to Start" :
					this.editControl1.MoveToBeginning();
					break;
				case "Move to End" :
					this.editControl1.MoveToEnd();
					break;
				case "Page Up" :
					this.editControl1.MovePageUp();
					break;
				case "Page Down" :
					this.editControl1.MovePageDown();
					break;
				case "Move Left One Word" :
					this.editControl1.MoveLeftWord();
					break;
				case "Move Right One Word" :
					this.editControl1.MoveRightWord();
					break;
				case "Move to Line Start" :
					this.editControl1.MoveToLineStart();
					break;
				case "Move to Line End" :
					this.editControl1.MoveToLineEnd();
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
			}
		}

		private void Width_menuItem_Click(object sender, System.EventArgs e)
		{
			BarItem item = sender as BarItem;
			switch(item.Text)
			{
				case"25": 
					this.editControl1.SelectionMarginWidth = 25;
					break;
				case"50":
					this.editControl1.SelectionMarginWidth = 50;
					break;
				case"75":
					this.editControl1.SelectionMarginWidth = 75;
					break;
				case"100":
					this.editControl1.SelectionMarginWidth = 100;
					break;
				case"125":
					this.editControl1.SelectionMarginWidth = 125;
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
			}
		}

		private void BackgroundColor_menuItem_Click(object sender, System.EventArgs e)
		{
			BarItem item = sender as BarItem;
			switch(item.Text)
			{
				case "LightBlue":
					this.editControl1.SelectionMarginBackgroundColor = Color.LightBlue;
					break;

				case "IndianRed":
					this.editControl1.SelectionMarginBackgroundColor = Color.IndianRed;
					break;
				case "Beige":
					this.editControl1.SelectionMarginBackgroundColor = Color.Beige;
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;

			}
		}

		private void ForegroundColor_menuItem_Click(object sender, System.EventArgs e)
		{
			BarItem item = sender as BarItem;
			switch(item.Text)
			{
				case"Gray":
					this.editControl1.SelectionMarginForegroundColor = Color.Gray;
					break; 
				case"Maroon":
					this.editControl1.SelectionMarginForegroundColor = Color.Maroon;
					break;
				case "Navy":
					this.editControl1.SelectionMarginForegroundColor = Color.Navy;			
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
			}
		}

		
		private void CustomCursorMenuClick(object sender, System.EventArgs e)
		{	
			BarItem bi = sender as BarItem;

			switch (bi.Text)
			{
				case "AppStarting" :
					this.currentCursor=Cursors.AppStarting;
					break;
				case "Arrow" :
					this.currentCursor =Cursors.Arrow;
					break;
				case "Cross" :
					this.currentCursor=Cursors.Cross;
					break;
				case "Default" :
					this.currentCursor=Cursors.Default;
					break;
				case "Hand" :
					this.currentCursor=Cursors.Hand;
					break;
				case "Help" :
					this.currentCursor=Cursors.Help;
					break;
				case "HSplit" :
					this.currentCursor=Cursors.HSplit;
					break;
				case "IBeam" :
					this.currentCursor=Cursors.IBeam;
					break;
				case "No" :
					this.currentCursor=Cursors.No;
					break;
				case "SizeAll" :
					this.currentCursor=Cursors.SizeAll;
					break;
				case "UpArrow" :
					this.currentCursor=Cursors.UpArrow;
					break;
				case "VSplit" :
					this.currentCursor=Cursors.VSplit;
					break;
				case "WaitCursor" :
					this.currentCursor=Cursors.WaitCursor;
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
			}
		}

		private void NavigationMenu_Click(object sender, System.EventArgs e)
		{
			BarItem item = sender as BarItem;

				switch (item.Text)
				{
					case "Move Up" :
						this.editControl1.MoveUp();
						break;
					case "Move Down" :
						this.editControl1.MoveDown();
						break;
					case "Move Left" :
						this.editControl1.MoveLeft();
						break;
					case "Move Right" :
						this.editControl1.MoveRight();
						break;
					case "Move to Start" :
						this.editControl1.MoveToBeginning();
						break;
					case "Move to End" :
						this.editControl1.MoveToEnd();
						break;
					case "Page Up" :
						this.editControl1.MovePageUp();
						break;
					case "Page Down" :
						this.editControl1.MovePageDown();
						break;
					case "Move Left One Word" :
						this.editControl1.MoveLeftWord();
						break;
					case "Move Right One Word" :
						this.editControl1.MoveRightWord();
						break;
					case "Move to Line Start" :
						this.editControl1.MoveToLineStart();
						break;
					case "Move to Line End" :
						this.editControl1.MoveToLineEnd();
						break;
					default :
						MessageBox.Show("Handler does not exist");
						break;
				}
			}

		private void AdvancedMenuClick(object sender, System.EventArgs e)
		{
			BarItem item = sender as BarItem;
			switch (item.Text)
			{
				case "Bind Keys":
					this.editControl1.ShowKeysBindingEditor();
					break;
				case "LineBackColor":
                    barItem75.Checked = !barItem75.Checked;
                    this.panel2.Visible = barItem75.Checked;
					this.panel3.Visible = false;
                    barItem86.Checked = false;
					break;
				case "Underlines":
                    barItem86.Checked = !barItem86.Checked;
                    this.panel3.Visible = barItem86.Checked;
                    this.panel2.Visible = false;
                    barItem75.Checked = false;
                    break;
				case "GradientBackGround":
					this.editControl1.BackgroundColor =  new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Beige, System.Drawing.Color.LightBlue);
					break;
				case "Regular":
					this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
					break;
				case "SetText":
					this.inputdialog.ShowDialog();

					if (this.accepted == true)
					{
						this.editControl1.Text = this.inputString;
					}
					break;
				case "AppendText":
					this.inputdialog.ShowDialog();		

					if (this.accepted == true)
					{
						this.editControl1.AppendText(this.inputString);
					}
					break;
				case "InsertText":
					this.inputdialog.ShowDialog();	
	
					if (this.accepted == true)
					{
						this.editControl1.InsertText(this.editControl1.CurrentLine, this.editControl1.CurrentColumn, this.inputString);
					}
					break;
				case "Insert XML Tag":
					this.inputdialog.ShowDialog();

					if (this.accepted == true)
					{
						if(this.inputString.Equals(""))
						{
							MessageBox.Show("The node name cannot be empty");
						}
						else
						{
							this.editControl1.InsertText(this.editControl1.CurrentLine,this.editControl1.CurrentColumn ,"<"+this.inputString+">");
							this.editControl1.InsertText(this.editControl1.CurrentLine,(this.editControl1.CurrentColumn)," ");
							this.editControl1.InsertText(this.editControl1.CurrentLine,this.editControl1.CurrentColumn ,"</"+this.inputString+">");
						}
					}
					break;
				case "MoveToBeginingOfBlock":
					this.editControl1.JumpToIndentBlockStart();
					break;
				case "MoveToEndOfBlock":
					this.editControl1.JumpToIndentBlockEnd();
					break;
				case "Reset Undo Info":
					this.editControl1.ResetUndoInfo();
					break;
				case "WordWrap":
					this.editControl1.WordWrap = ! this.editControl1.WordWrap;
					break;
				case "Show&WhiteSpace":
					this.editControl1.ShowWhitespaces = ! this.editControl1.ShowWhitespaces;
					break;
				case "Show User &Margin":
					this.editControl1.ShowUserMargin = ! this.editControl1.ShowUserMargin;
					break;
				case "Show Markers Area":
					this.editControl1.ShowMarkers = ! this.editControl1.ShowMarkers;
					break;
				case "Single Line Mode":
					int h = this.editControl1.Height;
					if(this.editControl1.Dock!=DockStyle.Fill)
					{
						this.editControl1.SingleLineMode = ! this.editControl1.SingleLineMode;
					}
					this.editControl1.Height = h;
					break;
				case "Indent Selection":
					this.editControl1.IndentSelection();
					break;
				case "Outdent Selection":
					this.editControl1.OutdentSelection();
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
			}

		}

		private void ActionGroupingClick(object sender, System.EventArgs e)
		{
		   BarItem item=sender as BarItem;
			switch(item.Text)
			{
				case "Open Group":
					this.editControl1.UndoGroupOpen();
					break;
				case "Close Group":
					this.editControl1.UndoGroupClose();
					break;
				case "Cancel Group":
					this.editControl1.UndoGroupCancel();
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
					
		
			}
		}
		private void IndentMenuClick(object sender, System.EventArgs e)
		{
			BarItem mi = sender as BarItem;
			switch (mi.Text)
			{
				case "None" :
					this.editControl1.AutoIndentMode = AutoIndentMode.None;					
					break;
				case "Block" :
					this.editControl1.AutoIndentMode = AutoIndentMode.Block;					
					break;
				case "Smart" :
					this.editControl1.AutoIndentMode = AutoIndentMode.Smart;					
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
					
			}
		}

		private void ReadOnlyMenuClick(object sender, System.EventArgs e)
		{
			BarItem item = sender as BarItem;
			switch(item.Text)
			{
				case "MarkAsReadOnly":
                    if (editControl1.Selection != null)
                        this.editControl1.MarkAsReadOnly(this.editControl1.Selection.Start, this.editControl1.Selection.End, Color.Orange, Color.Crimson);
                    else
                        MessageBox.Show("Please select the text to be made read-only");
					break;
				case "RemoveReadOnly":
                    if (editControl1.Selection != null)
					    this.editControl1.RemoveReadOnly(this.editControl1.Selection.Start, this.editControl1.Selection.End);
                    else
                    MessageBox.Show("Please select the text for which read-only has to be removed");
					break;
				default :
					MessageBox.Show("Handler does not exist");
					break;
			}
		}

		private void barItem51_Click(object sender, System.EventArgs e)
		{
			
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			IDynamicFormat[] temp = editControl1.GetLineBackColorFormats( editControl1.CurrentLine );
     
			IBackgroundFormat format = RegisterFormat();
			editControl1.SetLineBackColor( editControl1.CurrentLine, true, format );  
		}

		private void button2_Click_1(object sender, System.EventArgs e)
		{
			IBackgroundFormat format = RegisterFormat();
			editControl1.SetSelectionBackColor( format );
		
		}

		private void button3_Click_1(object sender, System.EventArgs e)
		{
			if( editControl1.Selection != null )
			{
				ISnippetFormat format = editControl1.RegisterUnderlineFormat( SelectedColor, SelectedStyle, SelectedWeight );
				this.editControl1.SetUnderline( editControl1.Selection.Top, editControl1.Selection.Bottom, format );
			}
		}

		private void button4_Click_1(object sender, System.EventArgs e)
		{
			if( editControl1.Selection != null )
			{
				this.editControl1.RemoveUnderline(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom );
			}
        }

        private void barItem122_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm form = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            form.ShowDialog();
        }

        private void barItem123_Click(object sender, EventArgs e)
        {

            this.barItem123.Checked = !this.barItem123.Checked;
            if (this.barItem123.Checked)
            {
                //Selects the whole line when clicked on line number
                this.editControl1.SelectOnLineNumberClick = true;
            }
            else
            {
                this.editControl1.SelectOnLineNumberClick = false;
            }

        }

        private void barItem124_Click(object sender, EventArgs e)
        {
            this.barItem124.Checked = !this.barItem124.Checked;
            if (this.barItem124.Checked)
            {
               this.editControl1.ExtendSelectionToFarRight = true;
            }
            else
            {
                //Selects the text upto the end of the line alone similar to VS IDE.
               this.editControl1.ExtendSelectionToFarRight = false;
            }  
        }


        #region Context Choice Implementation
        private void editControl1_ContextChoiceBeforeOpen( object sender, System.ComponentModel.CancelEventArgs e ) {
            ILexemLine lexemLine = this.editControl1.GetLine( this.editControl1.CurrentLine );

            //Gets the index of the current word in that line
            int ind = GetContextChoiceCharIndex( lexemLine );
            if ( ind <= 0 )
            {
                e.Cancel = true;
                return;
            }
            ILexem lex = lexemLine.LineLexems[ind - 1] as ILexem;

            // If the count is less than '2', do not show the ContextChoice popup
            if ( lexemLine.LineLexems.Count < 2 )
                e.Cancel = true;
            else
            {
                // Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
                if ( ( lex.Text == "this" ) || ( lex.Text == "me" ) )
                    e.Cancel = false;
                else
                    e.Cancel = true;
            }

        }


        private int GetContextChoiceCharIndex( ILexemLine line ) {
            int lastPos = -1;

            for ( int i = 0 ; i < line.LineLexems.Count ; i++ )
            {
                ILexem lex = line.LineLexems[i] as ILexem;

                if ( lex.Text == "." )
                    lastPos = i;
            }

            return lastPos;
        }

        private void editControl1_ContextChoiceOpen( Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller ) {
            reader = new XmlTextReader( intellisensePath );
            while ( reader.Read() )
            {
                string itemname = "", tooltip = "";
                switch ( reader.NodeType )
                {
                    case ( XmlNodeType.Element ):

                        if ( reader.Name == "Items" )
                        {
                            if ( reader.AttributeCount > 0 )
                            {
                                while ( reader.MoveToNextAttribute() )
                                {
                                    if ( reader.Name == "Name" )
                                    {
                                        itemname = reader.Value;
                                    }
                                    if ( reader.Name == "Tooltip" )
                                    {
                                        tooltip = reader.Value;
                                    }
                                    if ( reader.Name == "Image" )
                                    {
                                        controller.Items.Add( itemname, tooltip, this.editControl1.ContextChoiceController.Images[reader.Value] );
                                    }
                                }
                            }
                        }

                        break;

                }
            }

        }

        private void editControl1_ContextChoiceItemSelected( Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController sender, Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs e ) {
            Console.WriteLine( "SelectedItem : " + e.SelectedItem.Text );
        }

        private void editControl1_ContextChoiceClose( Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult ) {
            controller.Items.Clear();
            reader.Close();
        }
        #endregion

        #region Context Prompt Implementation
        private int GetContextPromptCharIndex( ILexemLine line ) {
            int lastPos = -1;
            for ( int i = 0 ; i < line.LineLexems.Count ; i++ )
            {
                ILexem lex = line.LineLexems[i] as ILexem;

                if ( lex.Text == "(" )
                    lastPos = i;
            }

            return lastPos;
        }

        string contextPromptLexem = "";
        // Method that populates the context prompt list based on the lexem invoking it
        private void PopulateContextPromptItems( ContextPromptUpdateEventArgs e ) {
            e.List.Clear();
            GetFunctionNames( e );

            //switch (this.contextPromptLexem)
            //{
            //    case "Chat" :
            //        e.List.Clear();
            //        GetFunctionNames(e);
            //        break;

            //    case "Database" :
            //        e.List.Clear();
            //        GetFunctionNames(e);
            //        break;
            //    case "NewFile" :
            //        e.List.Clear();
            //        GetFunctionNames(e);
            //        break;
            //    case "Find" :
            //        e.List.Clear();
            //        GetFunctionNames(e);
            //        break;
            //    case "Home" :
            //        e.List.Clear();
            //        GetFunctionNames(e);
            //        break;
            //    case "PieChart" :
            //        e.List.Clear();
            //        GetFunctionNames(e);
            //        break;
            //    case "Tools" :
            //        e.List.Clear();
            //        GetFunctionNames(e);
            //        break;
            //}
        }

        string function = "";
        private void GetFunctionNames( ContextPromptUpdateEventArgs e ) {
            reader = new XmlTextReader( intellisensePath );
            function = "";
            int i = 1;
            while ( reader.Read() )
            {
                function = "";
                switch ( reader.NodeType )
                {
                    case ( XmlNodeType.Element ):

                        if ( reader.Name == "Function" )
                        {
                            reader.MoveToFirstAttribute();
                            if ( reader.Value == this.contextPromptLexem )
                            {
                                while ( reader.MoveToNextAttribute() )
                                {
                                    if ( reader.Name == "overloads" + i )
                                    {
                                        function = reader.Value;

                                    }
                                    else
                                    {
                                        if ( reader.Name == "Description" + i )
                                        {

                                            e.AddPrompt( function, reader.Value );
                                            i++;
                                        }
                                    }

                                }
                            }
                        }

                        break;

                }
            }

        }

        private void editControl1_ContextPromptBeforeOpen( object sender, System.ComponentModel.CancelEventArgs e ) {
            ILexemLine lexemLine = this.editControl1.GetLine( this.editControl1.CurrentLine );

            //Gets the index of the current word in that line
            int ind = GetContextPromptCharIndex( lexemLine );
            if ( ind <= 0 )
            {
                e.Cancel = true;
                return;
            }
            ILexem lex = lexemLine.LineLexems[ind - 1] as ILexem;

            // If the count is less than '2', do not show the ContextPrompt popup
            if ( lexemLine.LineLexems.Count < 2 )
                e.Cancel = true;
            else
            {
                // Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
                //if ( ( lex.Text == "Chat" ) || ( lex.Text == "Database" ) || ( lex.Text == "NewFile" ) || ( lex.Text == "Find" ) || ( lex.Text == "Home" ) || ( lex.Text == "PieChart" ) || ( lex.Text == "Tools" ) )
                if ( lex.Text != "" )
                {
                    this.contextPromptLexem = lex.Text;
                    e.Cancel = false;
                }
                else
                    e.Cancel = true;

            }
        }

        private void editControl1_ContextPromptOpen( object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e ) {
            if ( this.contextPromptLexem != "" )
            {
                PopulateContextPromptItems( e );
            }
        }
        #endregion

	
	}
}
