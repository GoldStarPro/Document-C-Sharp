﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "69064E60ECB5A89E7420E3E4947722A4A3965ADC44C9DDCA6C683D028765F511"
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


namespace ContextMenuApp1 {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmButton1;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu cm1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cmButton2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu cm2;
        
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
            System.Uri resourceLocater = new System.Uri("/ContextMenuApp1;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            this.cmButton1 = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.cm1 = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 3:
            
            #line 11 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Checked += new System.Windows.RoutedEventHandler(this.Bold_Checked1);
            
            #line default
            #line hidden
            
            #line 12 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.Bold_Unchecked1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 13 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Message1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmButton2 = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.cm2 = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 7:
            
            #line 22 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Checked += new System.Windows.RoutedEventHandler(this.Bold_Checked2);
            
            #line default
            #line hidden
            
            #line 22 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.Bold_Unchecked2);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 23 "..\..\Window1.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Message2);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

