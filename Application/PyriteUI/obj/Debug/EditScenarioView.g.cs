#pragma checksum "..\..\EditScenarioView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4616C689FFBF31F81823DB589B7705199B9743132677A0B94D82B1F82AFEC1B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PyriteUI;
using PyriteUI.ScenarioCreation;
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


namespace PyriteUI {
    
    
    /// <summary>
    /// EditScenarioView
    /// </summary>
    public partial class EditScenarioView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCreate;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCancel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbIndex;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PyriteUI.BooleanSelector bUseInServer;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PyriteUI.BooleanSelector bUseInPool;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal PyriteUI.BooleanSelector bUseOnOffState;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbCategory;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbSelectCategory;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbStatus;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\EditScenarioView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border borderScenarioHolder;
        
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
            System.Uri resourceLocater = new System.Uri("/PyriteUI;component/editscenarioview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditScenarioView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.btCreate = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.btCancel = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbIndex = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.bUseInServer = ((PyriteUI.BooleanSelector)(target));
            return;
            case 6:
            this.bUseInPool = ((PyriteUI.BooleanSelector)(target));
            return;
            case 7:
            this.bUseOnOffState = ((PyriteUI.BooleanSelector)(target));
            return;
            case 8:
            this.tbCategory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cbSelectCategory = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.tbStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.borderScenarioHolder = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

