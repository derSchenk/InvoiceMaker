// Updated by XamlIntelliSenseFileGenerator 10.05.2023 13:04:06
#pragma checksum "..\..\KundenAnlegen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E82C089F270EBB44FCA03A987ACB901067343AED29EFC14326DBCA285B93254A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using InvoiceMaker;
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


namespace InvoiceMaker
{


    /// <summary>
    /// KundenAnlegen
    /// </summary>
    public partial class KundenAnlegen : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 22 "..\..\KundenAnlegen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToHomeButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/InvoiceMaker;component/kundenanlegen.xaml", System.UriKind.Relative);

#line 1 "..\..\KundenAnlegen.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.BackToHomeButton = ((System.Windows.Controls.Button)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button MenuButtonOne;
        internal System.Windows.Controls.Button MenuButtonTwo;
        internal System.Windows.Controls.Button MenuButtonThree;
        internal System.Windows.Controls.Button MenuButtonFour;
        internal System.Windows.Controls.TextBox FirstName;
        internal System.Windows.Controls.TextBox LastName;
        internal System.Windows.Controls.TextBox AddressOne;
        internal System.Windows.Controls.TextBox AddressTwo;
        internal System.Windows.Controls.TextBox AdressThree;
        internal System.Windows.Controls.TextBox ZipCode;
        internal System.Windows.Controls.TextBox City;
        internal System.Windows.Controls.TextBox Email;
        internal System.Windows.Controls.TextBox Fon;
        internal System.Windows.Controls.CheckBox B2BCustomer;
        internal System.Windows.Controls.CheckBox CustomerLocked;
        internal System.Windows.Controls.TextBox Discount;
    }
}

