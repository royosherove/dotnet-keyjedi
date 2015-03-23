using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Jedi;
using Jedi.Presenters;
using Jedi.Services;
using Jedi.ViewModels;
using Jedi.Views;
using JediUI.Properties;
using Kennedy.ManagedHooks;

namespace JediUI
{
	public partial class MainForm : Form, IMainFormView
	{
		private readonly ShortcutMemorizer memos = new ShortcutMemorizer();
		private readonly KeyStateManager mgr = new KeyStateManager();
		private readonly MainFormPresenter presenter;
		private KeyboardHook keyboardHook;
		private MouseHook mouseHook;

		public MainForm()
		{
			InitializeComponent();
			AllowTransparency = true;
			presenter = new MainFormPresenter(this, new JediSettings());

			mouseHook = new MouseHook();
			mouseHook.MouseEvent += MouseHookMouseEvent;
			keyboardHook = new KeyboardHook();
			keyboardHook.KeyboardEvent += KeyboardHookKeyboardEvent;
			mgr.ShortcutActivated += mgr_OnShortcutActivated;
			keyboardHook.InstallHook();

            if (Settings.Default.CleanLogfile && !string.IsNullOrEmpty(Settings.Default.Logfile))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Settings.Default.Logfile))
                {
                    file.Write("");
                }
            }
		}

		public void DisplayKeys(IEnumerable<KeyViewModel> keys)
		{
			KeysListView.Items.Clear();
			foreach (var key in keys)
			{
				ListViewItem listViewItem = KeysListView.Items.Add(key.Text);
				listViewItem.ForeColor = key.Color;
			}
			KeysListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		public void SetFont(Font font)
		{
			KeysListView.Font = font;
		}

		public void HideMouselessModeInstructions()
		{
			label1.Visible = false;
		}

		public void DisplayMouselessModeInstructions(string instructions)
		{
			label1.Text = instructions;
			label1.Visible = true;
		}

		public void DisplayTitle(string title)
		{
			Text = title;
		}

		public void HideMouselessModeMenuOption()
		{
			mouselessModeOnOffToolStripMenuItem.Visible = false;
		}

		public void DisplayMouselessModeMenuOptions()
		{
			mouselessModeOnOffToolStripMenuItem.Visible = true;
		}

		public void SetOpacity(double opacity)
		{
			Opacity = opacity;
		}

		public int GetTrackBarPosition()
		{
			return OpacityTrackBar.Value;
		}

		private void AddText(string message)
		{
			if (Focused || (message == null))
			{
				return;
			}

			KeysListView.Items.Insert(0, message);
			if (KeysListView.Items.Count > 1)
			{
				ListViewItem item = KeysListView.Items[1];
				item.ForeColor = Color.Gray;
			}
			if (KeysListView.Items.Count > 5)
			{
				ListViewItem item2 = KeysListView.Items[5];
				item2.ForeColor = Color.LightGray;
			}
			if (KeysListView.Items.Count > 10)
			{
				KeysListView.Items[10].Remove();
			}
			KeysListView.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		private void CopyAllMemosToClipboardToolStripMenuItemClick(object sender, EventArgs e)
		{
			memos.SetMemosToCliboard();
		}


		private void KeyboardHookKeyboardEvent(KeyboardEvents kEvent, Keys key)
		{
			mgr.Input(kEvent, key);
		}

		private void ListView1DoubleClick(object sender, EventArgs e)
		{
			SetMemoOnSelectedItem();
		}

		private void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default["Opacity"] = Opacity;
			Settings.Default.Save();
			Settings.Default.Upgrade();

			if (mouseHook != null)
			{
				mouseHook.Dispose();
				mouseHook = null;
			}
			if (keyboardHook != null)
			{
				keyboardHook.Dispose();
				keyboardHook = null;
			}
		}

		private void MainFormLoad(object sender, EventArgs e)
		{
			presenter.HandleLoad();
		}

		private void MouseHookMouseEvent(MouseEvents mEvent, Point point)
		{
			string message = string.Format("Mouse event: {0}: ({1},{2}).", mEvent, point.X, point.Y);
			AddText(message);
		}

		private void MouselessModeOnOffToolStripMenuItemClick(object sender, EventArgs e)
		{
			presenter.HandleMouselessModeClick();
		}

		private void SetMemoOnSelectedItem()
		{
			if (KeysListView.SelectedItems.Count != 0)
			{
				ListViewItem item = KeysListView.SelectedItems[0];
				TopMost = false;

				const string title = "Enter a memo to associate with this shortcut";
				const string promptText = "Memo for shortcut";

				string memo = Interaction.InputBox(title, promptText, "Action triggerd by " + item.Text);
				//, new Point(Location.X, Location.Y));
				TopMost = true;

				if (memo != string.Empty)
				{
					memos.AddShortCut(item.Text, memo);
				}
			}
		}

		private void SetMemoOnThisItemToolStripMenuItemClick(object sender, EventArgs e)
		{
			SetMemoOnSelectedItem();
		}

		private void OpacityTrackBarScroll(object sender, EventArgs e)
		{
			presenter.HandleOpacityTrackBarChange();
		}

		private void mgr_OnShortcutActivated(string msg)
		{
			presenter.HandleShortcut(msg);
		}
	}
}