using SaveEggs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveEggs
{
	public partial class CatchEggs : Form
	{
		bool moveLeft = false, moveRight = false;
		int eggSpeed = 2, playerSpeed = 4, playTime = 0, savedEggs = 0, missedEggs = 0;
		SoundPlayer soundMissed = new SoundPlayer(), soundSaved = new SoundPlayer(), soundRotten = new SoundPlayer();
		List <PictureBox> eggs = new List <PictureBox> ();
		public CatchEggs()
		{
			InitializeComponent();
			eggs.Clear();
			
			eggs.Add(pBoxEgg1);
			eggs.Add(pBoxEgg2);
			eggs.Add(pBoxEgg3);
			eggs.Add(pBoxEgg4);

			Random rnd = new Random();
			foreach (PictureBox pb in eggs)
			{
				
				pb.Top = rnd.Next(-1001, -101);
				pb.Left = placeEgg(pb.Tag.ToString());
				int type = getEggType();
				if (type % 5 == 0)
				{ pb.Image = Resources.rotten_egg; pb.AccessibleName = "r"; }
				else
				{ pb.Image = Resources.egg; pb.AccessibleName = "e"; }
			}
			playTime = MainForm.instance.time;
			lblTime.Text = "Time left: " + playTime.ToString();

			soundMissed.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"sounds\crack.wav";
			soundRotten.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"sounds\fart.wav";
			soundSaved.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + @"sounds\ping.wav";
		}

		private int placeEgg(string s)
		{
			Random rnd = new Random();
			int l = 0;

			if (s == "1")
				l = rnd.Next(10, 201);
			if (s == "2")
				l = rnd.Next(310, 401);

			if (s == "3")
				l = rnd.Next(510, 701);

			if (s == "4")
				l = rnd.Next(810, 875);

			return l;
		}

		private void CatchEggs_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.A)
				moveLeft = false;
			if (e.KeyCode == Keys.D)
				moveRight = false;
		}

		private int getEggType ()
		{
			Random rnd = new Random();
			int nr = rnd.Next(1, 16);
			return nr;
		}

		private void timerSecond_Tick(object sender, EventArgs e)
		{
			playTime--;
			lblTime.Text = "Time left: " + playTime.ToString();
			if (playTime <= 0)
			{
				timerGame.Stop();
				timerSecond.Stop();
				MessageBox.Show("The time ran out! You saved " + savedEggs.ToString() + " eggs! Great job!", "You won!");
				this.Close();
				MainForm mainForm = new MainForm();
				mainForm.Show();
				return;
			}
			if (playTime % 10 == 0)
				{ eggSpeed ++; playerSpeed ++; }
		}

		private void updateLabels()
		{
			lblSaved.Text = "Saved: " + savedEggs.ToString();
			lblMissed.Text = "Missed: " + missedEggs.ToString();
		}

		private void checkCollision()
		{
			Random rnd1 = new Random();
			foreach (PictureBox pb in eggs)
			{
				if (pb.Bounds.IntersectsWith(pBoxBasket.Bounds))
				{
					if (pb.AccessibleName == "e")
					{
						savedEggs++;
						soundSaved.Play();
						pb.Left = placeEgg(pb.Tag.ToString()); pb.Top = rnd1.Next(-1001, -101);
						int type = getEggType();
						if (type % 5 == 0)
						{ pb.Image = Resources.rotten_egg; pb.AccessibleName = "r"; }
						else
						{ pb.Image = Resources.egg; pb.AccessibleName = "e"; }
					}
					else
					{
						timerGame.Stop();
						timerSecond.Stop();
						soundRotten.Play();
						MessageBox.Show("Oh, you rotten egg! You lost!", "You lost!");
						this.Close();
						MainForm mainForm = new MainForm();
						mainForm.Show();
						return;
					}
				}
				updateLabels();
			}
		}

		private void checkLoss()
		{
			if (missedEggs == 10)
			{
				timerGame.Stop();
				timerSecond.Stop();
				this.Close();
				MainForm mainForm = new MainForm();
				MessageBox.Show("You missed too many eggs! You lost!", "You lost!");
				return;
			}
		}

		private void timerGame_Tick(object sender, EventArgs e)
		{

			checkCollision();
			checkLoss();

			if (moveLeft)
			{
				if (pBoxBasket.Left > 0)
					pBoxBasket.Left-=playerSpeed;
			}
			if (moveRight)
			{
				if (pBoxBasket.Left < 910)
					pBoxBasket.Left+=playerSpeed;
			}

			Random rnd1 = new Random();
			foreach (PictureBox pb in eggs)
			{
				pb.Top += eggSpeed;
				if (pb.Top > 540)
				{
					pb.Top = rnd1.Next(-1001, -101);
					pb.Left = placeEgg(pb.Tag.ToString());
					int type = getEggType();
					if (pb.AccessibleName == "e")
					{
						missedEggs++;
						soundMissed.Play();
						pb.Image = Resources.cracked_egg;
						updateLabels();
					}
					if (type % 5 == 0)
					{ pb.Image = Resources.rotten_egg; pb.AccessibleName = "r"; }
					else
					{ pb.Image = Resources.egg; pb.AccessibleName = "e"; }
				}
			}
		}

		private void CatchEggs_Load(object sender, EventArgs e)
		{
			timerGame.Start();
			timerSecond.Start();
		}

		private void CatchEggs_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.D)
				moveRight = true;
			if (e.KeyCode == Keys.A)
				moveLeft = true;
			if (e.KeyCode == Keys.Escape)
			{
				timerGame.Stop();
				timerSecond.Stop();
				Pause pause = new Pause();
				if (pause.ShowDialog() == DialogResult.Yes)
				{
					pause.Close();
					timerGame.Start();
					timerSecond.Start();
				}
				else
				{
					Application.Exit();
				}
			}
		}
	}
}
