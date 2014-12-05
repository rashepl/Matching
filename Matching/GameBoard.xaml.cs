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

		/// <summary>
		/// holds the player selected card
		/// </summary>
		private ICard _selectedCard;

		/// <summary>
		/// holds the number of matches made by the player
		/// </summary>
		private int _numberOfMatches;

		/// <summary>
		/// holds the number of turns
		/// </summary>
		private int _numberOfTurns;

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

		/// <summary>
		/// gets/sets the card selected by the player
		/// </summary>
		private ICard SelectedCard
		{
			get { return _selectedCard; }
			set { _selectedCard = value; }
		}

		/// <summary>
		/// gets/sets the number of matches made by the player
		/// </summary>
		private int NumberOfMatches
		{
			get { return _numberOfMatches; }
			set { _numberOfMatches = value; }
		}

		/// <summary>
		/// gets/sets the number of turns made by the player
		/// </summary>
		private int NumberOfTurns
		{
			get { return _numberOfTurns; }
			set { _numberOfTurns = value; }
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
			showPreviewText.Begin();

			CircleCard circleCard1 = new CircleCard();
			circleCard1.CardName = "circleCard1";
			circleCard1.Tapped += card_Tapped;
			circleCard1.ShowCardsAtBeginning.Begin();

			CircleCard circleCard2 = new CircleCard();
			circleCard2.CardName = "circleCard2";
			circleCard2.Tapped += card_Tapped;
			circleCard2.ShowCardsAtBeginning.Begin();

			DiamondCard diamondCard1 = new DiamondCard();
			diamondCard1.CardName = "diamondCard1";
			diamondCard1.Tapped += card_Tapped;
			diamondCard1.ShowCardsAtBeginning.Begin();

			DiamondCard diamondCard2 = new DiamondCard();
			diamondCard2.CardName = "diamondCard2";
			diamondCard2.Tapped += card_Tapped;
			diamondCard2.ShowCardsAtBeginning.Begin();
			
			HexagonCard hexagonCard1 = new HexagonCard();
			hexagonCard1.CardName = "hexagonCard1";
			hexagonCard1.Tapped += card_Tapped;
			hexagonCard1.ShowCardsAtBeginning.Begin();

			HexagonCard hexagonCard2 = new HexagonCard();
			hexagonCard2.CardName = "hexagonCard2";
			hexagonCard2.Tapped += card_Tapped;
			hexagonCard2.ShowCardsAtBeginning.Begin();
		
			ParallelogramCard parallelogramCard1 = new ParallelogramCard();
			parallelogramCard1.CardName = "parallelogramCard1";
			parallelogramCard1.Tapped += card_Tapped;
			parallelogramCard1.ShowCardsAtBeginning.Begin();		
			
			ParallelogramCard parallelogramCard2 = new ParallelogramCard();
			parallelogramCard2.CardName = "parallelogramCard2";
			parallelogramCard2.Tapped += card_Tapped;
			parallelogramCard2.ShowCardsAtBeginning.Begin();		
			
			PentagonCard pentagonCard1 = new PentagonCard();
			pentagonCard1.CardName = "pentagonCard1";
			pentagonCard1.Tapped += card_Tapped;
			pentagonCard1.ShowCardsAtBeginning.Begin();
		
			PentagonCard pentagonCard2 = new PentagonCard();
			pentagonCard2.CardName = "pentagonCard2";
			pentagonCard2.Tapped += card_Tapped;
			pentagonCard2.ShowCardsAtBeginning.Begin();
		
			SquareCard squareCard1 = new SquareCard();
			squareCard1.CardName = "squareCard1";
			squareCard1.Tapped += card_Tapped;
			squareCard1.ShowCardsAtBeginning.Begin();

			SquareCard squareCard2 = new SquareCard();
			squareCard2.CardName = "squareCard2";
			squareCard2.Tapped += card_Tapped;
			squareCard2.ShowCardsAtBeginning.Begin();
		
			StarCard starCard1 = new StarCard();
			starCard1.CardName = "starCard1";
			starCard1.Tapped += card_Tapped;
			starCard1.ShowCardsAtBeginning.Begin();

			StarCard starCard2 = new StarCard();
			starCard2.CardName = "starCard2";
			starCard2.Tapped += card_Tapped;
			starCard2.ShowCardsAtBeginning.Begin();

			TrapezoidCard trapezoidCard1 = new TrapezoidCard();
			trapezoidCard1.CardName = "trapezoidCard1";
			trapezoidCard1.Tapped += card_Tapped;
			trapezoidCard1.ShowCardsAtBeginning.Begin();

			TrapezoidCard trapezoidCard2 = new TrapezoidCard();
			trapezoidCard2.CardName = "trapezoidCard2";
			trapezoidCard2.Tapped += card_Tapped;
			trapezoidCard2.ShowCardsAtBeginning.Begin();

			TriangleCard triangleCard1 = new TriangleCard();
			triangleCard1.CardName = "triangleCard1";
			triangleCard1.Tapped += card_Tapped;
			triangleCard1.ShowCardsAtBeginning.Begin();

			TriangleCard triangleCard2 = new TriangleCard();
			triangleCard2.CardName = "triangleCard2";
			triangleCard2.Tapped += card_Tapped;
			triangleCard2.ShowCardsAtBeginning.Begin();

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
			ICard card = sender as ICard;
			//card.ShowCardBack = false;
			//card.ShowCardFront = true;
			card.FlipAnimation.Begin();

			if (SelectedCard == null)
			{
				SelectedCard = card;
				_turns.Text = string.Format("Turns: {0}", ++NumberOfTurns);
			}
			else
			{
				if (SelectedCard.GetType() == card.GetType() && string.Compare(SelectedCard.CardName, card.CardName) != 0)
				{
					// match
					_matches.Text = string.Format("Matches: {0}", ++NumberOfMatches);
					(SelectedCard as UserControl).Tapped -= card_Tapped;
					(card as UserControl).Tapped -= card_Tapped;

					_notificationGrid.Visibility = NumberOfMatches == 8 ? Visibility.Visible : Visibility.Collapsed;
				}
				else
				{
					//SelectedCard.ShowCardBack = true;
					//SelectedCard.ShowCardFront = false;

					//card.ShowCardBack = true;
					//card.ShowCardFront = false;

					SelectedCard.FlipToCardBack.Begin();
					card.FlipToCardBack.Begin();
				}

				SelectedCard = null;
			}
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
