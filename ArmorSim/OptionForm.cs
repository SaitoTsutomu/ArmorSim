using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ArmorSim
{
	public partial class OptionForm : Form
	{
		internal Option Option { get { return (Option)propertyGrid1.SelectedObject; } }
		public OptionForm(Option opt)
		{
			InitializeComponent();
			propertyGrid1.SelectedObject = opt.Clone();
		}
		private void OptionForm_Load(object sender, EventArgs e)
		{
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}
	}
}
