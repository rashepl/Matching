﻿

#pragma checksum "D:\Software Projects\Matching\Matching\StarCard.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "495BC2ADB0CAD9EAF9CAE5A65DFF8119"
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
    partial class StarCard : global::Windows.UI.Xaml.Controls.UserControl
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.UserControl _starCard; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard flipCardStoryboard; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard flipToCardBack; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.Storyboard showCardsAtBeginning; 
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
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///StarCard.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            _starCard = (global::Windows.UI.Xaml.Controls.UserControl)this.FindName("_starCard");
            flipCardStoryboard = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("flipCardStoryboard");
            flipToCardBack = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("flipToCardBack");
            showCardsAtBeginning = (global::Windows.UI.Xaml.Media.Animation.Storyboard)this.FindName("showCardsAtBeginning");
            _backOfCardViewbox = (global::Windows.UI.Xaml.Controls.Viewbox)this.FindName("_backOfCardViewbox");
            textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("textBlock");
            polygon = (global::Windows.UI.Xaml.Shapes.Polygon)this.FindName("polygon");
        }
    }
}



