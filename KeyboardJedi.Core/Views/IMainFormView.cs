using System.Collections.Generic;
using System.Drawing;
using KeyboardJedi.Core.ViewModels;

namespace KeyboardJedi.Core.Views
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