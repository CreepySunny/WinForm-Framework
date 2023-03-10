namespace WinForm_Framework
{
	partial class Main
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panelSideBar = new Panel();
			SuspendLayout();
			// 
			// panelSideBar
			// 
			panelSideBar.BackColor = Color.FromArgb(5, 74, 145);
			panelSideBar.Dock = DockStyle.Left;
			panelSideBar.Location = new Point(0, 0);
			panelSideBar.Name = "panelSideBar";
			panelSideBar.Size = new Size(250, 752);
			panelSideBar.TabIndex = 0;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(129, 164, 205);
			ClientSize = new Size(1312, 752);
			Controls.Add(panelSideBar);
			Name = "Main";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Panel panelSideBar;
	}
}