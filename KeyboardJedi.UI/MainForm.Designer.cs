using KeyboardJedi.Core.Views;

namespace KeyboardJedi.UI
{
    partial class MainForm : IMainFormView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.OpacityTrackBar = new System.Windows.Forms.TrackBar();
			this.mnuList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.setMemoOnThisItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAllMemosToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mouselessModeOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.KeysListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.OpacityTrackBar)).BeginInit();
			this.mnuList.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Yellow;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 52);
			this.label1.TabIndex = 3;
			this.label1.Text = "Press Ctrl-Shift-Alt-F12 to stop Mousless Mode";
			// 
			// trackBar1
			// 
			this.OpacityTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OpacityTrackBar.BackColor = System.Drawing.Color.White;
			this.OpacityTrackBar.LargeChange = 10;
			this.OpacityTrackBar.Location = new System.Drawing.Point(0, 210);
			this.OpacityTrackBar.Maximum = 100;
			this.OpacityTrackBar.Minimum = 10;
			this.OpacityTrackBar.Name = "OpacityTrackBar";
			this.OpacityTrackBar.Size = new System.Drawing.Size(276, 45);
			this.OpacityTrackBar.SmallChange = 5;
			this.OpacityTrackBar.TabIndex = 1;
			this.OpacityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.OpacityTrackBar.Value = 50;
			this.OpacityTrackBar.Scroll += new System.EventHandler(this.OpacityTrackBarScroll);
			// 
			// mnuList
			// 
			this.mnuList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setMemoOnThisItemToolStripMenuItem,
            this.copyAllMemosToClipboardToolStripMenuItem,
            this.mouselessModeOnOffToolStripMenuItem,
            this.toolStripSeparator1,
            this.eToolStripMenuItem});
			this.mnuList.Name = "mnuList";
			this.mnuList.Size = new System.Drawing.Size(228, 98);
			// 
			// setMemoOnThisItemToolStripMenuItem
			// 
			this.setMemoOnThisItemToolStripMenuItem.Name = "setMemoOnThisItemToolStripMenuItem";
			this.setMemoOnThisItemToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.setMemoOnThisItemToolStripMenuItem.Text = "Set Memo on this item";
			this.setMemoOnThisItemToolStripMenuItem.Click += new System.EventHandler(this.SetMemoOnThisItemToolStripMenuItemClick);
			// 
			// copyAllMemosToClipboardToolStripMenuItem
			// 
			this.copyAllMemosToClipboardToolStripMenuItem.Name = "copyAllMemosToClipboardToolStripMenuItem";
			this.copyAllMemosToClipboardToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.copyAllMemosToClipboardToolStripMenuItem.Text = "Copy all memos to clipboard";
			this.copyAllMemosToClipboardToolStripMenuItem.Click += new System.EventHandler(this.CopyAllMemosToClipboardToolStripMenuItemClick);
			// 
			// mouselessModeOnOffToolStripMenuItem
			// 
			this.mouselessModeOnOffToolStripMenuItem.Name = "mouselessModeOnOffToolStripMenuItem";
			this.mouselessModeOnOffToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.mouselessModeOnOffToolStripMenuItem.Text = "Mouseless Mode On/Off";
			this.mouselessModeOnOffToolStripMenuItem.Click += new System.EventHandler(this.MouselessModeOnOffToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
			// 
			// eToolStripMenuItem
			// 
			this.eToolStripMenuItem.Name = "eToolStripMenuItem";
			this.eToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.eToolStripMenuItem.Text = "&Exit";
			// 
			// KeysListView
			// 
			this.KeysListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.KeysListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KeysListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.KeysListView.ContextMenuStrip = this.mnuList;
			this.KeysListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.KeysListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.KeysListView.Location = new System.Drawing.Point(0, 0);
			this.KeysListView.MultiSelect = false;
			this.KeysListView.Name = "KeysListView";
			this.KeysListView.Scrollable = false;
			this.KeysListView.ShowGroups = false;
			this.KeysListView.Size = new System.Drawing.Size(275, 236);
			this.KeysListView.TabIndex = 0;
			this.KeysListView.UseCompatibleStateImageBehavior = false;
			this.KeysListView.View = System.Windows.Forms.View.Details;
			this.KeysListView.DoubleClick += new System.EventHandler(this.ListView1DoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(275, 236);
			this.Controls.Add(this.OpacityTrackBar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.KeysListView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Keyboard Jedi";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.OpacityTrackBar)).EndInit();
			this.mnuList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar OpacityTrackBar;
        private System.Windows.Forms.ToolStripMenuItem setMemoOnThisItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllMemosToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mouselessModeOnOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ListView KeysListView;
        public System.Windows.Forms.ContextMenuStrip mnuList;

    }
}

