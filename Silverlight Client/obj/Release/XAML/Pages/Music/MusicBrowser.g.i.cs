﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Pages\Music\MusicBrowser.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "770AC9DFC5275EB2D6769F44E009D63B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace SilverPotato {
    
    
    public partial class MusicBrowser : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid gdRootStrip;
        
        internal System.Windows.Controls.Grid gdChooser;
        
        internal System.Windows.Controls.Grid gdSpinner;
        
        internal System.Windows.Controls.Grid gdMessage;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Pages/Music/MusicBrowser.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.gdRootStrip = ((System.Windows.Controls.Grid)(this.FindName("gdRootStrip")));
            this.gdChooser = ((System.Windows.Controls.Grid)(this.FindName("gdChooser")));
            this.gdSpinner = ((System.Windows.Controls.Grid)(this.FindName("gdSpinner")));
            this.gdMessage = ((System.Windows.Controls.Grid)(this.FindName("gdMessage")));
        }
    }
}
