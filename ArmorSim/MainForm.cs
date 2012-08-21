using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ArmorSim
{
	public partial class MainForm : Form
	{
		private const string dataFile = "ArmorSim.xml";
		private const string csvFile = "darksoul.csv";
		private Data dd;
		public static void ChangeDirectory()
		{
			Directory.SetCurrentDirectory(Path.GetDirectoryName(
				Assembly.GetExecutingAssembly().Location));
		}
		RadioButton[] rb1;
		RadioButton[] rb2;
		RadioButton[] rb3;
		RadioButton[] rb4;
		public MainForm()
		{
			InitializeComponent();
			rb1 = new RadioButton[] { rb兜全て, rb兜なし, rb兜固定 };
			rb2 = new RadioButton[] { rb鎧全て, rb鎧なし, rb鎧固定 };
			rb3 = new RadioButton[] { rb手甲全て, rb手甲なし, rb手甲固定 };
			rb4 = new RadioButton[] { rb足甲全て, rb足甲なし, rb足甲固定 };
			ChangeDirectory();
			if (!File.Exists(csvFile))
			{
				var asm = GetType().Assembly;
				string s = GetType().Namespace + "." + csvFile;
				using (var st = asm.GetManifestResourceStream(s))
				using (var sr = new StreamReader(st, Encoding.GetEncoding(932)))
					File.WriteAllText(csvFile, sr.ReadToEnd(), Encoding.GetEncoding(932));
				Thread.Sleep(1000);
			}
			if (File.Exists(dataFile) && File.GetLastWriteTime(dataFile) > File.GetLastWriteTime(csvFile))
				dd = Data.Load(dataFile);
			else dd = new Data(csvFile);
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			for (int i = 8; i <= 40; ++i) cb持久力.Items.Add(i);
			cb持久力.SelectedIndexChanged += new EventHandler(cb持久力_SelectedIndexChanged);
			cb兜.Items.Add("");
			foreach (var it in dd.List兜) cb兜.Items.Add(it.表示名());
			cb兜.Text = dd.固定兜;
			cb鎧.Items.Add("");
			foreach (var it in dd.List鎧) cb鎧.Items.Add(it.表示名());
			cb鎧.Text = dd.固定鎧;
			cb手甲.Items.Add("");
			foreach (var it in dd.List手甲) cb手甲.Items.Add(it.表示名());
			cb手甲.Text = dd.固定手甲;
			cb足甲.Items.Add("");
			foreach (var it in dd.List足甲) cb足甲.Items.Add(it.表示名());
			cb足甲.Text = dd.固定足甲;
			foreach (var ans in dd.ListAnswer) lbList.Items.Add(ans.説明());
			lbList.SelectedIndexChanged += new EventHandler(lbList_SelectedIndexChanged);
			DataToControl();
			rb_CheckedChanged(null, null);
			if (lbList.Items.Count > 0) lbList.SelectedIndex = 0;
		}
		private void cb持久力_SelectedIndexChanged(object sender, EventArgs e)
		{
			tb装備重量.Text = (int.Parse(cb持久力.Text) + 40).ToString();
		}
		private void lbList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var ans = dd.ListAnswer[lbList.SelectedIndex];
			tb結果.Text = ans.Result(dd);
		}
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ControlToData();
			dd.Save(dataFile);
		}
		private void DataToControl()
		{
			try
			{
				cb持久力.SelectedIndex = dd.持久力;
				tb装備以外重量.Text = dd.装備以外重量.ToString();
				cb順位数.Text = dd.順位数.ToString();
				tb装備重量.Text = dd.装備重量.ToString();
				cb割合.SelectedIndex = dd.割合;
				rb1[(int)dd.兜条件].Checked = true;
				rb2[(int)dd.鎧条件].Checked = true;
				rb3[(int)dd.手甲条件].Checked = true;
				rb4[(int)dd.足甲条件].Checked = true;
				cb兜.Text = dd.固定兜;
				cb鎧.Text = dd.固定鎧;
				cb手甲.Text = dd.固定手甲;
				cb足甲.Text = dd.固定足甲;
				cb寵愛.Checked = dd.寵愛と加護の指輪;
				cbハベルの指輪.Checked = dd.ハベルの指輪;
				cb原盤.Checked = dd.原盤;
				cb通常.Checked = dd.通常;
				cb光.Checked = dd.光;
				cb不可.Checked = dd.不可;
			}
			catch { }
		}
		private void ControlToData()
		{
			try
			{
				dd.持久力 = cb持久力.SelectedIndex;
				dd.装備以外重量 = double.Parse(tb装備以外重量.Text);
				dd.順位数 = int.Parse(cb順位数.Text);
				dd.装備重量 = double.Parse(tb装備重量.Text);
				dd.割合 = cb割合.SelectedIndex;
				dd.兜条件 = GetRadioButton(rb1);
				dd.鎧条件 = GetRadioButton(rb2);
				dd.手甲条件 = GetRadioButton(rb3);
				dd.足甲条件 = GetRadioButton(rb4);
				dd.固定兜 = cb兜.Text;
				dd.固定鎧 = cb鎧.Text;
				dd.固定手甲 = cb手甲.Text;
				dd.固定足甲 = cb足甲.Text;
				dd.寵愛と加護の指輪 = cb寵愛.Checked;
				dd.ハベルの指輪 = cbハベルの指輪.Checked;
				dd.原盤 = cb原盤.Checked;
				dd.通常 = cb通常.Checked;
				dd.光 = cb光.Checked;
				dd.不可 = cb不可.Checked;
			}
			catch { }
		}
		private ECond GetRadioButton(RadioButton[] rb)
		{
			for (int i = 0; i < rb.Length; ++i)
				if (rb[i].Checked) return (ECond)i;
			return ECond.なし;
		}
		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void btnOption_Click(object sender, EventArgs e)
		{
			var dlg = new OptionForm(dd.Option);
			if (dlg.ShowDialog() != DialogResult.OK) return;
			dd.Option = dlg.Option;
		}
		private void brnCalc_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor = Cursors.WaitCursor;
				tb結果.Text = "";
				ControlToData();
				int[] sels = { cb兜.SelectedIndex, cb鎧.SelectedIndex, cb手甲.SelectedIndex, cb足甲.SelectedIndex };
				dd.Solve(sels);
				lbList.Items.Clear();
				foreach (var ans in dd.ListAnswer) lbList.Items.Add(ans.説明());
				if (lbList.Items.Count > 0)
					lbList.SelectedIndex = 0;
				lbList.Focus();
			}
			catch (Exception ee)
			{
				MessageBox.Show(ee.Message, Text);
				return;
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}
		private void rb_CheckedChanged(object sender, EventArgs e)
		{
			cb兜.Enabled = rb兜固定.Checked;
			cb鎧.Enabled = rb鎧固定.Checked;
			cb手甲.Enabled = rb手甲固定.Checked;
			cb足甲.Enabled = rb足甲固定.Checked;
		}
	}
}
