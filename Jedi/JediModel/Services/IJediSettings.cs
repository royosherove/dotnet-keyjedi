using System.Drawing;

namespace Jedi.Services
{
	public interface IJediSettings
	{
		double Opacity { get; }
		Font Font { get; }
		bool VisualStudioOnly { get; }
		string MouselessModeKey { get; }
	}
}