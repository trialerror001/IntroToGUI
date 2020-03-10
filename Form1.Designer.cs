namespace SimpleProfile
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.listNegara = new System.Windows.Forms.ListBox();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.chkCoding1 = new System.Windows.Forms.CheckBox();
			this.chkCoding2 = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSkillR = new System.Windows.Forms.TextBox();
			this.txtGenderR = new System.Windows.Forms.TextBox();
			this.txtCityR = new System.Windows.Forms.TextBox();
			this.txtAddressR = new System.Windows.Forms.TextBox();
			this.txtNameR = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(604, 190);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Detail";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(190, 119);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(330, 38);
			this.txtAddress.TabIndex = 3;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(190, 56);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(330, 38);
			this.txtName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Address";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// listNegara
			// 
			this.listNegara.FormattingEnabled = true;
			this.listNegara.ItemHeight = 31;
			this.listNegara.Items.AddRange(new object[] {
            "Indonesia",
            "Malaysia",
            "Singapura",
            "China"});
			this.listNegara.Location = new System.Drawing.Point(13, 240);
			this.listNegara.Name = "listNegara";
			this.listNegara.Size = new System.Drawing.Size(604, 314);
			this.listNegara.TabIndex = 1;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Location = new System.Drawing.Point(691, 65);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(114, 36);
			this.rbMale.TabIndex = 2;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(691, 129);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(147, 36);
			this.rbFemale.TabIndex = 3;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// chkCoding1
			// 
			this.chkCoding1.AutoSize = true;
			this.chkCoding1.Location = new System.Drawing.Point(691, 240);
			this.chkCoding1.Name = "chkCoding1";
			this.chkCoding1.Size = new System.Drawing.Size(89, 36);
			this.chkCoding1.TabIndex = 4;
			this.chkCoding1.Text = "C#";
			this.chkCoding1.UseVisualStyleBackColor = true;
			// 
			// chkCoding2
			// 
			this.chkCoding2.AutoSize = true;
			this.chkCoding2.Location = new System.Drawing.Point(691, 310);
			this.chkCoding2.Name = "chkCoding2";
			this.chkCoding2.Size = new System.Drawing.Size(110, 36);
			this.chkCoding2.TabIndex = 5;
			this.chkCoding2.Text = "ASP";
			this.chkCoding2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSkillR);
			this.groupBox2.Controls.Add(this.txtGenderR);
			this.groupBox2.Controls.Add(this.txtCityR);
			this.groupBox2.Controls.Add(this.txtAddressR);
			this.groupBox2.Controls.Add(this.txtNameR);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(996, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(555, 541);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "User Profile";
			// 
			// txtSkillR
			// 
			this.txtSkillR.Location = new System.Drawing.Point(210, 317);
			this.txtSkillR.Name = "txtSkillR";
			this.txtSkillR.Size = new System.Drawing.Size(313, 38);
			this.txtSkillR.TabIndex = 9;
			// 
			// txtGenderR
			// 
			this.txtGenderR.Location = new System.Drawing.Point(210, 251);
			this.txtGenderR.Name = "txtGenderR";
			this.txtGenderR.Size = new System.Drawing.Size(313, 38);
			this.txtGenderR.TabIndex = 8;
			// 
			// txtCityR
			// 
			this.txtCityR.Location = new System.Drawing.Point(210, 186);
			this.txtCityR.Name = "txtCityR";
			this.txtCityR.Size = new System.Drawing.Size(313, 38);
			this.txtCityR.TabIndex = 7;
			// 
			// txtAddressR
			// 
			this.txtAddressR.Location = new System.Drawing.Point(210, 122);
			this.txtAddressR.Name = "txtAddressR";
			this.txtAddressR.Size = new System.Drawing.Size(313, 38);
			this.txtAddressR.TabIndex = 6;
			// 
			// txtNameR
			// 
			this.txtNameR.Location = new System.Drawing.Point(210, 56);
			this.txtNameR.Name = "txtNameR";
			this.txtNameR.Size = new System.Drawing.Size(313, 38);
			this.txtNameR.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(24, 320);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 32);
			this.label7.TabIndex = 4;
			this.label7.Text = "Skill";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 254);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 32);
			this.label6.TabIndex = 3;
			this.label6.Text = "Gender";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 189);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 32);
			this.label5.TabIndex = 2;
			this.label5.Text = "City";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(24, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 32);
			this.label4.TabIndex = 1;
			this.label4.Text = "Address";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 32);
			this.label3.TabIndex = 0;
			this.label3.Text = "Name";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(691, 397);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(147, 76);
			this.btnSubmit.TabIndex = 7;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1642, 646);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.chkCoding2);
			this.Controls.Add(this.chkCoding1);
			this.Controls.Add(this.rbFemale);
			this.Controls.Add(this.rbMale);
			this.Controls.Add(this.listNegara);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listNegara;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.CheckBox chkCoding1;
		private System.Windows.Forms.CheckBox chkCoding2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSkillR;
		private System.Windows.Forms.TextBox txtGenderR;
		private System.Windows.Forms.TextBox txtCityR;
		private System.Windows.Forms.TextBox txtAddressR;
		private System.Windows.Forms.TextBox txtNameR;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSubmit;
	}
}

