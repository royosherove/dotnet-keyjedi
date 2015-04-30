using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Jedi.Entities
{
	public static class KeyExtensions
	{
		private static readonly List<Keys> comboKeys =
			new List<Keys>
				{
					Keys.Control,
					Keys.ControlKey,
					Keys.Alt,
					Keys.Shift,
					Keys.ShiftKey,
					Keys.LWin,
					Keys.RWin
				};

		private static readonly Dictionary<Keys, string> displayNames =
			new Dictionary<Keys, string>
				{
					{Keys.D0, "0"},
					{Keys.D1, "1"},
					{Keys.D2, "2"},
					{Keys.D3, "3"},
					{Keys.D4, "4"},
					{Keys.D5, "5"},
					{Keys.D6, "6"},
					{Keys.D7, "7"},
					{Keys.D8, "8"},
					{Keys.D9, "9"},
					{Keys.LWin, "Winkey"},
					{Keys.RWin, "Winkey"},
					{Keys.NumPad0, "Num0"},
					{Keys.NumPad1, "Num1"},
					{Keys.NumPad2, "Num2"},
					{Keys.NumPad3, "Num3"},
					{Keys.NumPad4, "Num4"},
					{Keys.NumPad5, "Num5"},
					{Keys.NumPad6, "Num6"},
					{Keys.NumPad7, "Num7"},
					{Keys.NumPad8, "Num8"},
					{Keys.NumPad9, "Num9"},
					{Keys.OemSemicolon, ";"},
					{Keys.Oemplus, "+"},
					{Keys.Oemcomma, ","},
					{Keys.OemMinus, "-"},
					{Keys.OemPeriod, "."},
					{Keys.OemQuestion, "?"},
					{Keys.Oemtilde, "'"},
					{Keys.OemOpenBrackets, "["},
					{Keys.OemPipe, "/"},
					{Keys.OemCloseBrackets, "]"},
					{Keys.OemQuotes, "'"},
					{Keys.OemBackslash, @"\"},
					{Keys.Control, "Ctrl"}
				};

		private static readonly List<Keys> specialSingleKeys =
			new List<Keys>
				{
					Keys.F1,
					Keys.F2,
					Keys.F3,
					Keys.F4,
					Keys.F5,
					Keys.F6,
					Keys.F7,
					Keys.F8,
					Keys.F9,
					Keys.F10,
					Keys.F11,
					Keys.F12
				};

		public static void AddToSpecialSingleKeys(this Keys keys)
		{
			specialSingleKeys.Add(keys);
		}

		public static string DisplayName(this Keys keys)
		{
			if (displayNames.ContainsKey(keys))
			{
				return displayNames[keys];
			}
			return keys.ToString();
		}

		public static bool IsComboKey(this Keys currentKey)
		{
			return comboKeys.Any(x => x == currentKey);
		}

		public static bool IsSpecialSingleKey(this Keys keys)
		{
			return specialSingleKeys.Any(x => x == keys);
		}
	}
}