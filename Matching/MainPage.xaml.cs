using Matching.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Matching
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
		{
			#region member variables
			#endregion

			#region properties
			#endregion

			#region construction / destruction

			/// <summary>
			/// construct the main page
			/// </summary>
			public MainPage()
			{
				InitializeComponent();
			}

			#endregion

			#region methods
			#endregion

			#region event handlers

			/// <summary>
			/// handle the tapped event from the button
			/// </summary>
			/// <param name="sender"></param>
			/// <param name="e"></param>
			private void Button_Tapped(object sender, TappedRoutedEventArgs e)
			{
				Frame.Navigate(typeof(GameBoard));
			}

			#endregion
    }
}
