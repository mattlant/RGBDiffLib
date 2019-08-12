using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using silverspun.RGBDiff.Dal.EntityClasses;
using silverspun.RGBDiff.Dal.Linq;


namespace RGBDiffWinForms
{
	public partial class Analyze : Form
	{

		IList<IGrouping<int, ObserverDataSetColourEntity>> _sets;

		public Analyze()
		{
			InitializeComponent();

			LinqMetaData meta = new LinqMetaData();

			_sets = (from set in meta.ObserverDataSetColour
			        group set by  set.ObserverDataSetUID into setGroup
			                                             	select setGroup).ToList();

			cmbSets.DisplayMember = "Key";
			cmbSets.ValueMember = "Key";
			cmbSets.DataSource = _sets.OrderBy(item => item.Key).ToList();




		}

		private void cmbSets_SelectedIndexChanged(object sender, EventArgs e)
		{
			var setList = _sets.Where(set => set.Key == (int)cmbSets.SelectedValue).First().ToList();

			if (chkClose.Checked)
			{
				setList = setList.Where(item => Math.Abs(item.ControlxyY_x - item.XyY_x) < 0.002 &&
												Math.Abs(item.ControlxyY_y - item.XyY_y) < 0.002).ToList();

			}

			if (chkFar.Checked)
			{
				setList = setList.Where(item => Math.Abs(item.ControlxyY_x - item.XyY_x) > 0.018 &&
												Math.Abs(item.ControlxyY_y - item.XyY_y) > 0.018).ToList();

			}

			dgvSetEntries.DataSource = setList;

			txtSetCount.Text = setList.Count.ToString();

		}

		private void txtGotoTesting_Click(object sender, EventArgs e)
		{
			TestTheData td = new TestTheData();
			td.Show(this);

		}
	}
}
