namespace Hangman_ItayShachar
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.GameOverGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverGif)).BeginInit();
            this.SuspendLayout();
            // 
            // GameOverGif
            // 
            this.GameOverGif.Image = ((System.Drawing.Image)(resources.GetObject("GameOverGif.Image")));
            this.GameOverGif.Location = new System.Drawing.Point(0, -2);
            this.GameOverGif.Name = "GameOverGif";
            this.GameOverGif.Size = new System.Drawing.Size(585, 378);
            this.GameOverGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOverGif.TabIndex = 0;
            this.GameOverGif.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 379);
            this.Controls.Add(this.GameOverGif);
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.Load += new System.EventHandler(this.GameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GameOverGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GameOverGif;
    }
}