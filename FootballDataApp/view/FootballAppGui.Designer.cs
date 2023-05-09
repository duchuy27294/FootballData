namespace HuyPham.FootballDataApp.View {
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
			layoutMain = new TableLayoutPanel();
			layoutInfoSearch = new TableLayoutPanel();
			btnSearch = new Button();
			layoutSearchFields = new TableLayoutPanel();
			lblNameSearch = new Label();
			lblLeagueSearch = new Label();
			tbNameSearch = new TextBox();
			tbLeagueSearch = new TextBox();
			lblCountrySearch = new Label();
			tbCountrySearch = new TextBox();
			pbPhoto = new PictureBox();
			tableLayoutPanel1 = new TableLayoutPanel();
			lblName = new Label();
			lblFirstName = new Label();
			lblLastName = new Label();
			lblAge = new Label();
			lblNationality = new Label();
			lblInjured = new Label();
			lblTeam = new Label();
			lblLeague = new Label();
			lblResult = new Label();
			btnPrevious = new Button();
			btnNext = new Button();
			pnResult = new TableLayoutPanel();
			tbName = new TextBox();
			tbFirstName = new TextBox();
			tbLastName = new TextBox();
			tbAge = new TextBox();
			tbNationality = new TextBox();
			tbInjured = new TextBox();
			tbTeam = new TextBox();
			tbLeague = new TextBox();
			pnApiKey.SuspendLayout();
			layoutMain.SuspendLayout();
			layoutInfoSearch.SuspendLayout();
			layoutSearchFields.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbPhoto).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			pnResult.SuspendLayout();
			SuspendLayout();
			// 
			// pnApiKey
			// 
			pnApiKey.Controls.Add(lblApiKey);
			pnApiKey.Controls.Add(tbApiKey);
			pnApiKey.Dock = DockStyle.Top;
			pnApiKey.Location = new Point(0, 0);
			pnApiKey.Name = "pnApiKey";
			pnApiKey.Size = new Size(896, 40);
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
			tbApiKey.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbApiKey.Location = new Point(81, 3);
			tbApiKey.Name = "tbApiKey";
			tbApiKey.Size = new Size(653, 31);
			tbApiKey.TabIndex = 1;
			// 
			// layoutMain
			// 
			layoutMain.ColumnCount = 1;
			layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			layoutMain.Controls.Add(layoutInfoSearch, 0, 0);
			layoutMain.Controls.Add(pbPhoto, 0, 1);
			layoutMain.Controls.Add(tableLayoutPanel1, 0, 2);
			layoutMain.Dock = DockStyle.Fill;
			layoutMain.Location = new Point(0, 40);
			layoutMain.Name = "layoutMain";
			layoutMain.RowCount = 3;
			layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
			layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 175F));
			layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
			layoutMain.Size = new Size(896, 1027);
			layoutMain.TabIndex = 1;
			// 
			// layoutInfoSearch
			// 
			layoutInfoSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			layoutInfoSearch.ColumnCount = 2;
			layoutInfoSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			layoutInfoSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
			layoutInfoSearch.Controls.Add(btnSearch, 1, 0);
			layoutInfoSearch.Controls.Add(layoutSearchFields, 0, 0);
			layoutInfoSearch.Location = new Point(3, 3);
			layoutInfoSearch.Name = "layoutInfoSearch";
			layoutInfoSearch.RowCount = 1;
			layoutInfoSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			layoutInfoSearch.Size = new Size(890, 169);
			layoutInfoSearch.TabIndex = 0;
			// 
			// btnSearch
			// 
			btnSearch.Anchor = AnchorStyles.None;
			btnSearch.Location = new Point(774, 67);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(112, 34);
			btnSearch.TabIndex = 0;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			// 
			// layoutSearchFields
			// 
			layoutSearchFields.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			layoutSearchFields.ColumnCount = 2;
			layoutSearchFields.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
			layoutSearchFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			layoutSearchFields.Controls.Add(lblNameSearch, 0, 0);
			layoutSearchFields.Controls.Add(lblLeagueSearch, 0, 1);
			layoutSearchFields.Controls.Add(tbNameSearch, 1, 0);
			layoutSearchFields.Controls.Add(tbLeagueSearch, 1, 1);
			layoutSearchFields.Controls.Add(lblCountrySearch, 0, 2);
			layoutSearchFields.Controls.Add(tbCountrySearch, 1, 2);
			layoutSearchFields.Location = new Point(3, 3);
			layoutSearchFields.Name = "layoutSearchFields";
			layoutSearchFields.RowCount = 3;
			layoutSearchFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			layoutSearchFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			layoutSearchFields.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
			layoutSearchFields.Size = new Size(764, 163);
			layoutSearchFields.TabIndex = 1;
			// 
			// lblNameSearch
			// 
			lblNameSearch.Anchor = AnchorStyles.Left;
			lblNameSearch.AutoSize = true;
			lblNameSearch.Location = new Point(3, 12);
			lblNameSearch.Name = "lblNameSearch";
			lblNameSearch.Size = new Size(108, 25);
			lblNameSearch.TabIndex = 0;
			lblNameSearch.Text = "Player name";
			lblNameSearch.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblLeagueSearch
			// 
			lblLeagueSearch.Anchor = AnchorStyles.Left;
			lblLeagueSearch.AutoSize = true;
			lblLeagueSearch.Location = new Point(3, 62);
			lblLeagueSearch.Name = "lblLeagueSearch";
			lblLeagueSearch.Size = new Size(68, 25);
			lblLeagueSearch.TabIndex = 1;
			lblLeagueSearch.Text = "League";
			lblLeagueSearch.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// tbNameSearch
			// 
			tbNameSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbNameSearch.Location = new Point(123, 9);
			tbNameSearch.Name = "tbNameSearch";
			tbNameSearch.Size = new Size(638, 31);
			tbNameSearch.TabIndex = 2;
			// 
			// tbLeagueSearch
			// 
			tbLeagueSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbLeagueSearch.Location = new Point(123, 59);
			tbLeagueSearch.Name = "tbLeagueSearch";
			tbLeagueSearch.Size = new Size(638, 31);
			tbLeagueSearch.TabIndex = 3;
			// 
			// lblCountrySearch
			// 
			lblCountrySearch.Anchor = AnchorStyles.Left;
			lblCountrySearch.AutoSize = true;
			lblCountrySearch.Location = new Point(3, 119);
			lblCountrySearch.Name = "lblCountrySearch";
			lblCountrySearch.Size = new Size(75, 25);
			lblCountrySearch.TabIndex = 4;
			lblCountrySearch.Text = "Country";
			lblCountrySearch.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// tbCountrySearch
			// 
			tbCountrySearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbCountrySearch.Location = new Point(123, 116);
			tbCountrySearch.Name = "tbCountrySearch";
			tbCountrySearch.Size = new Size(638, 31);
			tbCountrySearch.TabIndex = 5;
			// 
			// pbPhoto
			// 
			pbPhoto.Anchor = AnchorStyles.None;
			pbPhoto.Location = new Point(373, 187);
			pbPhoto.Name = "pbPhoto";
			pbPhoto.Size = new Size(150, 150);
			pbPhoto.TabIndex = 1;
			pbPhoto.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(lblName, 0, 0);
			tableLayoutPanel1.Controls.Add(lblFirstName, 0, 1);
			tableLayoutPanel1.Controls.Add(lblLastName, 0, 2);
			tableLayoutPanel1.Controls.Add(lblAge, 0, 3);
			tableLayoutPanel1.Controls.Add(lblNationality, 0, 4);
			tableLayoutPanel1.Controls.Add(lblInjured, 0, 5);
			tableLayoutPanel1.Controls.Add(lblTeam, 0, 6);
			tableLayoutPanel1.Controls.Add(lblLeague, 0, 7);
			tableLayoutPanel1.Controls.Add(tbName, 1, 0);
			tableLayoutPanel1.Controls.Add(tbFirstName, 1, 1);
			tableLayoutPanel1.Controls.Add(tbLastName, 1, 2);
			tableLayoutPanel1.Controls.Add(tbAge, 1, 3);
			tableLayoutPanel1.Controls.Add(tbNationality, 1, 4);
			tableLayoutPanel1.Controls.Add(tbInjured, 1, 5);
			tableLayoutPanel1.Controls.Add(tbTeam, 1, 6);
			tableLayoutPanel1.Controls.Add(tbLeague, 1, 7);
			tableLayoutPanel1.Location = new Point(3, 353);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 8;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
			tableLayoutPanel1.Size = new Size(890, 360);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// lblName
			// 
			lblName.Anchor = AnchorStyles.Left;
			lblName.AutoSize = true;
			lblName.Location = new Point(3, 10);
			lblName.Name = "lblName";
			lblName.Size = new Size(59, 25);
			lblName.TabIndex = 0;
			lblName.Text = "Name";
			lblName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblFirstName
			// 
			lblFirstName.Anchor = AnchorStyles.Left;
			lblFirstName.AutoSize = true;
			lblFirstName.Location = new Point(3, 55);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(94, 25);
			lblFirstName.TabIndex = 1;
			lblFirstName.Text = "First name";
			lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblLastName
			// 
			lblLastName.Anchor = AnchorStyles.Left;
			lblLastName.AutoSize = true;
			lblLastName.Location = new Point(3, 100);
			lblLastName.Name = "lblLastName";
			lblLastName.Size = new Size(92, 25);
			lblLastName.TabIndex = 2;
			lblLastName.Text = "Last name";
			lblLastName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblAge
			// 
			lblAge.Anchor = AnchorStyles.Left;
			lblAge.AutoSize = true;
			lblAge.Location = new Point(3, 145);
			lblAge.Name = "lblAge";
			lblAge.Size = new Size(44, 25);
			lblAge.TabIndex = 3;
			lblAge.Text = "Age";
			lblAge.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblNationality
			// 
			lblNationality.Anchor = AnchorStyles.Left;
			lblNationality.AutoSize = true;
			lblNationality.Location = new Point(3, 190);
			lblNationality.Name = "lblNationality";
			lblNationality.Size = new Size(97, 25);
			lblNationality.TabIndex = 4;
			lblNationality.Text = "Nationality";
			lblNationality.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblInjured
			// 
			lblInjured.Anchor = AnchorStyles.Left;
			lblInjured.AutoSize = true;
			lblInjured.Location = new Point(3, 235);
			lblInjured.Name = "lblInjured";
			lblInjured.Size = new Size(67, 25);
			lblInjured.TabIndex = 5;
			lblInjured.Text = "Injured";
			lblInjured.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblTeam
			// 
			lblTeam.Anchor = AnchorStyles.Left;
			lblTeam.AutoSize = true;
			lblTeam.Location = new Point(3, 280);
			lblTeam.Name = "lblTeam";
			lblTeam.Size = new Size(53, 25);
			lblTeam.TabIndex = 6;
			lblTeam.Text = "Team";
			lblTeam.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblLeague
			// 
			lblLeague.Anchor = AnchorStyles.Left;
			lblLeague.AutoSize = true;
			lblLeague.Location = new Point(3, 325);
			lblLeague.Name = "lblLeague";
			lblLeague.Size = new Size(68, 25);
			lblLeague.TabIndex = 7;
			lblLeague.Text = "League";
			lblLeague.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// lblResult
			// 
			lblResult.Anchor = AnchorStyles.Left;
			lblResult.AutoSize = true;
			lblResult.Location = new Point(3, 15);
			lblResult.Name = "lblResult";
			lblResult.Size = new Size(63, 25);
			lblResult.TabIndex = 0;
			lblResult.Text = "Result:";
			lblResult.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// btnPrevious
			// 
			btnPrevious.Anchor = AnchorStyles.None;
			btnPrevious.Location = new Point(630, 11);
			btnPrevious.Name = "btnPrevious";
			btnPrevious.Size = new Size(112, 34);
			btnPrevious.TabIndex = 2;
			btnPrevious.Text = "Previous";
			btnPrevious.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			btnNext.Anchor = AnchorStyles.None;
			btnNext.Location = new Point(770, 11);
			btnNext.Name = "btnNext";
			btnNext.Size = new Size(112, 34);
			btnNext.TabIndex = 3;
			btnNext.Text = "Next";
			btnNext.UseVisualStyleBackColor = true;
			// 
			// pnResult
			// 
			pnResult.ColumnCount = 4;
			pnResult.ColumnStyles.Add(new ColumnStyle());
			pnResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			pnResult.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
			pnResult.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
			pnResult.Controls.Add(lblResult, 0, 0);
			pnResult.Controls.Add(btnPrevious, 2, 0);
			pnResult.Controls.Add(btnNext, 3, 0);
			pnResult.Dock = DockStyle.Bottom;
			pnResult.Location = new Point(0, 1011);
			pnResult.Name = "pnResult";
			pnResult.RowCount = 1;
			pnResult.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			pnResult.Size = new Size(896, 56);
			pnResult.TabIndex = 4;
			// 
			// tbName
			// 
			tbName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbName.Location = new Point(113, 7);
			tbName.Name = "tbName";
			tbName.ReadOnly = true;
			tbName.Size = new Size(774, 31);
			tbName.TabIndex = 8;
			// 
			// tbFirstName
			// 
			tbFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbFirstName.Location = new Point(113, 52);
			tbFirstName.Name = "tbFirstName";
			tbFirstName.ReadOnly = true;
			tbFirstName.Size = new Size(774, 31);
			tbFirstName.TabIndex = 9;
			// 
			// tbLastName
			// 
			tbLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbLastName.Location = new Point(113, 97);
			tbLastName.Name = "tbLastName";
			tbLastName.ReadOnly = true;
			tbLastName.Size = new Size(774, 31);
			tbLastName.TabIndex = 10;
			// 
			// tbAge
			// 
			tbAge.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbAge.Location = new Point(113, 142);
			tbAge.Name = "tbAge";
			tbAge.ReadOnly = true;
			tbAge.Size = new Size(774, 31);
			tbAge.TabIndex = 11;
			// 
			// tbNationality
			// 
			tbNationality.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbNationality.Location = new Point(113, 187);
			tbNationality.Name = "tbNationality";
			tbNationality.ReadOnly = true;
			tbNationality.Size = new Size(774, 31);
			tbNationality.TabIndex = 12;
			// 
			// tbInjured
			// 
			tbInjured.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbInjured.Location = new Point(113, 232);
			tbInjured.Name = "tbInjured";
			tbInjured.ReadOnly = true;
			tbInjured.Size = new Size(774, 31);
			tbInjured.TabIndex = 13;
			// 
			// tbTeam
			// 
			tbTeam.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbTeam.Location = new Point(113, 277);
			tbTeam.Name = "tbTeam";
			tbTeam.ReadOnly = true;
			tbTeam.Size = new Size(774, 31);
			tbTeam.TabIndex = 14;
			// 
			// tbLeague
			// 
			tbLeague.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			tbLeague.Location = new Point(113, 322);
			tbLeague.Name = "tbLeague";
			tbLeague.ReadOnly = true;
			tbLeague.Size = new Size(774, 31);
			tbLeague.TabIndex = 15;
			// 
			// FootballAppGui
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(896, 1067);
			Controls.Add(pnResult);
			Controls.Add(layoutMain);
			Controls.Add(pnApiKey);
			Name = "FootballAppGui";
			Text = "Football Data";
			pnApiKey.ResumeLayout(false);
			pnApiKey.PerformLayout();
			layoutMain.ResumeLayout(false);
			layoutInfoSearch.ResumeLayout(false);
			layoutSearchFields.ResumeLayout(false);
			layoutSearchFields.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbPhoto).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			pnResult.ResumeLayout(false);
			pnResult.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel pnApiKey;
		private Label lblApiKey;
		private TextBox tbApiKey;
		private TableLayoutPanel layoutMain;
		private TableLayoutPanel layoutInfoSearch;
		private Button btnSearch;
		private TableLayoutPanel layoutSearchFields;
		private Label lblNameSearch;
		private Label lblLeagueSearch;
		private TextBox tbNameSearch;
		private TextBox tbLeagueSearch;
		private PictureBox pbPhoto;
		private Label lblCountrySearch;
		private TextBox tbCountrySearch;
		private TableLayoutPanel tableLayoutPanel1;
		private Label lblName;
		private Label lblFirstName;
		private Label lblLastName;
		private Label lblAge;
		private Label lblNationality;
		private Label lblInjured;
		private Label lblTeam;
		private Label lblLeague;
		private Label lblResult;
		private Button btnPrevious;
		private Button btnNext;
		private TableLayoutPanel pnResult;
		private TextBox tbName;
		private TextBox tbFirstName;
		private TextBox tbLastName;
		private TextBox tbAge;
		private TextBox tbNationality;
		private TextBox tbInjured;
		private TextBox tbTeam;
		private TextBox tbLeague;

		public Label LblApiKey { get => lblApiKey; }
		public TextBox TbApiKey { get => tbApiKey; }
		public Button BtnSearch { get => btnSearch; }
		public Label LblNameSearch { get => lblNameSearch; }
		public Label LblLeagueSearch { get => lblLeagueSearch; }
		public TextBox TbNameSearch { get => tbNameSearch; }
		public TextBox TbLeagueSearch { get => tbLeagueSearch; }
		public PictureBox PbPhoto { get => pbPhoto; set => pbPhoto = value; }
		public Label LblCountrySearch { get => lblCountrySearch; }
		public TextBox TbCountrySearch { get => tbCountrySearch; }
		public Label LblName { get => lblName; set => lblName = value; }
		public Label LblFirstName { get => lblFirstName; }
		public Label LblLastName { get => lblLastName; }
		public Label LblAge { get => lblAge; }
		public Label LblNationality { get => lblNationality; }
		public Label LblInjured { get => lblInjured; }
		public Label LblTeam { get => lblTeam; }
		public Label LblLeague { get => lblLeague; }
		public Label LblResult { get => lblResult; }
		public Button BtnPrevious { get => btnPrevious; }
		public Button BtnNext { get => btnNext; }
		public TextBox TbName { get => tbName; }
		public TextBox TbFirstName { get => tbFirstName; }
		public TextBox TbLastName { get => tbLastName; }
		public TextBox TbAge { get => tbAge; set => tbAge = value; }
		public TextBox TbNationality { get => tbNationality; }
		public TextBox TbInjured { get => tbInjured; }
		public TextBox TbTeam { get => tbTeam; }
		public TextBox TbLeague { get => tbLeague; }
	}
}