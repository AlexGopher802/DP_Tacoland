﻿#pragma checksum "..\..\..\HistoryDescriptionWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3B02D5CB234470338F5E9669EE3688E409DB4564"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CafeOrdering;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CafeOrdering {
    
    
    /// <summary>
    /// HistoryDescriptionWindow
    /// </summary>
    public partial class HistoryDescriptionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\HistoryDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbWelcome;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\HistoryDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\HistoryDescriptionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridProducts;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CafeOrdering;component/historydescriptionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\HistoryDescriptionWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\HistoryDescriptionWindow.xaml"
            ((CafeOrdering.HistoryDescriptionWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.HistoryDescriptionWindow_OnLoaded);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\HistoryDescriptionWindow.xaml"
            ((CafeOrdering.HistoryDescriptionWindow)(target)).Closed += new System.EventHandler(this.HistoryDescriptionWindow_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TbWelcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\HistoryDescriptionWindow.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DataGridProducts = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
