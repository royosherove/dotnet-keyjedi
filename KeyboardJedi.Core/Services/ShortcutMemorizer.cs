using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace KeyboardJedi.Core.Services
{
	public class ShortcutMemorizer
	{
		public const string HEADER_TEXT = "Shortcuts Recorded in Key Jedi\r\n------------------------------------";
		private readonly Dictionary<string, string> memos = new Dictionary<string, string>();

		public void AddShortCut(string shortcut, string memo)
		{
			memos[shortcut.ToUpper()] = memo;
		}

		public void SetMemosToCliboard()
		{
			Clipboard.SetText(GetMemos());
		}

		private string GetMemos()
		{
			StringBuilder builder = new StringBuilder();
			builder.AppendLine(HEADER_TEXT);
			foreach (KeyValuePair<string, string> pair in memos)
			{
				builder.AppendFormat("{1} : {0}", pair.Key, pair.Value);
				builder.AppendLine();
			}
			return builder.ToString();
		}
	}
}