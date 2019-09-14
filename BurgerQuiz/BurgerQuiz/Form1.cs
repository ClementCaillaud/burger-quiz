using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerQuiz
{
	public partial class Form1 : Form
	{
		private Equipe equipeKetchup, equipeMayo;
		private IniFile configFile;

		public Form1()
		{
			//Récupération du fichier de configuration
			configFile = new IniFile("config.ini");
			//Création des équipes
			equipeKetchup = new Equipe();
			equipeMayo = new Equipe();
			//Initialisation de l'affichage
			InitializeComponent();
			//Affichage du score comme premier écran
			Afficher_score();
		}

		/// <summary>
		/// Affiche une image de transition
		/// </summary>
		/// <param name="key">Nom de l'image à charger</param>
		private void Afficher_image(string key)
		{
			//Stopper la vidéo (pas sûr que ce soit nécessaire mais on sait jamais)
			VideoPlayer.Ctlcontrols.stop();
			//Récupération de l'image voulue
			Image img = Image.FromFile(configFile.GetValue("PATH_IMAGE", key));
			pictureBoxScene.Image = img;
			//Cacher et afficher les bons conteneurs
			tableLayoutPanelScore.Visible = false;
			VideoPlayer.Visible = false;
			pictureBoxScene.Visible = true;
		}

		/// <summary>
		/// Affiche le score de chaque équipe
		/// </summary>
		private void Afficher_score()
		{
			//Stopper la vidéo (pas sûr que ce soit nécessaire mais on sait jamais)
			VideoPlayer.Ctlcontrols.stop();
			//Récupération des 2 images ketchup et mayo
			Image imgKetchup = Image.FromFile(configFile.GetValue("PATH_IMAGE", "ketchup"));
			Image imgMayo = Image.FromFile(configFile.GetValue("PATH_IMAGE", "mayo"));
			pictureBoxKetchup.Image = imgKetchup;
			pictureBoxMayo.Image = imgMayo;
			//Cacher et afficher les bons conteneurs
			VideoPlayer.Visible = false;
			pictureBoxScene.Visible = false;
			tableLayoutPanelScore.Visible = true;
		}

		/// <summary>
		/// Affiche une vidéo de transition
		/// </summary>
		/// <param name="key">Nom de la vidéo à charger</param>
		private void Afficher_video(string key)
		{
			//Stopper la vidéo (pas sûr que ce soit nécessaire mais on sait jamais)
			VideoPlayer.Ctlcontrols.play();
			//Attribution de l'URL de la vidéo
			VideoPlayer.URL = configFile.GetValue("PATH_VIDEO", key);
			//Cacher et afficher les bons conteneurs
			pictureBoxScene.Visible = false;
			tableLayoutPanelScore.Visible = false;
			VideoPlayer.Visible = true;
			//Démarrer la lecture
			VideoPlayer.Ctlcontrols.play();
		}

		/// <summary>
		/// Mise à jour de la taille de la police du score, en fonction de la taille de la fenêtre
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RedimensionnementLabel(object sender, EventArgs e)
		{
			float taillePolice = labelKetchup.Width / labelKetchup.Height + 50;
			labelKetchup.Font = new System.Drawing.Font(labelKetchup.Font.Name, taillePolice);
			labelMayo.Font = new System.Drawing.Font(labelMayo.Font.Name, taillePolice);
		}

		/// <summary>
		/// Met à jour l'affichage du score des deux équipes
		/// </summary>
		private void Maj_label_score()
		{
			labelKetchup.Text = equipeKetchup.Score + " MIAMS";
			labelMayo.Text = equipeMayo.Score + " MIAMS";
		}

		/// <summary>
		/// Ajuste manuellement la taille de la police en incrémentant ou décrémentant
		/// </summary>
		/// <param name="valeur"></param>
		private void Ajuster_police_manuellement(int valeur)
		{
			float taillePolice = (labelKetchup.Font.Size + valeur) > 1 ? labelKetchup.Font.Size + valeur : 1;
			labelKetchup.Font = new System.Drawing.Font(labelKetchup.Font.Name, taillePolice);
			labelMayo.Font = new System.Drawing.Font(labelMayo.Font.Name, taillePolice);
		}

		/// <summary>
		/// Affiche une scène en mode vidéo ou image en fonction du mode de lecture paramétré
		/// </summary>
		/// <param name="nom"></param>
		private void Afficher(string nom)
		{
			if(configFile.GetValue("PARAM", "modeVideo") == "1")
			{
				Afficher_video(nom);
			}
			else
			{
				Afficher_image(nom);
			}
		}

		/// <summary>
		/// Gestion des événements clavier
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Evenement_clavier(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Space:
					Afficher_score();
					break;
				case Keys.N:
					Afficher("nuggets");
					break;
				case Keys.S:
					Afficher("sel_ou_poivre");
					break;
				case Keys.M:
					Afficher("menus");
					break;
				case Keys.A:
					Afficher("addition");
					break;
				case Keys.B:
					Afficher("burger_de_la_mort");
					break;
				case Keys.G:
					if(configFile.GetValue("PARAM", "modeVideo") == "1")
					{
						Afficher_video("generique");
					}
					break;
				case Keys.Up:
					equipeKetchup.Score += 1;
					Maj_label_score();
					break;
				case Keys.Down:
					equipeKetchup.Score -= 1;
					Maj_label_score();
					break;
				case Keys.Right:
					equipeMayo.Score += 1;
					Maj_label_score();
					break;
				case Keys.Left:
					equipeMayo.Score -= 1;
					Maj_label_score();
					break;
				case Keys.Add:
					Ajuster_police_manuellement(10);
					break;
				case Keys.Subtract:
					Ajuster_police_manuellement(-10);
					break;
			}
		}
	}
}
