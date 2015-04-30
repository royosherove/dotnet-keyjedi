using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using KeyboardJedi.Core.Views;
using Timer = System.Timers.Timer;

namespace KeyboardJedi.Core.Services
{
	public class MouseDisabler
	{
		private readonly IMainFormView dockRootForm;
		private readonly Timer timer = new Timer(50.0);
		private string appTitleToDisableOn;

		public MouseDisabler(IMainFormView dockRootForm)
		{
			this.dockRootForm = dockRootForm;
			timer.Elapsed += timer_Elapsed;
		}

		public string AppTitle
		{
			get { return appTitleToDisableOn; }
		}

		public void Start()
		{
			appTitleToDisableOn = NativeHelpers.ActiveApplTitle();
			if (appTitleToDisableOn.Contains("Visual Studio"))
			{
				appTitleToDisableOn = "Visual Studio";
			}
			timer.Start();
		}

		public void Stop()
		{
			timer.Stop();
		}

		private void timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (NativeHelpers.ActiveApplTitle().Contains(appTitleToDisableOn))
			{
				Point position = Cursor.Position;
				Rectangle rectangle = new Rectangle(position, new Size(1, 1));
				if (!rectangle.IntersectsWith(dockRootForm.Bounds))
				{
					Cursor.Position = dockRootForm.Location;
				}
			}
		}
	}
}