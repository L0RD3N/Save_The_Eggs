namespace SaveEggs
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnPlay = new System.Windows.Forms.Button();
			this.tBoxTime = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.Color.LightSkyBlue;
			this.btnPlay.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlay.Location = new System.Drawing.Point(411, 494);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(142, 75);
			this.btnPlay.TabIndex = 0;
			this.btnPlay.Text = "Play";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// tBoxTime
			// 
			this.tBoxTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tBoxTime.Location = new System.Drawing.Point(411, 437);
			this.tBoxTime.Name = "tBoxTime";
			this.tBoxTime.Size = new System.Drawing.Size(142, 32);
			this.tBoxTime.TabIndex = 2;
			this.tBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTime_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(286, 440);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Playtime:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(269, 368);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(438, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Catch the eggs and avoid the rotten ones!";
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Crimson;
			this.btnExit.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(880, 527);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(104, 42);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(559, 444);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "seconds";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SaveEggs.Properties.Resources.chicken;
			this.pictureBox1.Location = new System.Drawing.Point(316, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(325, 303);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(996, 581);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tBoxTime);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnPlay);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main Menu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tBoxTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label3;
	}
}

