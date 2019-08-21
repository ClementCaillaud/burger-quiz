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
		private Dictionary<string, string> listeImages;
		private Equipe equipeKetchup, equipeMayo;

		public Form1()
		{
			init_liste_images();
			equipeKetchup = new Equipe("ketchup");
			equipeMayo = new Equipe("mayo");
			InitializeComponent();
			afficher_score();
		}

		/// <summary>
		/// Initialise les liens vers les différentes images
		/// </summary>
		private void init_liste_images()
		{
			listeImages = new Dictionary<string, string>();
			listeImages.Add("ketchup", "Images/ketchup.png");
			listeImages.Add("mayo", "Images/mayo.png");
			listeImages.Add("nuggets", "Images/nuggets.png");
			listeImages.Add("sel_ou_poivre", "Images/seloupoivre.png");
			listeImages.Add("menus", "Images/menus.png");
			listeImages.Add("addition", "Images/addition.png");
			listeImages.Add("burger_de_la_mort", "Images/burger.png");
		}

		/// <summary>
		/// Affiche une image de transition
		/// </summary>
		/// <param name="key">Nom de l'image à charger</param>
		private void afficher_image(string key)
		{
			Image img = Image.FromFile(listeImages[key]);
			pictureBoxScene.Image = img;
			tableLayoutPanelScore.Visible = false;
			pictureBoxScene.Visible = true;
		}

		/// <summary>
		/// Affiche le score de chaque équipe
		/// </summary>
		private void afficher_score()
		{
			Image imgKetchup = Image.FromFile(listeImages["ketchup"]);
			Image imgMayo = Image.FromFile(listeImages["mayo"]);
			pictureBoxKetchup.Image = imgKetchup;
			pictureBoxMayo.Image = imgMayo;
			pictureBoxScene.Visible = false;
			tableLayoutPanelScore.Visible = true;
		}

		/// <summary>
		/// Met à jour l'affichage du score des deux équipes
		/// </summary>
		private void maj_label_score()
		{
			labelKetchup.Text = equipeKetchup.get_score() + " MIAMS";
			labelMayo.Text = equipeMayo.get_score() + " MIAMS";
		}

		/// <summary>
		/// Gestion des événements clavier
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void evenement_clavier(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Space:
					afficher_score();
					break;
				case Keys.N:
					afficher_image("nuggets");
					break;
				case Keys.S:
					afficher_image("sel_ou_poivre");
					break;
				case Keys.M:
					afficher_image("menus");
					break;
				case Keys.A:
					afficher_image("addition");
					break;
				case Keys.B:
					afficher_image("burger_de_la_mort");
					break;
				case Keys.Up:
					equipeKetchup.ajouter_score(1);
					maj_label_score();
					break;
				case Keys.Down:
					equipeKetchup.ajouter_score(-1);
					maj_label_score();
					break;
				case Keys.Right:
					equipeMayo.ajouter_score(1);
					maj_label_score();
					break;
				case Keys.Left:
					equipeMayo.ajouter_score(-1);
					maj_label_score();
					break;
			}
		}
	}
}
