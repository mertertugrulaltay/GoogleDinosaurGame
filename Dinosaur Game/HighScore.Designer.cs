namespace Dinosaur_Game
{
    partial class HighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberAciklama = new System.Windows.Forms.Label();
            this.picBoxKapat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKapat)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(192, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 40);
            this.label2.TabIndex = 5;
            // 
            // lblNumberAciklama
            // 
            this.lblNumberAciklama.AutoSize = true;
            this.lblNumberAciklama.BackColor = System.Drawing.Color.White;
            this.lblNumberAciklama.Font = new System.Drawing.Font("Segoe UI", 63F, System.Drawing.FontStyle.Bold);
            this.lblNumberAciklama.ForeColor = System.Drawing.Color.Khaki;
            this.lblNumberAciklama.Location = new System.Drawing.Point(244, 209);
            this.lblNumberAciklama.Name = "lblNumberAciklama";
            this.lblNumberAciklama.Size = new System.Drawing.Size(143, 112);
            this.lblNumberAciklama.TabIndex = 10;
            this.lblNumberAciklama.Text = "00";
            // 
            // picBoxKapat
            // 
            this.picBoxKapat.BackColor = System.Drawing.Color.LightCoral;
            this.picBoxKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxKapat.BackgroundImage")));
            this.picBoxKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxKapat.Location = new System.Drawing.Point(572, 3);
            this.picBoxKapat.Name = "picBoxKapat";
            this.picBoxKapat.Size = new System.Drawing.Size(24, 24);
            this.picBoxKapat.TabIndex = 9;
            this.picBoxKapat.TabStop = false;
            this.picBoxKapat.Click += new System.EventHandler(this.picBoxKapat_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 346);
            this.Controls.Add(this.lblNumberAciklama);
            this.Controls.Add(this.picBoxKapat);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblNumberAciklama;
        private System.Windows.Forms.PictureBox picBoxKapat;
    }
}