﻿#pragma checksum "..\..\..\..\Popup\TopBannerMenuPopup.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3EA628D14F91D3F34FC195E79E76929F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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


namespace TopBannerModule {
    
    
    /// <summary>
    /// TopBannerMenuPopup
    /// </summary>
    public partial class TopBannerMenuPopup : System.Windows.Controls.Primitives.Popup, System.Windows.Markup.IComponentConnector {
        
        
        #line 4 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TopBannerModule.TopBannerMenuPopup TopBannerMenuPopupName;
        
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
            System.Uri resourceLocater = new System.Uri("/TopBannerModule;component/popup/topbannermenupopup.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
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
            this.TopBannerMenuPopupName = ((TopBannerModule.TopBannerMenuPopup)(target));
            return;
            case 2:
            
            #line 6 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MatchEngineClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 7 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CalendarClick);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 8 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClubClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 9 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TeamClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 10 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TacticClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 11 "..\..\..\..\Popup\TopBannerMenuPopup.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MainMenuClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

