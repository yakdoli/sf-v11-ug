﻿#region Copyright Syncfusion Inc. 2001 - 2012
//
//  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram.Controls;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing;
using Syncfusion.SVG.IO;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Drawing.Drawing2D;
using DemoCommon.Diagram;

namespace Map
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class MainForm : DemoForm
    {

        #region Class initialize/finalize methods
        public MainForm( ) {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent( );
            this.diagram1.Model = this.model1;
           
        }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( ) {
            Application.Run( new MainForm( ) );
        }

        #region Class Event handlers
       

        private void MainForm_Load( object sender, EventArgs e ) {
            this.diagram1.MetroScrollBars = true;
            this.diagram1.EventSink.NodeMouseEnter += new NodeMouseEventHandler(EventSink_NodeMouseEnter);
            this.diagram1.EventSink.NodeMouseLeave += new NodeMouseEventHandler(EventSink_NodeMouseLeave);
           
            //Loading the diagram file
            this.diagram1.LoadBinary(@"..\..\..\..\..\..\..\..\..\Common\Data\Diagram\HighLightDiagram.edd");
           
            foreach (Node n in this.diagram1.Model.Nodes)
            {
                n.EditStyle.AllowSelect = false;                
            }
            this.diagram1.AllowDrop = false;
        }

               

        #region Event Handlers
        void EventSink_NodeMouseLeave(NodeMouseEventArgs evtArgs)
        {
            Polygon poly = evtArgs.Node as Polygon;
            if (poly != null)
            {
                poly.FillStyle.Color = defaultColor;
            }
        }

        void EventSink_NodeMouseEnter(NodeMouseEventArgs evtArgs)
        {
            Polygon poly = evtArgs.Node as Polygon;
            if (poly != null)
            {
                defaultColor = poly.FillStyle.Color;
                poly.FillStyle.Color = Color.White;
                toolTip1.SetToolTip(diagram1, poly.Name);
                toolTip1.Active = true;
            }
        }
        #endregion
        
       #endregion
    }
}
