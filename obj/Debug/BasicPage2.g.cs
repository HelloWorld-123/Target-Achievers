﻿

#pragma checksum "C:\Users\Arpit\Downloads\ta-2015-11-13\ta\BasicPage2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "79C4E9B1048C16BB1B9643D85FF51F76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App9
{
    partial class BasicPage2 : global::App9.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 71 "..\..\BasicPage2.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.ju_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 39 "..\..\BasicPage2.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.GoBack;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


