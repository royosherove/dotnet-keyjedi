using System.Linq;
using KeyboardJedi.Core.Entities;
using KeyboardJedi.Core.Services;
using KeyboardJedi.Core.Views;

namespace KeyboardJedi.Core.Presenters
{
	public class MainFormPresenter
	{
		private const string MOUSELESS_MODE_INSTRUCTIONS =
			"Mouseless Mode on [{0}].\n Press Ctrl+Alt+Shift+F12 to regain mouse control.";

		private readonly KeyMessageCollector keyMessageCollector = new KeyMessageCollector();

		private readonly string mouselessModeKey;

		private readonly IJediSettings settings;
		private readonly IMainFormView view;
		private MouseDisabler disabler;
		private string[] mouselessModeKeyParts;

		public MainFormPresenter(IMainFormView view, IJediSettings settings)
		{
			this.view = view;
			this.settings = settings;
			mouselessModeKey = settings.MouselessModeKey;
		}

		public void HandleLoad()
		{
			DisplayKeys();
			view.SetOpacity(settings.Opacity);
			view.SetFont(settings.Font);
			view.Refresh();
			SetAppTitle();
		}

		public void HandleMouselessModeClick()
		{
			ToggleMouselessMode();
		}

		public void HandleOpacityTrackBarChange()
		{
			view.SetOpacity(view.GetTrackBarPosition() / 100f);
		}

		public void HandleShortcut(string msg)
		{
			if (IsMsgMouselessModeKey(msg))
			{
				ToggleMouselessMode();
			}
			keyMessageCollector.AddMessage(msg);
			DisplayKeys();
		}

		private void DisplayKeys()
		{
			view.DisplayKeys(keyMessageCollector.GetMessagesForDisplay());
		}

		private bool IsMsgMouselessModeKey(string msg)
		{
			if (mouselessModeKey == string.Empty)
			{
				return false;
			}
			if (mouselessModeKeyParts == null)
			{
				mouselessModeKeyParts = mouselessModeKey.Split(new[] {'+'});
				if (mouselessModeKey.EndsWith("+"))
				{
					mouselessModeKeyParts[mouselessModeKeyParts.Length - 1] = "+";
				}
			}
			return mouselessModeKeyParts.All(msg.Contains);
		}

		private void SetAppTitle()
		{
			view.HideMouselessModeInstructions();
			string title = @"Keyboard Jedi";
			if (settings.VisualStudioOnly)
			{
				title = title + @" (VS Only)";
			}
			if (disabler != null)
			{
				title = @"Mouseless Mode";
				string instructions = string.Format(MOUSELESS_MODE_INSTRUCTIONS, disabler.AppTitle);
				view.DisplayMouselessModeInstructions(instructions);
			}
			view.DisplayTitle(title);
		}

		private void ToggleMouselessMode()
		{
			if (disabler != null)
			{
				disabler.Stop();
				disabler = null;
				view.HideMouselessModeMenuOption();
			}
			else
			{
				disabler = new MouseDisabler(view);
				disabler.Start();
				view.DisplayMouselessModeMenuOptions();
			}
			SetAppTitle();
		}
	}
}