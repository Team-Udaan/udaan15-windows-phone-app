﻿#pragma checksum "C:\Users\Dhruv\Desktop\udaan15-windows-phone-app\Udaan15\Udaan15\EventDetails.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6CEA00CA97B8A820C3BDBD39E53B549A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
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


namespace Udaan15 {
    
    
    public partial class EventDetails : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock TitleString;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock Dept;
        
        internal System.Windows.Controls.TextBlock desc;
        
        internal System.Windows.Controls.TextBlock ptc;
        
        internal System.Windows.Controls.TextBlock mgrText;
        
        internal System.Windows.Controls.ListBox mgrs;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Udaan15;component/EventDetails.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitleString = ((System.Windows.Controls.TextBlock)(this.FindName("TitleString")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Dept = ((System.Windows.Controls.TextBlock)(this.FindName("Dept")));
            this.desc = ((System.Windows.Controls.TextBlock)(this.FindName("desc")));
            this.ptc = ((System.Windows.Controls.TextBlock)(this.FindName("ptc")));
            this.mgrText = ((System.Windows.Controls.TextBlock)(this.FindName("mgrText")));
            this.mgrs = ((System.Windows.Controls.ListBox)(this.FindName("mgrs")));
        }
    }
}

