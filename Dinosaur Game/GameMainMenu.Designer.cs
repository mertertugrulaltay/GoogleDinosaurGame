namespace Dinosaur_Game
{
    partial class GameMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMainMenu));
            this.lblOyunIsmiAciklama = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHighScoreAciklama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOyunIsmiAciklama
            // 
            this.lblOyunIsmiAciklama.AutoSize = true;
            this.lblOyunIsmiAciklama.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOyunIsmiAciklama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOyunIsmiAciklama.Image = ((System.Drawing.Image)(resources.GetObject("lblOyunIsmiAciklama.Image")));
            this.lblOyunIsmiAciklama.Location = new System.Drawing.Point(74, 115);
            this.lblOyunIsmiAciklama.Name = "lblOyunIsmiAciklama";
            this.lblOyunIsmiAciklama.Size = new System.Drawing.Size(163, 33);
            this.lblOyunIsmiAciklama.TabIndex = 0;
            this.lblOyunIsmiAciklama.Text = "Dinosaur Game";
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblQuit.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblQuit.Image = ((System.Drawing.Image)(resources.GetObject("lblQuit.Image")));
            this.lblQuit.Location = new System.Drawing.Point(118, 320);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(64, 30);
            this.lblQuit.TabIndex = 1;
            this.lblQuit.Text = "QUIT";
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // lblPlay
            // 
            this.lblPlay.AutoSize = true;
            this.lblPlay.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.Khaki;
            this.lblPlay.Image = ((System.Drawing.Image)(resources.GetObject("lblPlay.Image")));
            this.lblPlay.Location = new System.Drawing.Point(118, 260);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(65, 30);
            this.lblPlay.TabIndex = 2;
            this.lblPlay.Text = "PLAY";
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(112, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 86);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblHighScoreAciklama
            // 
            this.lblHighScoreAciklama.AutoSize = true;
            this.lblHighScoreAciklama.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHighScoreAciklama.ForeColor = System.Drawing.Color.Peru;
            this.lblHighScoreAciklama.Image = ((System.Drawing.Image)(resources.GetObject("lblHighScoreAciklama.Image")));
            this.lblHighScoreAciklama.Location = new System.Drawing.Point(85, 290);
            this.lblHighScoreAciklama.Name = "lblHighScoreAciklama";
            this.lblHighScoreAciklama.Size = new System.Drawing.Size(143, 30);
            this.lblHighScoreAciklama.TabIndex = 4;
            this.lblHighScoreAciklama.Text = "HIGH SCORE";
            this.lblHighScoreAciklama.Click += new System.EventHandler(this.lblHighScoreAciklama_Click);
            // 
            // GameMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 424);
            this.Controls.Add(this.lblHighScoreAciklama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPlay);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.lblOyunIsmiAciklama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOyunIsmiAciklama;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHighScoreAciklama;
    }
}