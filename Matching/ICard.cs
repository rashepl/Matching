
using Windows.UI.Xaml.Media.Animation;
namespace Matching
{
	public interface ICard
	{
		#region member variables
		#endregion

		#region properties

		/// <summary>
		/// gets/sets the state of showing the back of the card
		/// </summary>
		bool ShowCardBack
		{
			get;
			set;
		}

		/// <summary>
		/// gets/sets the state of showing the front of the card
		/// </summary>
		bool ShowCardFront
		{
			get;
			set;
		}

		/// <summary>
		/// gets the name of the card
		/// </summary>
		string CardName
		{
			get;
			set;
		}


		/// <summary>
		/// gets the storyboard for animating flipping the card
		/// </summary>
		Storyboard FlipAnimation
		{
			get;
		}

		/// <summary>
		/// gets the storyboard for flipping the card to its face down position
		/// </summary>
		Storyboard FlipToCardBack
		{
			get;
		}

		/// <summary>
		/// gets the storyboard for showing the front of the card at the beginning of the game
		/// </summary>
		Storyboard ShowCardsAtBeginning
		{
			get;
		}

		#endregion

		#region construction / destruction
		#endregion

		#region methods
		#endregion

		#region event handlers
		#endregion
	}
}
