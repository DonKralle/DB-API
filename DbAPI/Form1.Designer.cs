namespace DbAPI
{
	partial class Form1
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
			this.Search = new System.Windows.Forms.Button();
			this.StationBox = new System.Windows.Forms.ComboBox();
			this.UhrzeitBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.abfahrtBox = new System.Windows.Forms.CheckBox();
			this.Ankunft = new System.Windows.Forms.CheckBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.anzeige = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Search
			// 
			this.Search.Location = new System.Drawing.Point(537, 406);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(88, 29);
			this.Search.TabIndex = 0;
			this.Search.Text = "Suchen";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// StationBox
			// 
			this.StationBox.FormattingEnabled = true;
			this.StationBox.Location = new System.Drawing.Point(198, 70);
			this.StationBox.Name = "StationBox";
			this.StationBox.Size = new System.Drawing.Size(138, 21);
			this.StationBox.TabIndex = 1;
			// 
			// UhrzeitBox
			// 
			this.UhrzeitBox.FormattingEnabled = true;
			this.UhrzeitBox.Items.AddRange(new object[] {
			"00 Uhr",
			"01 Uhr",
			"02 Uhr",
			"03 Uhr",
			"04 Uhr",
			"05 Uhr",
			"06 Uhr",
			"07 Uhr",
			"08 Uhr",
			"09 Uhr",
			"10 Uhr",
			"11 Uhr",
			"12 Uhr",
			"13 Uhr",
			"14 Uhr",
			"15 Uhr",
			"16 Uhr",
			"17 Uhr",
			"18 Uhr",
			"19 Uhr",
			"20 Uhr",
			"21 Uhr",
			"22 Uhr",
			"23 Uhr"});
			this.UhrzeitBox.Location = new System.Drawing.Point(480, 70);
			this.UhrzeitBox.Name = "UhrzeitBox";
			this.UhrzeitBox.Size = new System.Drawing.Size(81, 21);
			this.UhrzeitBox.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(505, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Uhrzeit";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(237, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Station";
			// 
			// abfahrtBox
			// 
			this.abfahrtBox.AutoSize = true;
			this.abfahrtBox.Location = new System.Drawing.Point(12, 70);
			this.abfahrtBox.Name = "abfahrtBox";
			this.abfahrtBox.Size = new System.Drawing.Size(60, 17);
			this.abfahrtBox.TabIndex = 5;
			this.abfahrtBox.Text = "Abfahrt";
			this.abfahrtBox.UseVisualStyleBackColor = true;
			// 
			// Ankunft
			// 
			this.Ankunft.AutoSize = true;
			this.Ankunft.Location = new System.Drawing.Point(92, 70);
			this.Ankunft.Name = "Ankunft";
			this.Ankunft.Size = new System.Drawing.Size(63, 17);
			this.Ankunft.TabIndex = 6;
			this.Ankunft.Text = "Ankunft";
			this.Ankunft.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(369, 70);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(105, 20);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(394, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Datum";
			// 
			// anzeige
			// 
			this.anzeige.FormattingEnabled = true;
			this.anzeige.Location = new System.Drawing.Point(12, 117);
			this.anzeige.Name = "anzeige";
			this.anzeige.Size = new System.Drawing.Size(622, 277);
			this.anzeige.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 447);
			this.Controls.Add(this.anzeige);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.Ankunft);
			this.Controls.Add(this.abfahrtBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UhrzeitBox);
			this.Controls.Add(this.StationBox);
			this.Controls.Add(this.Search);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.ComboBox StationBox;
		private System.Windows.Forms.ComboBox UhrzeitBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox abfahrtBox;
		private System.Windows.Forms.CheckBox Ankunft;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox anzeige;
	}
}

