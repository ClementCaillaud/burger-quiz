namespace BurgerQuiz
{
    partial class ScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreForm));
            this.ScorePanel = new System.Windows.Forms.TableLayoutPanel();
            this.KetchupPictureBox = new System.Windows.Forms.PictureBox();
            this.MayoPictureBox = new System.Windows.Forms.PictureBox();
            this.KetchupScoreLabel = new System.Windows.Forms.Label();
            this.MayoScoreLabel = new System.Windows.Forms.Label();
            this.ScorePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KetchupPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MayoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.Black;
            this.ScorePanel.ColumnCount = 2;
            this.ScorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ScorePanel.Controls.Add(this.KetchupPictureBox, 0, 0);
            this.ScorePanel.Controls.Add(this.MayoPictureBox, 1, 0);
            this.ScorePanel.Controls.Add(this.KetchupScoreLabel, 0, 1);
            this.ScorePanel.Controls.Add(this.MayoScoreLabel, 1, 1);
            this.ScorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScorePanel.Location = new System.Drawing.Point(0, 0);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.RowCount = 2;
            this.ScorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.23943F));
            this.ScorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.76056F));
            this.ScorePanel.Size = new System.Drawing.Size(946, 483);
            this.ScorePanel.TabIndex = 0;
            // 
            // KetchupPictureBox
            // 
            this.KetchupPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KetchupPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("KetchupPictureBox.Image")));
            this.KetchupPictureBox.Location = new System.Drawing.Point(3, 3);
            this.KetchupPictureBox.Name = "KetchupPictureBox";
            this.KetchupPictureBox.Size = new System.Drawing.Size(467, 347);
            this.KetchupPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KetchupPictureBox.TabIndex = 0;
            this.KetchupPictureBox.TabStop = false;
            // 
            // MayoPictureBox
            // 
            this.MayoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MayoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MayoPictureBox.Image")));
            this.MayoPictureBox.Location = new System.Drawing.Point(476, 3);
            this.MayoPictureBox.Name = "MayoPictureBox";
            this.MayoPictureBox.Size = new System.Drawing.Size(467, 347);
            this.MayoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MayoPictureBox.TabIndex = 1;
            this.MayoPictureBox.TabStop = false;
            // 
            // KetchupScoreLabel
            // 
            this.KetchupScoreLabel.AutoSize = true;
            this.KetchupScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KetchupScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KetchupScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.KetchupScoreLabel.Location = new System.Drawing.Point(3, 353);
            this.KetchupScoreLabel.Name = "KetchupScoreLabel";
            this.KetchupScoreLabel.Size = new System.Drawing.Size(467, 130);
            this.KetchupScoreLabel.TabIndex = 2;
            this.KetchupScoreLabel.Text = "0 MIAMS";
            this.KetchupScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KetchupScoreLabel.UseCompatibleTextRendering = true;
            // 
            // MayoScoreLabel
            // 
            this.MayoScoreLabel.AutoSize = true;
            this.MayoScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MayoScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MayoScoreLabel.ForeColor = System.Drawing.Color.Gold;
            this.MayoScoreLabel.Location = new System.Drawing.Point(476, 353);
            this.MayoScoreLabel.Name = "MayoScoreLabel";
            this.MayoScoreLabel.Size = new System.Drawing.Size(467, 130);
            this.MayoScoreLabel.TabIndex = 3;
            this.MayoScoreLabel.Text = "0 MIAMS";
            this.MayoScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MayoScoreLabel.UseCompatibleTextRendering = true;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(946, 483);
            this.Controls.Add(this.ScorePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ScoreForm_PreviewKeyDown);
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KetchupPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MayoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ScorePanel;
        private System.Windows.Forms.PictureBox KetchupPictureBox;
        private System.Windows.Forms.PictureBox MayoPictureBox;
        private System.Windows.Forms.Label KetchupScoreLabel;
        private System.Windows.Forms.Label MayoScoreLabel;
    }
}