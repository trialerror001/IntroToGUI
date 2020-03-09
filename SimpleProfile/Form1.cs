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
	}
}
