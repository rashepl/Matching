using Matching.Common;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Matching
{
	/// <summary>
	/// A basic page that provides characteristics common to most applications.
	/// </summary>
	public sealed partial class GameBoard : Page
	{
		#region member variables

		/// <summary>
		/// aids in page navigation
		/// </summary>
		private NavigationHelper navigationHelper;

		/// <summary>
		/// track the default view model
		/// </summary>
		private ObservableDictionary defaultViewModel = new ObservableDictionary();

		#endregion

		#region properties

		/// <summary>
		/// This can be changed to a strongly typed view model.
		/// </summary>
		public ObservableDictionary DefaultViewModel
		{
			get { return this.defaultViewModel; }
		}

		/// <summary>
		/// NavigationHelper is used on each page to aid in navigation and 
		/// process lifetime management
		/// </summary>
		public NavigationHelper NavigationHelper
		{
			get { return this.navigationHelper; }
		}

		#endregion

		#region construction / destruction

		/// <summary>
		/// construct the game board
		/// </summary>
		public GameBoard()
		{
			this.InitializeComponent();
			this.navigationHelper = new NavigationHelper(this);
			this.navigationHelper.LoadState += navigationHelper_LoadState;
			this.navigationHelper.SaveState += navigationHelper_SaveState;

			InitializeCards();
		}

		#endregion

		#region methods

		/// <summary>
		/// initialize the setup of the game cards
		/// </summary>
		private void InitializeCards()
		{
			CircleCard circleCard1 = new CircleCard();
			circleCard1.Tapped += card_Tapped;
			CircleCard circleCard2 = new CircleCard();
			circleCard2.Tapped += card_Tapped;
			DiamondCard diamondCard1 = new DiamondCard();
			diamondCard1.Tapped += card_Tapped;
			DiamondCard diamondCard2 = new DiamondCard();
			diamondCard2.Tapped += card_Tapped;
			HexagonCard hexagonCard1 = new HexagonCard();
			hexagonCard1.Tapped += card_Tapped;
			HexagonCard hexagonCard2 = new HexagonCard();
			hexagonCard2.Tapped += card_Tapped;
			ParallelogramCard parallelogramCard1 = new ParallelogramCard();
			parallelogramCard1.Tapped += card_Tapped;
			ParallelogramCard parallelogramCard2 = new ParallelogramCard();
			parallelogramCard2.Tapped += card_Tapped;
			PentagonCard pentagonCard1 = new PentagonCard();
			pentagonCard1.Tapped += card_Tapped;
			PentagonCard pentagonCard2 = new PentagonCard();
			pentagonCard2.Tapped += card_Tapped;
			SquareCard squareCard1 = new SquareCard();
			squareCard1.Tapped += card_Tapped;
			SquareCard squareCard2 = new SquareCard();
			squareCard2.Tapped += card_Tapped;
			StarCard starCard1 = new StarCard();
			starCard1.Tapped += card_Tapped;
			StarCard starCard2 = new StarCard();
			starCard2.Tapped += card_Tapped;
			TrapezoidCard trapezoidCard1 = new TrapezoidCard();
			trapezoidCard1.Tapped += card_Tapped;
			TrapezoidCard trapezoidCard2 = new TrapezoidCard();
			trapezoidCard2.Tapped += card_Tapped;
			TriangleCard triangleCard1 = new TriangleCard();
			triangleCard1.Tapped += card_Tapped;
			TriangleCard triangleCard2 = new TriangleCard();
			triangleCard2.Tapped += card_Tapped;

			Random random = new Random();
			int randomLocation = -1;

			List<int> randomGridLocations = new List<int>();
			while (randomGridLocations.Count < 16)
			{
				randomLocation = random.Next(16);
				if (!randomGridLocations.Contains(randomLocation))
				{
					randomGridLocations.Add(randomLocation);
				}
			}

			Dictionary<ICard, int> cards = new Dictionary<ICard, int>();
			cards.Add(circleCard1, randomGridLocations[0]);
			cards.Add(circleCard2, randomGridLocations[1]);
			cards.Add(diamondCard1, randomGridLocations[2]);
			cards.Add(diamondCard2, randomGridLocations[3]);
			cards.Add(hexagonCard1, randomGridLocations[4]);
			cards.Add(hexagonCard2, randomGridLocations[5]);
			cards.Add(parallelogramCard1, randomGridLocations[6]);
			cards.Add(parallelogramCard2, randomGridLocations[7]);
			cards.Add(pentagonCard1, randomGridLocations[8]);
			cards.Add(pentagonCard2, randomGridLocations[9]);
			cards.Add(squareCard1, randomGridLocations[10]);
			cards.Add(squareCard2, randomGridLocations[11]);
			cards.Add(trapezoidCard1, randomGridLocations[12]);
			cards.Add(trapezoidCard2, randomGridLocations[13]);
			cards.Add(triangleCard1, randomGridLocations[14]);
			cards.Add(triangleCard2, randomGridLocations[15]);

			foreach (ICard card in cards.Keys)
			{
				int row = cards[card] / 4;
				int column = cards[card] % 4;

				Grid.SetRow(card as FrameworkElement, row);
				Grid.SetColumn(card as FrameworkElement, column);
				_gameGrid.Children.Add(card as UIElement);
			}
		}

		#endregion

		#region event handlers

		/// <summary>
		/// Populates the page with content passed during navigation. Any saved state is also
		/// provided when recreating a page from a prior session.
		/// </summary>
		/// <param name="sender">
		/// The source of the event; typically <see cref="NavigationHelper"/>
		/// </param>
		/// <param name="e">Event data that provides both the navigation parameter passed to
		/// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
		/// a dictionary of state preserved by this page during an earlier
		/// session. The state will be null the first time a page is visited.</param>
		private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
		{
		}

		/// <summary>
		/// Preserves state associated with this page in case the application is suspended or the
		/// page is discarded from the navigation cache.  Values must conform to the serialization
		/// requirements of <see cref="SuspensionManager.SessionState"/>.
		/// </summary>
		/// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
		/// <param name="e">Event data that provides an empty dictionary to be populated with
		/// serializable state.</param>
		private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
		{
		}

		/// <summary>
		/// handles the tapped event on the card
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void card_Tapped(object sender, TappedRoutedEventArgs e)
		{
			UserControl control = sender as UserControl;
			(control as ICard).ShowCardBack = false;
			(control as ICard).ShowCardFront = true;
		}

		#endregion

		#region NavigationHelper registration

		/// The methods provided in this section are simply used to allow
		/// NavigationHelper to respond to the page's navigation methods.
		/// 
		/// Page specific logic should be placed in event handlers for the  
		/// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
		/// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
		/// The navigation parameter is available in the LoadState method 
		/// in addition to page state preserved during an earlier session.

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			navigationHelper.OnNavigatedTo(e);
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e)
		{
			navigationHelper.OnNavigatedFrom(e);
		}

		#endregion
	}
}
