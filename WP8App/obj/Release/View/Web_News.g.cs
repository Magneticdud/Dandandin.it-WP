﻿#pragma checksum "C:\DoWapp\Jobs\289297.towwtv\src\WP8App\View\Web_News.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "02C20F2E058F5FE1F5E29B58A0E4D33A"
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
using MyToolkit.Paging;
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
using WPAppStudio.Controls;


namespace WPAppStudio.View {
    
    
    public partial class Web_News : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaWeb_News0RefreshBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaWeb_News0SetLockScreenBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarMenuItem PanoramaWeb_News0AboutBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaWeb_News1RefreshBtn;
        
        internal MyToolkit.Paging.BindableApplicationBarIconButton PanoramaWeb_News2RefreshBtn;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Panorama PanoramaWeb_News;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaWeb_News0;
        
        internal WPAppStudio.Controls.LongListSelector Web_NewsListControl;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaWeb_News1;
        
        internal WPAppStudio.Controls.LongListSelector YouTube_VideosListControl;
        
        internal Microsoft.Phone.Controls.PanoramaItem PanoramaWeb_News2;
        
        internal WPAppStudio.Controls.LongListSelector Facebook_NewsListControl;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WPAppStudio;component/View/Web_News.xaml", System.UriKind.Relative));
            this.PanoramaWeb_News0RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaWeb_News0RefreshBtn")));
            this.PanoramaWeb_News0SetLockScreenBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaWeb_News0SetLockScreenBtn")));
            this.PanoramaWeb_News0AboutBtn = ((MyToolkit.Paging.BindableApplicationBarMenuItem)(this.FindName("PanoramaWeb_News0AboutBtn")));
            this.PanoramaWeb_News1RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaWeb_News1RefreshBtn")));
            this.PanoramaWeb_News2RefreshBtn = ((MyToolkit.Paging.BindableApplicationBarIconButton)(this.FindName("PanoramaWeb_News2RefreshBtn")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.PanoramaWeb_News = ((Microsoft.Phone.Controls.Panorama)(this.FindName("PanoramaWeb_News")));
            this.PanoramaWeb_News0 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaWeb_News0")));
            this.Web_NewsListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("Web_NewsListControl")));
            this.PanoramaWeb_News1 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaWeb_News1")));
            this.YouTube_VideosListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("YouTube_VideosListControl")));
            this.PanoramaWeb_News2 = ((Microsoft.Phone.Controls.PanoramaItem)(this.FindName("PanoramaWeb_News2")));
            this.Facebook_NewsListControl = ((WPAppStudio.Controls.LongListSelector)(this.FindName("Facebook_NewsListControl")));
        }
    }
}
