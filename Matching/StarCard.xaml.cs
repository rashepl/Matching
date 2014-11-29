using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
	public sealed partial class StarCard : UserControl, ICard
	{
		#region member variables
		#endregion

		#region properties

		/// <summary>
		/// gets/sets the selected state of the card
		/// </summary>
		public bool Selected
		{
			get;
			set;
		}

		/// <summary>
		/// gets the name of the card
		/// </summary>
		public string CardName
		{
			get { return Name; }
		}
		
		#endregion

		#region construction / destruction

		/// <summary>
		/// construct a new star card
		/// </summary>
		public StarCard()
		{
			this.InitializeComponent();
		}
	
		#endregion

		#region methods
		#endregion

		#region event handlers
		#endregion
	}
}
