using System.Windows.Forms;
using Jedi.Entities;
using NUnit.Framework;

namespace Tests.Entities
{
	[TestFixture]
	public class KeyExtensionsTests
	{
		[TestCase(Keys.Control)]
		[TestCase(Keys.ControlKey)]
		[TestCase(Keys.Alt)]
		[TestCase(Keys.Shift)]
		[TestCase(Keys.ShiftKey)]
		[TestCase(Keys.LWin)]
		[TestCase(Keys.RWin)]
		public void ControlKeys_are_ComboKeys(Keys keys)
		{
			Assert.IsTrue(keys.IsComboKey());
		}

		[Test]
		public void DisplayName_returns_ToString_value_for_Key_without_specified_DisplayName()
		{
			Assert.AreEqual(Keys.Apps.ToString(), Keys.Apps.DisplayName());
		}

		[Test]
		public void DisplayName_returns_correct_value_for_Key_with_specified_DisplayName()
		{
			Assert.AreEqual("Winkey", Keys.LWin.DisplayName());
		}

		[TestCase(Keys.F1)]
		[TestCase(Keys.F2)]
		[TestCase(Keys.F3)]
		[TestCase(Keys.F4)]
		[TestCase(Keys.F5)]
		[TestCase(Keys.F6)]
		[TestCase(Keys.F7)]
		[TestCase(Keys.F8)]
		[TestCase(Keys.F9)]
		[TestCase(Keys.F10)]
		[TestCase(Keys.F11)]
		[TestCase(Keys.F12)]
		public void FunctionKeys_are_SpecialSingleKeys(Keys keys)
		{
			Assert.IsTrue(keys.IsSpecialSingleKey());
		}

		[Test]
		public void SpecialSingleKeys_can_be_added()
		{
			Assert.IsFalse(Keys.PageUp.IsSpecialSingleKey());
			Keys.PageUp.AddToSpecialSingleKeys();
			Assert.IsTrue(Keys.PageUp.IsSpecialSingleKey());
		}
	}
}