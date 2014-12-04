using System.ComponentModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Matching
{
	public sealed partial class MoonCard : UserControl, ICard, INotifyPropertyChanged
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
		/// gets the name of the card
		/// </summary>
		public string CardName
		{
			get { return Name; }
		}

		/// <summary>
		/// gets the storyboard for animating flipping the card
		/// </summary>
		public Storyboard FlipAnimation
		{
			get { return flipCardStoryboard; }
		}

		/// <summary>
		/// gets the storyboard for flipping the card to its face down position
		/// </summary>
		public Storyboard FlipToCardBack
		{
			get { return flipToCardBack; }
		}

		/// <summary>
		/// gets the storyboard for displaying the cards at the beginning of the game
		/// </summary>
		public Storyboard ShowCardsAtBeginning
		{
			get { return showCardsAtBeginning; }
		}

		#endregion

		#region construction / destruction

		/// <summary>
		/// construct a new moon card
		/// </summary>
		public MoonCard()
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
