using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using KeyboardJedi.Core.ViewModels;

namespace KeyboardJedi.Core.Entities
{
	public class KeyMessageCollector
	{
		private readonly List<string> keys = new List<string>();

		private readonly Dictionary<int, string> positionColors =
			new Dictionary<int, string>
				{
					{0, "#000000"},
//					{-1, "#151515"}, //Skip these 3 colors
//					{-2, "#2A2A2A"}, //to make the most recent
//					{-3, "#3F3F3F"}, //element stand out more
					{1, "#555555"},
					{2, "#6A6A6A"},
					{3, "#7F7F7F"},
					{4, "#949494"},
					{5, "#AAAAAA"},
					{6, "#BFBFBF"},
					{7, "#D4D4D4"},
					{8, "#E9E9E9"},
					{9, "#E9E9E9"}
				};

		public void AddMessage(string message)
		{
			keys.Insert(0, message);
			while (keys.Count > 10)
			{
				keys.RemoveAt(10);
			}
		}

		public IEnumerable<KeyViewModel> GetMessagesForDisplay()
		{
			return keys.Select((t, i) => new KeyViewModel
			                             	{
			                             		Text = t,
			                             		Color = ColorTranslator.FromHtml(positionColors[i])
			                             	});
		}
	}
}