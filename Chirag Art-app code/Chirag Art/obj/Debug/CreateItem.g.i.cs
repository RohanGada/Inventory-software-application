﻿#pragma checksum "..\..\CreateItem.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CE65A2ADE3AF82434754F6184675B070"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace Chirag_Art {
    
    
    /// <summary>
    /// CreateItem
    /// </summary>
    public partial class CreateItem : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox barcode;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox item_name;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox item_grp;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox item_category;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cost;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox percent;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox margin;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantity;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CreateItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mrp;
        
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
            System.Uri resourceLocater = new System.Uri("/Chirag Art;component/createitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateItem.xaml"
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
            
            #line 6 "..\..\CreateItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 7 "..\..\CreateItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.barcode = ((System.Windows.Controls.TextBox)(target));
            
            #line 8 "..\..\CreateItem.xaml"
            this.barcode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.barcode_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.item_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.item_grp = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.item_category = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.cost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.percent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.margin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.quantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 24 "..\..\CreateItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 25 "..\..\CreateItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cancel_onCLick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 26 "..\..\CreateItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 14:
            this.mrp = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
