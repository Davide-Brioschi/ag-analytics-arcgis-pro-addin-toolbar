﻿#pragma checksum "..\..\..\DEM_Service\DEMServiceDockpane.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "14788ABE7E67FA0F7FC778684CA3C8CACC422C480864591AA7035C64E68AFF8F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ag_Analytics_Toolbar.DEM_Service;
using ArcGIS.Desktop.Extensions;
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


namespace Ag_Analytics_Toolbar.DEM_Service {
    
    
    /// <summary>
    /// DEMServiceDockpaneView
    /// </summary>
    public partial class DEMServiceDockpaneView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 77 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_AOI;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_coordinate_system;
        
        #line default
        #line hidden
        
        
        #line 254 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Resolution;
        
        #line default
        #line hidden
        
        
        #line 320 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_Resolution;
        
        #line default
        #line hidden
        
        
        #line 324 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_ElevationIndex;
        
        #line default
        #line hidden
        
        
        #line 398 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid_Download_Folder;
        
        #line default
        #line hidden
        
        
        #line 492 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridResult;
        
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
            System.Uri resourceLocater = new System.Uri("/Ag_Analytics_Toolbar;component/dem_service/demservicedockpane.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DEM_Service\DEMServiceDockpane.xaml"
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
            this.Grid_AOI = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Grid_coordinate_system = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.Grid_Resolution = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.TextBox_Resolution = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Grid_ElevationIndex = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.Grid_Download_Folder = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.GridResult = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
