// Updated by XamlIntelliSenseFileGenerator 10/5/2024 3:06:25 PM
#pragma checksum "..\..\..\DemoCanvasPanel.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C596BA76102D370D7D3C32AA8DDE3FD2A9036712"
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
using WPFBasic;


namespace WPFBasic
{


    /// <summary>
    /// DemoCanvasPanel
    /// </summary>
    public partial class DemoCanvasPanel : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPFBasic;V1.0.0.0;component/democanvaspanel.xaml", System.UriKind.Relative);

#line 1 "..\..\..\DemoCanvasPanel.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.LabelInstructions = ((System.Windows.Controls.Label)(target));
                    return;
                case 2:
                    this.LabelCarName = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.TextBoxCarName = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.LabelColor = ((System.Windows.Controls.Label)(target));
                    return;
                case 5:
                    this.TextBoxColor = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.LabelBrand = ((System.Windows.Controls.Label)(target));
                    return;
                case 7:
                    this.TextBoxBrand = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 8:
                    this.ButtonDisplay = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\..\DemoCanvasPanel.xaml"
                    this.ButtonDisplay.Click += new System.Windows.RoutedEventHandler(this.ButtonDisplay_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

