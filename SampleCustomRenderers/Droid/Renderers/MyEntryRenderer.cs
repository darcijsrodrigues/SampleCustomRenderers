using SampleCustomRenderers.CustomControls;
using SampleCustomRenderers.Droid.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace SampleCustomRenderers.Droid.Renderer
{
	public class MyEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.SetBackgroundColor(global::Android.Graphics.Color.Rgb(204, 153, 255));
				Control.SetTextColor(global::Android.Graphics.Color.White);
			}
		}
	}
}
