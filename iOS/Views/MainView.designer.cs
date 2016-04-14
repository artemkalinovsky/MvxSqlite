// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MvxSqlite.iOS.Views
{
	[Register ("MainView")]
	partial class MainView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Load { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton Save { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField Text { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Load != null) {
				Load.Dispose ();
				Load = null;
			}
			if (Save != null) {
				Save.Dispose ();
				Save = null;
			}
			if (Text != null) {
				Text.Dispose ();
				Text = null;
			}
		}
	}
}
