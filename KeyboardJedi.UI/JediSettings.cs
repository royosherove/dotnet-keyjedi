using System.Drawing;
using Jedi;
using Jedi.Services;
using JediUI.Properties;

namespace JediUI
{
	public class JediSettings : IJediSettings
	{
		public double Opacity
		{
			get { return Settings.Default.Opacity; }
		}

		public Font Font
		{
			get { return Settings.Default.ListFont; }
		}

		public bool VisualStudioOnly
		{
			get { return Settings.Default.VisualStudioOnly; }
		}

		public string MouselessModeKey
		{
			get { return Settings.Default.MouselessModeKey; }
		}
	}
}