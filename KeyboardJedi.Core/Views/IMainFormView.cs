using System.Collections.Generic;
using System.Drawing;
using Jedi.ViewModels;

namespace Jedi.Views
{
	public interface IMainFormView
	{
		Rectangle Bounds { get; }
		Point Location { get; }
		void DisplayKeys(IEnumerable<KeyViewModel> keys);
		void DisplayMouselessModeInstructions(string instructions);
		void DisplayMouselessModeMenuOptions();
		void DisplayTitle(string title);
		void HideMouselessModeInstructions();
		void HideMouselessModeMenuOption();
		void Refresh();
		void SetFont(Font font);
		void SetOpacity(double opacity);
		int GetTrackBarPosition();
	}
}