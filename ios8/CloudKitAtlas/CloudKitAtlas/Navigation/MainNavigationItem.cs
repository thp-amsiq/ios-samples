using System;

using UIKit;
using Foundation;

namespace CloudKitAtlas
{
	public partial class MainNavigationItem : UINavigationItem
	{
		public MainNavigationItem (IntPtr handle)
			: base (handle)
		{
		}

		public MainNavigationItem (NSCoder coder)
			: base (coder)
		{
			TitleView = new UIImageView (UIImage.FromBundle ("Title"));
		}
	}
}
