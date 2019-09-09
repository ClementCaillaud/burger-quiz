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
		private Dictionary<string, string> listeImages, listeVideos;
		private Equipe equipeKetchup, equipeMayo;
		private bool modeVideo;

		public Form1()
		{
			//Mode d'affichage des transitions
			modeVideo = false;
			//Initialisation de la liste des images
			listeImages = new Dictionary<string, string>()
			{
				{"ketchup",             "Images/ketchup.png"},
				{"mayo",                "Images/mayo.png"},
				{"nuggets",             "Images/nuggets.png"},
				{"sel_ou_poivre",       "Images/seloupoivre.png"},
				{"menus",               "Images/menus.png"},
				{"addition",            "Images/addition.png"},
				{"burger_de_la_mort",   "Images/burger.png"}
			};
			//Initialisation de la liste des vidéos
			listeVideos = new Dictionary<string, string>()
			{
				{"generique",           "Videos/generique"},
				{"nuggets",             "Videos/nuggets"},
				{"sel_ou_poivre",       "Videos/seloupoivre"},
				{"menus",               "Videos/menus"},
				{"addition",            "Videos/addition"},
				{"burger_de_la_mort",   "Videos/burger"}
			};
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
			Image img = Image.FromFile(listeImages[key]);
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
			Image imgKetchup = Image.FromFile(listeImages["ketchup"]);
			Image imgMayo = Image.FromFile(listeImages["mayo"]);
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
			VideoPlayer.URL = listeVideos[key];
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
					if(modeVideo)
					{
						Afficher_video("nuggets");
					}
					else
					{
						Afficher_image("nuggets");
					}
					break;
				case Keys.S:
					if (modeVideo)
					{
						Afficher_video("sel_ou_poivre");
					}
					else
					{
						Afficher_image("sel_ou_poivre");
					}
					break;
				case Keys.M:
					if(modeVideo)
					{
						Afficher_video("menus");
					}
					else
					{
						Afficher_image("menus");
					}
					break;
				case Keys.A:
					if (modeVideo)
					{
						Afficher_video("addition");
					}
					else
					{
						Afficher_image("addition");
					}
					break;
				case Keys.B:
					if (modeVideo)
					{
						Afficher_video("burger_de_la_mort");
					}
					else
					{
						Afficher_image("burger_de_la_mort");
					}
					break;
				case Keys.G:
					if(modeVideo)
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
