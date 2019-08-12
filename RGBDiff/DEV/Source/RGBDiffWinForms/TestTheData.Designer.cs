namespace RGBDiffWinForms
{
	partial class TestTheData
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
			this.txtRGB1 = new System.Windows.Forms.TextBox();
			this.txtRGB2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlRGB1 = new System.Windows.Forms.Panel();
			this.pnlRGB2 = new System.Windows.Forms.Panel();
			this.lblRGBDelta = new System.Windows.Forms.Label();
			this.txtDeltaRGBDiff = new System.Windows.Forms.TextBox();
			this.btnCalcDelta = new System.Windows.Forms.Button();
			this.txtScaler = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.rdoNoWeight = new System.Windows.Forms.RadioButton();
			this.rdoUseWeighting = new System.Windows.Forms.RadioButton();
			this.rdoUseWeighting2 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtRGB1
			// 
			this.txtRGB1.Location = new System.Drawing.Point(149, 106);
			this.txtRGB1.Name = "txtRGB1";
			this.txtRGB1.Size = new System.Drawing.Size(100, 20);
			this.txtRGB1.TabIndex = 0;
			this.txtRGB1.Text = "100,9,60";
			this.txtRGB1.TextChanged += new System.EventHandler(this.txtRGB1_TextChanged);
			// 
			// txtRGB2
			// 
			this.txtRGB2.Location = new System.Drawing.Point(353, 106);
			this.txtRGB2.Name = "txtRGB2";
			this.txtRGB2.Size = new System.Drawing.Size(100, 20);
			this.txtRGB2.TabIndex = 1;
			this.txtRGB2.Text = "100,9,70";
			this.txtRGB2.TextChanged += new System.EventHandler(this.txtRGB2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "RGB1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(282, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "RGB2";
			// 
			// pnlRGB1
			// 
			this.pnlRGB1.Location = new System.Drawing.Point(149, 147);
			this.pnlRGB1.Name = "pnlRGB1";
			this.pnlRGB1.Size = new System.Drawing.Size(100, 100);
			this.pnlRGB1.TabIndex = 4;
			// 
			// pnlRGB2
			// 
			this.pnlRGB2.Location = new System.Drawing.Point(353, 147);
			this.pnlRGB2.Name = "pnlRGB2";
			this.pnlRGB2.Size = new System.Drawing.Size(100, 100);
			this.pnlRGB2.TabIndex = 5;
			// 
			// lblRGBDelta
			// 
			this.lblRGBDelta.AutoSize = true;
			this.lblRGBDelta.Location = new System.Drawing.Point(210, 442);
			this.lblRGBDelta.Name = "lblRGBDelta";
			this.lblRGBDelta.Size = new System.Drawing.Size(74, 13);
			this.lblRGBDelta.TabIndex = 6;
			this.lblRGBDelta.Text = "Delta RGBDiff";
			// 
			// txtDeltaRGBDiff
			// 
			this.txtDeltaRGBDiff.Location = new System.Drawing.Point(297, 439);
			this.txtDeltaRGBDiff.Name = "txtDeltaRGBDiff";
			this.txtDeltaRGBDiff.Size = new System.Drawing.Size(100, 20);
			this.txtDeltaRGBDiff.TabIndex = 8;
			// 
			// btnCalcDelta
			// 
			this.btnCalcDelta.Location = new System.Drawing.Point(236, 396);
			this.btnCalcDelta.Name = "btnCalcDelta";
			this.btnCalcDelta.Size = new System.Drawing.Size(100, 23);
			this.btnCalcDelta.TabIndex = 9;
			this.btnCalcDelta.Text = "Calculate Delta";
			this.btnCalcDelta.UseVisualStyleBackColor = true;
			this.btnCalcDelta.Click += new System.EventHandler(this.btnCalcDelta_Click);
			// 
			// txtScaler
			// 
			this.txtScaler.Location = new System.Drawing.Point(285, 270);
			this.txtScaler.Name = "txtScaler";
			this.txtScaler.Size = new System.Drawing.Size(100, 20);
			this.txtScaler.TabIndex = 10;
			this.txtScaler.Text = "1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(205, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Scaling Factor";
			// 
			// txtWeight
			// 
			this.txtWeight.Location = new System.Drawing.Point(297, 465);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(100, 20);
			this.txtWeight.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(210, 468);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Weighting Used";
			// 
			// rdoNoWeight
			// 
			this.rdoNoWeight.AutoSize = true;
			this.rdoNoWeight.Checked = true;
			this.rdoNoWeight.Location = new System.Drawing.Point(14, 14);
			this.rdoNoWeight.Name = "rdoNoWeight";
			this.rdoNoWeight.Size = new System.Drawing.Size(90, 17);
			this.rdoNoWeight.TabIndex = 15;
			this.rdoNoWeight.TabStop = true;
			this.rdoNoWeight.Text = "No Weighting";
			this.rdoNoWeight.UseVisualStyleBackColor = true;
			// 
			// rdoUseWeighting
			// 
			this.rdoUseWeighting.AutoSize = true;
			this.rdoUseWeighting.Location = new System.Drawing.Point(14, 38);
			this.rdoUseWeighting.Name = "rdoUseWeighting";
			this.rdoUseWeighting.Size = new System.Drawing.Size(95, 17);
			this.rdoUseWeighting.TabIndex = 16;
			this.rdoUseWeighting.Text = "Use Weighting";
			this.rdoUseWeighting.UseVisualStyleBackColor = true;
			// 
			// rdoUseWeighting2
			// 
			this.rdoUseWeighting2.AutoSize = true;
			this.rdoUseWeighting2.Location = new System.Drawing.Point(14, 62);
			this.rdoUseWeighting2.Name = "rdoUseWeighting2";
			this.rdoUseWeighting2.Size = new System.Drawing.Size(101, 17);
			this.rdoUseWeighting2.TabIndex = 17;
			this.rdoUseWeighting2.Text = "Use Weighting2";
			this.rdoUseWeighting2.UseVisualStyleBackColor = true;
			this.rdoUseWeighting2.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdoNoWeight);
			this.panel1.Controls.Add(this.rdoUseWeighting2);
			this.panel1.Controls.Add(this.rdoUseWeighting);
			this.panel1.Location = new System.Drawing.Point(213, 296);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(224, 94);
			this.panel1.TabIndex = 18;
			// 
			// TestTheData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 550);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtWeight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtScaler);
			this.Controls.Add(this.btnCalcDelta);
			this.Controls.Add(this.txtDeltaRGBDiff);
			this.Controls.Add(this.lblRGBDelta);
			this.Controls.Add(this.pnlRGB2);
			this.Controls.Add(this.pnlRGB1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtRGB2);
			this.Controls.Add(this.txtRGB1);
			this.Name = "TestTheData";
			this.Text = "TestTheData";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRGB1;
		private System.Windows.Forms.TextBox txtRGB2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnlRGB1;
		private System.Windows.Forms.Panel pnlRGB2;
		private System.Windows.Forms.Label lblRGBDelta;
		private System.Windows.Forms.TextBox txtDeltaRGBDiff;
		private System.Windows.Forms.Button btnCalcDelta;
		private System.Windows.Forms.TextBox txtScaler;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rdoNoWeight;
		private System.Windows.Forms.RadioButton rdoUseWeighting;
		private System.Windows.Forms.RadioButton rdoUseWeighting2;
		private System.Windows.Forms.Panel panel1;
	}
}