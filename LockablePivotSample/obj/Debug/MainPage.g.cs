﻿#pragma checksum "C:\Users\kai.chen\Downloads\lockablepivotsample_1_2_3_4_5 (1)\LockablePivotSample\LockablePivotSample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81442D67F26472DD774CC205FA4B3FF8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
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


namespace LockablePivotSample {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.Pivot pivot;
        
        internal Microsoft.Phone.Controls.PivotItem FirstPivot_PV;
        
        internal Microsoft.Phone.Controls.PivotItem SecondPivot_PV;
        
        internal System.Windows.Controls.Canvas ContentPanelCanvas;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/LockablePivotSample;component/MainPage.xaml", System.UriKind.Relative));
            this.pivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivot")));
            this.FirstPivot_PV = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("FirstPivot_PV")));
            this.SecondPivot_PV = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("SecondPivot_PV")));
            this.ContentPanelCanvas = ((System.Windows.Controls.Canvas)(this.FindName("ContentPanelCanvas")));
        }
    }
}

