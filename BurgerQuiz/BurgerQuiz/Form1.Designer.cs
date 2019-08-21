namespace BurgerQuiz
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBoxScene = new System.Windows.Forms.PictureBox();
			this.panelScene = new System.Windows.Forms.Panel();
			this.tableLayoutPanelScore = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBoxMayo = new System.Windows.Forms.PictureBox();
			this.pictureBoxKetchup = new System.Windows.Forms.PictureBox();
			this.labelKetchup = new System.Windows.Forms.Label();
			this.labelMayo = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScene)).BeginInit();
			this.panelScene.SuspendLayout();
			this.tableLayoutPanelScore.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMayo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxKetchup)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxScene
			// 
			this.pictureBoxScene.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxScene.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxScene.Name = "pictureBoxScene";
			this.pictureBoxScene.Size = new System.Drawing.Size(671, 440);
			this.pictureBoxScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxScene.TabIndex = 0;
			this.pictureBoxScene.TabStop = false;
			this.pictureBoxScene.Visible = false;
			// 
			// panelScene
			// 
			this.panelScene.BackColor = System.Drawing.SystemColors.WindowText;
			this.panelScene.Controls.Add(this.tableLayoutPanelScore);
			this.panelScene.Controls.Add(this.pictureBoxScene);
			this.panelScene.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelScene.Location = new System.Drawing.Point(0, 0);
			this.panelScene.Name = "panelScene";
			this.panelScene.Size = new System.Drawing.Size(671, 440);
			this.panelScene.TabIndex = 2;
			// 
			// tableLayoutPanelScore
			// 
			this.tableLayoutPanelScore.ColumnCount = 2;
			this.tableLayoutPanelScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelScore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelScore.Controls.Add(this.pictureBoxMayo, 1, 0);
			this.tableLayoutPanelScore.Controls.Add(this.pictureBoxKetchup, 0, 0);
			this.tableLayoutPanelScore.Controls.Add(this.labelKetchup, 0, 1);
			this.tableLayoutPanelScore.Controls.Add(this.labelMayo, 1, 1);
			this.tableLayoutPanelScore.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelScore.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanelScore.Name = "tableLayoutPanelScore";
			this.tableLayoutPanelScore.RowCount = 2;
			this.tableLayoutPanelScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutPanelScore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelScore.Size = new System.Drawing.Size(671, 440);
			this.tableLayoutPanelScore.TabIndex = 1;
			// 
			// pictureBoxMayo
			// 
			this.pictureBoxMayo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxMayo.Location = new System.Drawing.Point(338, 3);
			this.pictureBoxMayo.Name = "pictureBoxMayo";
			this.pictureBoxMayo.Size = new System.Drawing.Size(330, 302);
			this.pictureBoxMayo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxMayo.TabIndex = 0;
			this.pictureBoxMayo.TabStop = false;
			// 
			// pictureBoxKetchup
			// 
			this.pictureBoxKetchup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxKetchup.Location = new System.Drawing.Point(3, 3);
			this.pictureBoxKetchup.Name = "pictureBoxKetchup";
			this.pictureBoxKetchup.Size = new System.Drawing.Size(329, 302);
			this.pictureBoxKetchup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxKetchup.TabIndex = 1;
			this.pictureBoxKetchup.TabStop = false;
			// 
			// labelKetchup
			// 
			this.labelKetchup.AutoSize = true;
			this.labelKetchup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelKetchup.Font = new System.Drawing.Font("Horseshoes and Lemonade", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelKetchup.ForeColor = System.Drawing.Color.Red;
			this.labelKetchup.Location = new System.Drawing.Point(3, 308);
			this.labelKetchup.Name = "labelKetchup";
			this.labelKetchup.Size = new System.Drawing.Size(329, 132);
			this.labelKetchup.TabIndex = 2;
			this.labelKetchup.Text = "0 MIAMS";
			this.labelKetchup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelMayo
			// 
			this.labelMayo.AutoSize = true;
			this.labelMayo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMayo.Font = new System.Drawing.Font("Horseshoes and Lemonade", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMayo.ForeColor = System.Drawing.Color.Gold;
			this.labelMayo.Location = new System.Drawing.Point(338, 308);
			this.labelMayo.Name = "labelMayo";
			this.labelMayo.Size = new System.Drawing.Size(330, 132);
			this.labelMayo.TabIndex = 3;
			this.labelMayo.Text = "0 MIAMS";
			this.labelMayo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.WindowText;
			this.ClientSize = new System.Drawing.Size(671, 440);
			this.Controls.Add(this.panelScene);
			this.Font = new System.Drawing.Font("Horseshoes and Lemonade", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Form1";
			this.Text = "Burger Quiz";
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.evenement_clavier);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxScene)).EndInit();
			this.panelScene.ResumeLayout(false);
			this.tableLayoutPanelScore.ResumeLayout(false);
			this.tableLayoutPanelScore.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMayo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxKetchup)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBoxScene;
		private System.Windows.Forms.Panel panelScene;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelScore;
		private System.Windows.Forms.PictureBox pictureBoxMayo;
		private System.Windows.Forms.PictureBox pictureBoxKetchup;
		private System.Windows.Forms.Label labelKetchup;
		private System.Windows.Forms.Label labelMayo;
	}
}

