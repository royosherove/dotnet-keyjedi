using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jedi;
using Jedi.Entities;
using Jedi.Services;
using JediUI.Properties;
using Kennedy.ManagedHooks;

namespace JediUI
{
	public class KeyStateManager
	{
		private readonly Dictionary<Keys, bool> keyStates = new Dictionary<Keys, bool>();

		private readonly bool visualStudioOnly = Settings.Default.VisualStudioOnly;
		private bool isSystemKeyDown;

		public delegate void ShorcutDelegate(string msg);

		public KeyStateManager()
		{
			InitializeConfigurableSpecialSingleKeys();
		}

		public void Input(KeyboardEvents kEvents, Keys currentKey)
		{
			if (visualStudioOnly && !NativeHelpers.ActiveApplTitle().Contains("Microsoft Visual Studio"))
			{
				return;
			}

			if (((kEvents == KeyboardEvents.SystemKeyDown) || (kEvents == KeyboardEvents.KeyDown)) &&
			    currentKey.IsComboKey())
			{
				keyStates[currentKey] = true;
				isSystemKeyDown = true;
			}
			if (((kEvents == KeyboardEvents.SystemKeyUp) || (kEvents == KeyboardEvents.KeyUp)) &&
			    currentKey.IsComboKey())
			{
				keyStates[currentKey] = false;
				isSystemKeyDown = AreAllSystemKeysDown(keyStates);
			}
			if (((kEvents == KeyboardEvents.SystemKeyDown) || (kEvents == KeyboardEvents.KeyDown)) &&
			    (!currentKey.IsComboKey() && isSystemKeyDown))
			{
				ShortcutActivated(BuildKeyMessage(keyStates, currentKey));
			}
			else if ((kEvents == KeyboardEvents.KeyDown) && currentKey.IsSpecialSingleKey())
			{
				ShortcutActivated(BuildKeyMessage(keyStates, currentKey));
			}
		}

		public event ShorcutDelegate ShortcutActivated;

		private bool AreAllSystemKeysDown(Dictionary<Keys, bool> states)
		{
			return states.Any(pair => pair.Value);
		}

		private string BuildKeyMessage(Dictionary<Keys, bool> states, Keys key)
		{
			StringBuilder builder = new StringBuilder();
			foreach (KeyValuePair<Keys, bool> pair in states)
			{
				if (pair.Value)
				{
					builder.Append(pair.Key.DisplayName());
					builder.Append("+");
				}
			}
			builder.Append(key.DisplayName());
			return builder.ToString();
		}

		private void InitializeConfigurableSpecialSingleKeys()
		{
			if (Settings.Default.ShowTabs)
			{
				Keys.Tab.AddToSpecialSingleKeys();
			}
			if (Settings.Default.ShowEnter)
			{
				Keys.Return.AddToSpecialSingleKeys();
				Keys.Enter.AddToSpecialSingleKeys();
			}
			if (Settings.Default.ShowPageUpDown)
			{
				Keys.Next.AddToSpecialSingleKeys();
				Keys.Prior.AddToSpecialSingleKeys();
			}
		}
	}
}