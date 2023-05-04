namespace FootballDataApp {
	partial class FootballAppGui {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			pnApiKey = new FlowLayoutPanel();
			lblApiKey = new Label();
			tbApiKey = new TextBox();
			pnApiKey.SuspendLayout();
			SuspendLayout();
			// 
			// pnApiKey
			// 
			pnApiKey.Controls.Add(lblApiKey);
			pnApiKey.Controls.Add(tbApiKey);
			pnApiKey.Dock = DockStyle.Top;
			pnApiKey.Location = new Point(0, 0);
			pnApiKey.Name = "pnApiKey";
			pnApiKey.Size = new Size(800, 40);
			pnApiKey.TabIndex = 0;
			// 
			// lblApiKey
			// 
			lblApiKey.Anchor = AnchorStyles.Left;
			lblApiKey.AutoSize = true;
			lblApiKey.Location = new Point(3, 6);
			lblApiKey.Name = "lblApiKey";
			lblApiKey.Size = new Size(72, 25);
			lblApiKey.TabIndex = 0;
			lblApiKey.Text = "API Key";
			lblApiKey.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// tbApiKey
			// 
			tbApiKey.Anchor = AnchorStyles.Right;
			tbApiKey.Location = new Point(81, 3);
			tbApiKey.Name = "tbApiKey";
			tbApiKey.Size = new Size(653, 31);
			tbApiKey.TabIndex = 1;
			// 
			// FootballAppGui
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pnApiKey);
			Name = "FootballAppGui";
			Text = "Football Data";
			pnApiKey.ResumeLayout(false);
			pnApiKey.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel pnApiKey;
		private Label lblApiKey;
		private TextBox tbApiKey;
	}
}