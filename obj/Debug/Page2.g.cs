﻿#pragma checksum "..\..\Page2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DCD6A7DD12BE9A72AFE172AA84A9F6169DB850D6BE215112B527E659F2875A83"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Praktika1;
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


namespace Praktika1 {
    
    
    /// <summary>
    /// Page2
    /// </summary>
    public partial class Page2 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Goods_Table;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoodAdd_btn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoodUp_btn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GoodDel_btn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameG_tbx;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GoodN_tbx;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GoodC_tbx;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Page2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GoodNal_tbx;
        
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
            System.Uri resourceLocater = new System.Uri("/Praktika1;component/page2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page2.xaml"
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
            this.Goods_Table = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.GoodAdd_btn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Page2.xaml"
            this.GoodAdd_btn.Click += new System.Windows.RoutedEventHandler(this.GoodAdd_btn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GoodUp_btn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Page2.xaml"
            this.GoodUp_btn.Click += new System.Windows.RoutedEventHandler(this.GoodUp_btn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GoodDel_btn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Page2.xaml"
            this.GoodDel_btn.Click += new System.Windows.RoutedEventHandler(this.GoodDel_btn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NameG_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.GoodN_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.GoodC_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.GoodNal_tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

