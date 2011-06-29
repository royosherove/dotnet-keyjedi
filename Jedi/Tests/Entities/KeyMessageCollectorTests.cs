using System.Collections.Generic;
using Jedi.Entities;
using Jedi.ViewModels;
using NUnit.Framework;
using System.Linq;

namespace Tests.Entities
{
	[TestFixture]
	public class KeyMessageCollectorTests
	{
		[Test]
		public void New_collector_has_no_messages()
		{
			Assert.AreEqual(0, new KeyMessageCollector().GetMessagesForDisplay().Count());
		}

		[Test]
		public void Added_messages_are_retained()
		{
			KeyMessageCollector keyMessageCollector = new KeyMessageCollector();
			keyMessageCollector.AddMessage("first");
			keyMessageCollector.AddMessage("second");
			Assert.IsTrue(keyMessageCollector.GetMessagesForDisplay().Any(x=>x.Text == "first"));
			Assert.IsTrue(keyMessageCollector.GetMessagesForDisplay().Any(x => x.Text == "second"));
		}

		[Test]
		public void Messages_have_different_colors()
		{
			KeyMessageCollector keyMessageCollector = new KeyMessageCollector();
			keyMessageCollector.AddMessage("first");
			keyMessageCollector.AddMessage("second");
			KeyViewModel[] keyViewModels = keyMessageCollector.GetMessagesForDisplay().ToArray();
			Assert.AreNotEqual(keyViewModels[0].Color, keyViewModels[1].Color);
		}

		[Test]
		public void No_more_than_10_messages_are_displayed()
		{
			KeyMessageCollector keyMessageCollector = new KeyMessageCollector();
			keyMessageCollector.AddMessage("1");
			keyMessageCollector.AddMessage("2");
			keyMessageCollector.AddMessage("3");
			keyMessageCollector.AddMessage("4");
			keyMessageCollector.AddMessage("5");
			keyMessageCollector.AddMessage("6");
			keyMessageCollector.AddMessage("7");
			keyMessageCollector.AddMessage("8");
			keyMessageCollector.AddMessage("9");
			keyMessageCollector.AddMessage("10");
			keyMessageCollector.AddMessage("11");
			keyMessageCollector.AddMessage("12");
			Assert.AreEqual(10, keyMessageCollector.GetMessagesForDisplay().Count());
		}

		[Test]
		public void Added_messages_go_to_the_front()
		{
			KeyMessageCollector collector = new KeyMessageCollector();
			collector.AddMessage("first");
			KeyViewModel[] messagesForDisplay = collector.GetMessagesForDisplay().ToArray();
			Assert.AreEqual("first", messagesForDisplay[0].Text);
			collector.AddMessage("second");
			messagesForDisplay = collector.GetMessagesForDisplay().ToArray();
			Assert.AreEqual("second", messagesForDisplay[0].Text);
			Assert.AreEqual("first", messagesForDisplay[1].Text);
		}
	}
}