namespace RGBDiffWinForms
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
			this.txtP1x = new System.Windows.Forms.TextBox();
			this.txtP2x = new System.Windows.Forms.TextBox();
			this.txtP1y = new System.Windows.Forms.TextBox();
			this.txtP2y = new System.Windows.Forms.TextBox();
			this.txtAngle = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.chk0Deg12 = new System.Windows.Forms.CheckBox();
			this.chkRecalcPoint1 = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtP1x
			// 
			this.txtP1x.Location = new System.Drawing.Point(56, 65);
			this.txtP1x.Name = "txtP1x";
			this.txtP1x.Size = new System.Drawing.Size(40, 20);
			this.txtP1x.TabIndex = 2;
			// 
			// txtP2x
			// 
			this.txtP2x.Location = new System.Drawing.Point(56, 92);
			this.txtP2x.Name = "txtP2x";
			this.txtP2x.Size = new System.Drawing.Size(40, 20);
			this.txtP2x.TabIndex = 4;
			// 
			// txtP1y
			// 
			this.txtP1y.Location = new System.Drawing.Point(121, 65);
			this.txtP1y.Name = "txtP1y";
			this.txtP1y.Size = new System.Drawing.Size(40, 20);
			this.txtP1y.TabIndex = 3;
			// 
			// txtP2y
			// 
			this.txtP2y.Location = new System.Drawing.Point(121, 92);
			this.txtP2y.Name = "txtP2y";
			this.txtP2y.Size = new System.Drawing.Size(40, 20);
			this.txtP2y.TabIndex = 5;
			// 
			// txtAngle
			// 
			this.txtAngle.Location = new System.Drawing.Point(56, 196);
			this.txtAngle.Name = "txtAngle";
			this.txtAngle.Size = new System.Drawing.Size(105, 20);
			this.txtAngle.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(41, 157);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Calculate Angle";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Point 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Point 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 203);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Angle";
			// 
			// chk0Deg12
			// 
			this.chk0Deg12.AutoSize = true;
			this.chk0Deg12.Location = new System.Drawing.Point(12, 12);
			this.chk0Deg12.Name = "chk0Deg12";
			this.chk0Deg12.Size = new System.Drawing.Size(165, 17);
			this.chk0Deg12.TabIndex = 0;
			this.chk0Deg12.Text = "0 degrees equals 12 o\'clock?";
			this.chk0Deg12.UseVisualStyleBackColor = true;
			// 
			// chkRecalcPoint1
			// 
			this.chkRecalcPoint1.AutoSize = true;
			this.chkRecalcPoint1.Location = new System.Drawing.Point(12, 36);
			this.chkRecalcPoint1.Name = "chkRecalcPoint1";
			this.chkRecalcPoint1.Size = new System.Drawing.Size(165, 17);
			this.chkRecalcPoint1.TabIndex = 1;
			this.chkRecalcPoint1.Text = "Recalculate origin to Point 1?";
			this.chkRecalcPoint1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(102, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = ",";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(102, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(10, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = ",";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(41, 128);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(105, 23);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(186, 233);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.chkRecalcPoint1);
			this.Controls.Add(this.chk0Deg12);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtAngle);
			this.Controls.Add(this.txtP2y);
			this.Controls.Add(this.txtP1y);
			this.Controls.Add(this.txtP2x);
			this.Controls.Add(this.txtP1x);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtP1x;
		private System.Windows.Forms.TextBox txtP2x;
		private System.Windows.Forms.TextBox txtP1y;
		private System.Windows.Forms.TextBox txtP2y;
		private System.Windows.Forms.TextBox txtAngle;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chk0Deg12;
		private System.Windows.Forms.CheckBox chkRecalcPoint1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnClear;
	}
}

