﻿#pragma checksum "..\..\..\FrontEnd\OrderDetails.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "29FB21B3FF4B13A38E5A24B831D2D666A2B996BBFCC21B21BFE017ABEDF98B19"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CityPizza;
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


namespace CityPizza {
    
    
    /// <summary>
    /// OrderDetails
    /// </summary>
    public partial class OrderDetails : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 77 "..\..\..\FrontEnd\OrderDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SideDishes;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\FrontEnd\OrderDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pizza;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\FrontEnd\OrderDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Beverages;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\FrontEnd\OrderDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dips;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\FrontEnd\OrderDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Wings;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\FrontEnd\OrderDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Sauce;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\FrontEnd\OrderDetails.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Payment;
        
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
            System.Uri resourceLocater = new System.Uri("/CityPizza;component/frontend/orderdetails.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FrontEnd\OrderDetails.xaml"
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
            this.SideDishes = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\FrontEnd\OrderDetails.xaml"
            this.SideDishes.Click += new System.Windows.RoutedEventHandler(this.SideDishes_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Pizza = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Beverages = ((System.Windows.Controls.Button)(target));
            
            #line 79 "..\..\..\FrontEnd\OrderDetails.xaml"
            this.Beverages.Click += new System.Windows.RoutedEventHandler(this.Beverages_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Dips = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\FrontEnd\OrderDetails.xaml"
            this.Dips.Click += new System.Windows.RoutedEventHandler(this.Dips_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Wings = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\FrontEnd\OrderDetails.xaml"
            this.Wings.Click += new System.Windows.RoutedEventHandler(this.Wings_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Sauce = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\FrontEnd\OrderDetails.xaml"
            this.Sauce.Click += new System.Windows.RoutedEventHandler(this.Sauce_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Payment = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\FrontEnd\OrderDetails.xaml"
            this.Payment.Click += new System.Windows.RoutedEventHandler(this.Payment_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
