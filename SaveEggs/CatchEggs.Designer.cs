namespace SaveEggs
{
	partial class CatchEggs
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchEggs));
			this.timerGame = new System.Windows.Forms.Timer(this.components);
			this.lblTime = new System.Windows.Forms.Label();
			this.timerSecond = new System.Windows.Forms.Timer(this.components);
			this.lblMissed = new System.Windows.Forms.Label();
			this.lblSaved = new System.Windows.Forms.Label();
			this.pBoxEgg4 = new System.Windows.Forms.PictureBox();
			this.pBoxEgg3 = new System.Windows.Forms.PictureBox();
			this.pBoxEgg2 = new System.Windows.Forms.PictureBox();
			this.pBoxEgg1 = new System.Windows.Forms.PictureBox();
			this.pBoxBasket = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxBasket)).BeginInit();
			this.SuspendLayout();
			// 
			// timerGame
			// 
			this.timerGame.Interval = 15;
			this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.Location = new System.Drawing.Point(1194, 12);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(115, 22);
			this.lblTime.TabIndex = 5;
			this.lblTime.Text = "Time left: 0";
			// 
			// timerSecond
			// 
			this.timerSecond.Interval = 1000;
			this.timerSecond.Tick += new System.EventHandler(this.timerSecond_Tick);
			// 
			// lblMissed
			// 
			this.lblMissed.AutoSize = true;
			this.lblMissed.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMissed.Location = new System.Drawing.Point(12, 738);
			this.lblMissed.Name = "lblMissed";
			this.lblMissed.Size = new System.Drawing.Size(108, 25);
			this.lblMissed.TabIndex = 6;
			this.lblMissed.Text = "Missed: 0";
			// 
			// lblSaved
			// 
			this.lblSaved.AutoSize = true;
			this.lblSaved.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSaved.Location = new System.Drawing.Point(1238, 738);
			this.lblSaved.Name = "lblSaved";
			this.lblSaved.Size = new System.Drawing.Size(103, 25);
			this.lblSaved.TabIndex = 7;
			this.lblSaved.Text = "Saved: 0";
			// 
			// pBoxEgg4
			// 
			this.pBoxEgg4.Image = global::SaveEggs.Properties.Resources.egg;
			this.pBoxEgg4.Location = new System.Drawing.Point(745, 28);
			this.pBoxEgg4.Name = "pBoxEgg4";
			this.pBoxEgg4.Size = new System.Drawing.Size(64, 95);
			this.pBoxEgg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBoxEgg4.TabIndex = 4;
			this.pBoxEgg4.TabStop = false;
			this.pBoxEgg4.Tag = "4";
			// 
			// pBoxEgg3
			// 
			this.pBoxEgg3.Image = ((System.Drawing.Image)(resources.GetObject("pBoxEgg3.Image")));
			this.pBoxEgg3.Location = new System.Drawing.Point(551, 28);
			this.pBoxEgg3.Name = "pBoxEgg3";
			this.pBoxEgg3.Size = new System.Drawing.Size(64, 95);
			this.pBoxEgg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBoxEgg3.TabIndex = 3;
			this.pBoxEgg3.TabStop = false;
			this.pBoxEgg3.Tag = "3";
			// 
			// pBoxEgg2
			// 
			this.pBoxEgg2.Image = ((System.Drawing.Image)(resources.GetObject("pBoxEgg2.Image")));
			this.pBoxEgg2.Location = new System.Drawing.Point(264, 28);
			this.pBoxEgg2.Name = "pBoxEgg2";
			this.pBoxEgg2.Size = new System.Drawing.Size(62, 95);
			this.pBoxEgg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBoxEgg2.TabIndex = 2;
			this.pBoxEgg2.TabStop = false;
			this.pBoxEgg2.Tag = "2";
			// 
			// pBoxEgg1
			// 
			this.pBoxEgg1.Image = ((System.Drawing.Image)(resources.GetObject("pBoxEgg1.Image")));
			this.pBoxEgg1.Location = new System.Drawing.Point(57, 28);
			this.pBoxEgg1.Name = "pBoxEgg1";
			this.pBoxEgg1.Size = new System.Drawing.Size(63, 95);
			this.pBoxEgg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBoxEgg1.TabIndex = 1;
			this.pBoxEgg1.TabStop = false;
			this.pBoxEgg1.Tag = "1";
			// 
			// pBoxBasket
			// 
			this.pBoxBasket.Image = ((System.Drawing.Image)(resources.GetObject("pBoxBasket.Image")));
			this.pBoxBasket.Location = new System.Drawing.Point(645, 582);
			this.pBoxBasket.Name = "pBoxBasket";
			this.pBoxBasket.Size = new System.Drawing.Size(126, 122);
			this.pBoxBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pBoxBasket.TabIndex = 0;
			this.pBoxBasket.TabStop = false;
			// 
			// CatchEggs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PowderBlue;
			this.ClientSize = new System.Drawing.Size(1369, 772);
			this.Controls.Add(this.lblSaved);
			this.Controls.Add(this.lblMissed);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.pBoxEgg4);
			this.Controls.Add(this.pBoxEgg3);
			this.Controls.Add(this.pBoxEgg2);
			this.Controls.Add(this.pBoxEgg1);
			this.Controls.Add(this.pBoxBasket);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "CatchEggs";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CatchEggs";
			this.Load += new System.EventHandler(this.CatchEggs_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatchEggs_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CatchEggs_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxEgg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxBasket)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timerGame;
		private System.Windows.Forms.PictureBox pBoxBasket;
		private System.Windows.Forms.PictureBox pBoxEgg1;
		private System.Windows.Forms.PictureBox pBoxEgg2;
		private System.Windows.Forms.PictureBox pBoxEgg3;
		private System.Windows.Forms.PictureBox pBoxEgg4;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer timerSecond;
		private System.Windows.Forms.Label lblMissed;
		private System.Windows.Forms.Label lblSaved;
	}
}