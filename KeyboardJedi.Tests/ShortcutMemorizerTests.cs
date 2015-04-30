using System.Windows.Forms;
using KeyboardJedi.Core.Services;
using NUnit.Framework;

namespace KeyboardJedi.Tests
{
	[TestFixture]
	public class ShortcutMemorizerTests
	{
		[Test]
		public void Added_messages_are_copied_to_the_clipboard_on_demand()
		{
			ShortcutMemorizer shortcutMemorizer = new ShortcutMemorizer();
			Clipboard.Clear();
			Assert.IsFalse(Clipboard.ContainsText());
			shortcutMemorizer.SetMemosToCliboard();
			Assert.IsTrue(Clipboard.ContainsText());
		}

		[Test]
		public void Clipboard_contains_header_text()
		{
			ShortcutMemorizer shortcutMemorizer = new ShortcutMemorizer();
			shortcutMemorizer.SetMemosToCliboard();
			string text = Clipboard.GetText();
			Assert.IsTrue(text.StartsWith(ShortcutMemorizer.HEADER_TEXT));
		}

		[Test]
		public void Clipboard_contains_memo()
		{
			ShortcutMemorizer shortcutMemorizer = new ShortcutMemorizer();
			shortcutMemorizer.AddShortCut("123", "memo 123");
			shortcutMemorizer.SetMemosToCliboard();
			string text = Clipboard.GetText();
			Assert.IsTrue(text.Contains("memo 123 : 123"));
		}
	}
}