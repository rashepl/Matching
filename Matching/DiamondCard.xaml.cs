using System.ComponentModel;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Matching
{
	public sealed partial class DiamondCard : UserControl, ICard, INotifyPropertyChanged
	{
		#region events

		/// <summary>
		/// property changed event
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		#region member variables

		/// <summary>
		/// track the state of showing the front of the card
		/// </summary>
		private bool _showCardFront = false;

		/// <summary>
		/// track the state of showing the back of the card
		/// </summary>
		private bool _showCardBack = true;

		#endregion

		#region properties

		/// <summary>
		/// gets/sets the state of showing the front of the card
		/// </summary>
		public bool ShowCardFront
		{
			get { return _showCardFront; }
			set
			{
				_showCardFront = value;
				NotifyPropertyChanged("ShowCardFront");
			}
		}

		/// <summary>
		/// gets/sets the state of showing the back of the card
		/// </summary>
		public bool ShowCardBack
		{
			get { return _showCardBack; }
			set
			{
				_showCardBack = value;
				NotifyPropertyChanged("ShowCardBack");
			}
		}

		/// <summary>
		/// gets/sets the name of the card
		/// </summary>
		public string CardName
		{
			get;
			set;
		}

		#endregion

		#region construction / destruction

		/// <summary>
		/// construct a new diamond card
		/// </summary>
		public DiamondCard()
		{
			this.InitializeComponent();
		}
	
		#endregion

		#region methods

		/// <summary>
		/// call the property changed event using the property name
		/// </summary>
		/// <param name="propertyName"></param>
		private void NotifyPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion

		#region event handlers
		#endregion
	}
}
