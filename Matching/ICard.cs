using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Matching
{
	public interface ICard
	{
		#region member variables
		#endregion

		#region properties

		/// <summary>
		/// gets/sets the selected state of the card
		/// </summary>
		bool Selected
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
