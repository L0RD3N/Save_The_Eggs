using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveEggs
{
	public partial class MainForm : Form
	{

		public static MainForm instance;
		public int time = 0;
		public MainForm()
		{
			InitializeComponent();
			instance = this;
			tBoxTime.Text = "30";
		}

		private void tBoxTime_KeyPress(object sender, KeyPressEventArgs e)
		{
			char c = e.KeyChar;
			if (!char.IsDigit(c) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			//MessageBox.Show("Use A and D to move your basket and catch the eggs.\nIf you catch a rotten egg or miss 10 eggs, you will lose.\nEvery 10 seconds, the eggs will get faster.\nYou can use ESC to pause the game.", "How to play");
			time = int.Parse(tBoxTime.Text);
			this.Hide();
			CatchEggs catchEggs = new CatchEggs();
			catchEggs.Show();
		}
	}
}
