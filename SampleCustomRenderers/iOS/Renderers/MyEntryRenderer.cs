using SampleCustomRenderers.CustomControls;
using SampleCustomRenderers.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace SampleCustomRenderers.iOS
{
	public class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e) {
			base.OnElementChanged(e);

			if (Control != null) { 
				Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
				Control.TextColor = UIColor.White;
			}
		}
	}
}
