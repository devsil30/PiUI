﻿#pragma checksum "C:\Users\Adam\Documents\Visual Studio 2013\Projects\PiUI\PiUI\SendDataPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA8BC923E7D5650D56107088B943E598"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace PiUI.Resources {
    
    
    public partial class SendDataPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock Title;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button Send;
        
        internal System.Windows.Controls.TextBox txtInput;
        
        internal System.Windows.Controls.TextBox txtOutput;
        
        internal System.Windows.Controls.TextBox textRemoteHost;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/PiUI;component/SendDataPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Title = ((System.Windows.Controls.TextBlock)(this.FindName("Title")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Send = ((System.Windows.Controls.Button)(this.FindName("Send")));
            this.txtInput = ((System.Windows.Controls.TextBox)(this.FindName("txtInput")));
            this.txtOutput = ((System.Windows.Controls.TextBox)(this.FindName("txtOutput")));
            this.textRemoteHost = ((System.Windows.Controls.TextBox)(this.FindName("textRemoteHost")));
        }
    }
}

