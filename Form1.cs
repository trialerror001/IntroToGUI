using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleProfile
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txtNameR.Enabled = false;
			txtAddressR.Enabled = false;
			txtCityR.Enabled = false;
			txtGenderR.Enabled = false;
			txtSkillR.Enabled = false;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string list = listNegara.GetItemText(listNegara.SelectedItem);
			string gender;
			string skill = "";

			if (rbMale.Checked)
				gender = rbMale.Text;
			else
				gender = rbFemale.Text;

			if (chkCoding1.Checked && chkCoding2.Checked)
				skill = "C# & ASP";
			else if (chkCoding1.Checked)
				skill = "C#";
			else if (chkCoding2.Checked)
				skill = "ASP";
			
			txtNameR.Text = txtName.Text;
			txtAddressR.Text = txtAddress.Text;
			txtCityR.Text = list;
			txtGenderR.Text = gender;
			txtSkillR.Text = skill;

		}
	}
}
