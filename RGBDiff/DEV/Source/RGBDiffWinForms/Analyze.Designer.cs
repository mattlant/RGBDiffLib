namespace RGBDiffWinForms
{
	partial class Analyze
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
			this.txtSetCount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkClose = new System.Windows.Forms.CheckBox();
			this.cmbSets = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.chkFar = new System.Windows.Forms.CheckBox();
			this.dgvSetEntries = new System.Windows.Forms.DataGridView();
			this.txtGotoTesting = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSetEntries)).BeginInit();
			this.SuspendLayout();
			// 
			// txtSetCount
			// 
			this.txtSetCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtSetCount.Location = new System.Drawing.Point(53, 468);
			this.txtSetCount.Name = "txtSetCount";
			this.txtSetCount.Size = new System.Drawing.Size(100, 20);
			this.txtSetCount.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Observer Set #";
			// 
			// chkClose
			// 
			this.chkClose.AutoSize = true;
			this.chkClose.Location = new System.Drawing.Point(205, 15);
			this.chkClose.Name = "chkClose";
			this.chkClose.Size = new System.Drawing.Size(139, 17);
			this.chkClose.TabIndex = 2;
			this.chkClose.Text = "Show Too Close Entries";
			this.chkClose.UseVisualStyleBackColor = true;
			// 
			// cmbSets
			// 
			this.cmbSets.FormattingEnabled = true;
			this.cmbSets.Location = new System.Drawing.Point(126, 12);
			this.cmbSets.Name = "cmbSets";
			this.cmbSets.Size = new System.Drawing.Size(73, 21);
			this.cmbSets.TabIndex = 3;
			this.cmbSets.SelectedIndexChanged += new System.EventHandler(this.cmbSets_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 471);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Count";
			// 
			// chkFar
			// 
			this.chkFar.AutoSize = true;
			this.chkFar.Location = new System.Drawing.Point(350, 14);
			this.chkFar.Name = "chkFar";
			this.chkFar.Size = new System.Drawing.Size(128, 17);
			this.chkFar.TabIndex = 5;
			this.chkFar.Text = "Show Too Far Entries";
			this.chkFar.UseVisualStyleBackColor = true;
			// 
			// dgvSetEntries
			// 
			this.dgvSetEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSetEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSetEntries.Location = new System.Drawing.Point(12, 37);
			this.dgvSetEntries.Name = "dgvSetEntries";
			this.dgvSetEntries.Size = new System.Drawing.Size(630, 422);
			this.dgvSetEntries.TabIndex = 6;
			// 
			// txtGotoTesting
			// 
			this.txtGotoTesting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGotoTesting.Location = new System.Drawing.Point(510, 468);
			this.txtGotoTesting.Name = "txtGotoTesting";
			this.txtGotoTesting.Size = new System.Drawing.Size(132, 23);
			this.txtGotoTesting.TabIndex = 7;
			this.txtGotoTesting.Text = "Goto Testing";
			this.txtGotoTesting.UseVisualStyleBackColor = true;
			this.txtGotoTesting.Click += new System.EventHandler(this.txtGotoTesting_Click);
			// 
			// Analyze
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(654, 500);
			this.Controls.Add(this.txtGotoTesting);
			this.Controls.Add(this.dgvSetEntries);
			this.Controls.Add(this.chkFar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbSets);
			this.Controls.Add(this.chkClose);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSetCount);
			this.Name = "Analyze";
			this.Text = "Analyze";
			((System.ComponentModel.ISupportInitialize)(this.dgvSetEntries)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtSetCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkClose;
		private System.Windows.Forms.ComboBox cmbSets;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox chkFar;
		private System.Windows.Forms.DataGridView dgvSetEntries;
		private System.Windows.Forms.Button txtGotoTesting;
	}
}