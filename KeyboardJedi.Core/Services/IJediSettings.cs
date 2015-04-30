using System.Drawing;

namespace KeyboardJedi.Core.Services
{
	public interface IJediSettings
	{
		double Opacity { get; }
		Font Font { get; }
		bool VisualStudioOnly { get; }
		string MouselessModeKey { get; }
	}
}