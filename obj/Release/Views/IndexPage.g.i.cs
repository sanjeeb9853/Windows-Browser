﻿#pragma checksum "..\..\..\Views\IndexPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "89D58E8A28FAD407420ED0F668455E9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WebBrowser_Version_2.Views;


namespace WebBrowser_Version_2.Views {
    
    
    /// <summary>
    /// IndexPage
    /// </summary>
    public partial class IndexPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\Views\IndexPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _BackButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\IndexPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _HomeButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\IndexPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _UpButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Views\IndexPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mSearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\IndexPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mSearchButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Views\IndexPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WebBrowser mWebBrowser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WebBrowser_Version_2;component/views/indexpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\IndexPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this._BackButton = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Views\IndexPage.xaml"
            this._BackButton.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this._HomeButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Views\IndexPage.xaml"
            this._HomeButton.Click += new System.Windows.RoutedEventHandler(this.HomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this._UpButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\IndexPage.xaml"
            this._UpButton.Click += new System.Windows.RoutedEventHandler(this.UpButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\..\Views\IndexPage.xaml"
            this.mSearchTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.mSearchTextBox_GotFocus);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Views\IndexPage.xaml"
            this.mSearchTextBox.IsMouseDirectlyOverChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.mSearchTextBox_OnMouseDirectlyOver);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\Views\IndexPage.xaml"
            this.mSearchTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.mSearchTextBox_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mSearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Views\IndexPage.xaml"
            this.mSearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mWebBrowser = ((System.Windows.Controls.WebBrowser)(target));
            
            #line 38 "..\..\..\Views\IndexPage.xaml"
            this.mWebBrowser.Loaded += new System.Windows.RoutedEventHandler(this.WebBrowser_Loaded);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\Views\IndexPage.xaml"
            this.mWebBrowser.LoadCompleted += new System.Windows.Navigation.LoadCompletedEventHandler(this.WebBrowser_LoadCompleted);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

