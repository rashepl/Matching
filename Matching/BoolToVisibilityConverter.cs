using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Matching
{
	public class BoolToVisibilityConverter : IValueConverter
	{
		#region member variables
		#endregion

		#region properties
		#endregion

		#region construction / destruction
		#endregion

		#region methods

		/// <summary>
		/// convert from a bool to a visibility type
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			bool visibilityValue = (bool)value;
			Visibility visibility = Visibility.Collapsed;
			if (!visibilityValue)
			{
				visibility = Visibility.Collapsed;
			}
			else if (visibilityValue)
			{
				visibility = Visibility.Visible;
			}
			return visibility;
		}

		/// <summary>
		/// convert from a visiblity type to a bool, just return nothing
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return null;
		}

		#endregion

		#region event handlers
		#endregion
	}
}
