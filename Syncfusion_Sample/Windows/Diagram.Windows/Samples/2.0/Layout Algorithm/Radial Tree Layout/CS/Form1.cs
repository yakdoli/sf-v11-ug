using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using System.Drawing.Imaging;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using Syncfusion.SVG.IO;
using DemoCommon.Diagram;

namespace RadialTreeLayout
{
    public partial class Form1 : DemoForm
    {
        #region Form Initialize
        public Form1()
        {
            InitializeComponent();
            diagram1.BeginUpdate();
            
            comboLytDirection.SelectedIndex = 0;
            DiagramAppearance();
            PopulateNodes();           
            this.diagram1.View.SelectionList.Clear();

            RadialTreeLayoutManager rdlLyt = new RadialTreeLayoutManager(this.diagram1.Model, 0, 10, 10);
            rdlLyt.LeftMargin = 40;
            rdlLyt.TopMargin = 20;
            this.diagram1.LayoutManager = rdlLyt;
            this.diagram1.LayoutManager.UpdateLayout(null);
            diagram1.EndUpdate();

            txtHSpacing.Text = rdlLyt.HorizontalSpacing.ToString();
            txtVSpacing.Text = rdlLyt.VerticalSpacing.ToString();
            txtLMarigin.Text = rdlLyt.LeftMargin.ToString();
            txtTMarigin.Text = rdlLyt.TopMargin.ToString();
            chkAutoLayout.Checked = rdlLyt.AutoLayout;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Change's the appearance of Diagram
        /// </summary>
        private void DiagramAppearance()
        {           
            this.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue;
            this.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue;
            this.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality;
            this.diagram1.View.BackgroundColor = Color.White;
            this.diagram1.Model.BoundaryConstraintsEnabled = false;

        }
        #endregion

        #region Initialize Diagram

        /// <summary>
        /// Initialize the nodes in daigram
        /// </summary>
        private void PopulateNodes()
        {
            //First level node
            Ellipse e1 = new Ellipse(0, 0, 90, 90);
            e1.FillStyle.Color = Color.FromArgb(160, 80, 80);
            e1.FillStyle.ForeColor = Color.FromArgb(255, 45, 45);
            e1.FillStyle.Type = FillStyleType.LinearGradient;
            e1.LineStyle.LineWidth = 0;
            e1.EnableShading = false;
            this.diagram1.Model.AppendChild(e1);

            GenerateInnerLevelNodes(e1, 5, Color.FromArgb(255,128,64), Color.FromArgb(255, 201, 74), 0);
        }

        /// <summary>
        /// Generates the Inner level nodes
        /// </summary>
        /// <param name="parentNode">Parent Node</param>
        /// <param name="maxSubNodes">Maximum sub nodes</param>
        /// <param name="LevelColor">Fill color for nodes</param>
        /// <param name="foreColor">ForeColor for nodes</param>
        /// <param name="n"></param>
        private void GenerateInnerLevelNodes(Node parentNode, int maxSubNodes, Color LevelColor, Color foreColor, int n)
        {
            for (int i = 0; i < maxSubNodes; i++)
            {
                Ellipse ellipse1 = GetEllipse(LevelColor, foreColor);
                this.diagram1.Model.AppendChild(ellipse1);
                ConnectNodes(parentNode, ellipse1, Color.Black);

                for (int j = 0; j < 5; j++)
                {
                    Ellipse ellipse2 = GetEllipse(LevelColor, foreColor);
                    this.diagram1.Model.AppendChild(ellipse2);
                    ConnectNodes(ellipse1, ellipse2, Color.Black);
                }
            }
        }

        /// <summary>
        /// New function for create a ellipse
        /// </summary>
        /// <returns></returns>
        private static Ellipse GetEllipse(Color fillColor,Color foreColor)
        {
            Ellipse ellipse1 = new Ellipse(0, 0, 45, 45);
            ellipse1.FillStyle.Color = fillColor;
            ellipse1.FillStyle.ForeColor = foreColor;
            ellipse1.LineStyle.LineColor = Color.Transparent;
            ellipse1.FillStyle.Type = FillStyleType.LinearGradient;
            // ellipse1.EnableShading = true;
            ellipse1.FillStyle.Type = FillStyleType.LinearGradient;
            return ellipse1;
        }

        /// <summary>
        /// Connects the given nodes
        /// </summary>
        /// <param name="parentNode">Parent Node</param>
        /// <param name="childNode">Child node</param>
        /// <param name="connectionColor">Connector Color</param>
        private void ConnectNodes(Node parentNode, Node childNode, Color connectionColor)
        {
            if (parentNode != null && childNode != null)
            {
                LineConnector lConnector = new LineConnector(PointF.Empty, new PointF(0, 1));
                //lConnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow;               
                lConnector.HeadDecorator.FillStyle.Color = Color.White;
                lConnector.HeadDecorator.LineStyle.LineColor = connectionColor;
                lConnector.LineStyle.LineColor = connectionColor;


                parentNode.CentralPort.TryConnect(lConnector.TailEndPoint);
                childNode.CentralPort.TryConnect(lConnector.HeadEndPoint);
                this.diagram1.Model.AppendChild(lConnector);
                this.diagram1.Model.SendToBack(lConnector);
            }
        }
        #endregion

        #region Event Handlers

        private void dialog_BeginLayout(TableLayoutManager layout)
        {
            this.diagram1.LayoutManager = layout;
            Layouting();
        }

        private void apply_Click(object sender, EventArgs e)
        {
            float rotationAngle = 0;
            if (txtHSpacing.Text != string.Empty)
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).HorizontalSpacing = float.Parse(txtHSpacing.Text);
            if (txtVSpacing.Text != string.Empty)
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).VerticalSpacing = float.Parse(txtVSpacing.Text);
            if (txtLMarigin.Text != string.Empty)
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).LeftMargin = float.Parse(txtLMarigin.Text);
            if (txtTMarigin.Text != string.Empty)
                ((RadialTreeLayoutManager)this.diagram1.LayoutManager).TopMargin = float.Parse(txtTMarigin.Text);
            switch (comboLytDirection.SelectedItem.ToString())
            {
                case "TopToBottom":
                    rotationAngle = 0;
                    break;
                case "TopLeft":
                    rotationAngle = 45;
                    break;
                case "TopRight":
                    rotationAngle = -45;
                    break;
                case "LeftToRight":
                    rotationAngle = 90;
                    break;
                case "RightToLeft":
                    rotationAngle = -90;
                    break;
                case "BottomToTop":
                    rotationAngle = 180;
                    break;
                case "BottomLeft":
                    rotationAngle = 135;
                    break;
                case "BottomRight":
                    rotationAngle = -135;
                    break;
            }
            ((RadialTreeLayoutManager)this.diagram1.LayoutManager).RotationAngle = rotationAngle;
            ((RadialTreeLayoutManager)this.diagram1.LayoutManager).AutoLayout = chkAutoLayout.Checked;
            Layouting();
        }       

        #endregion

        #region Helper Methods

        private void Layouting()
        {
            this.diagram1.LayoutManager.UpdateLayout(null);
            this.diagram1.UpdateView();

        }
        #endregion    
     
    }    
}