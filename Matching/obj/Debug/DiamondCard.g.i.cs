﻿

#pragma checksum "D:\Software Projects\Matching\Matching\DiamondCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B7290A67609573CCDCF310B598C1482"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Matching
{
    partial class DiamondCard : global::Windows.UI.Xaml.Controls.UserControl
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.UserControl _diamondCard; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard flipCardStoryboard; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Viewbox _backOfCardViewbox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock textBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Shapes.Polygon polygon; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///DiamondCard.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            _diamondCard = (global::Windows.UI.Xaml.Controls.UserControl)this.FindName("_diamondCard");
            flipCardStoryboard = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("flipCardStoryboard");
            _backOfCardViewbox = (global::Windows.UI.Xaml.Controls.Viewbox)this.FindName("_backOfCardViewbox");
            textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("textBlock");
            polygon = (global::Windows.UI.Xaml.Shapes.Polygon)this.FindName("polygon");
        }
    }
}



