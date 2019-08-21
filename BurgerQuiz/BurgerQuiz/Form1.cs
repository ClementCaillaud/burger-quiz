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
		private Dictionary<string, string> listeImages = new Dictionary<string, string>();

		public Form1()
		{
			init_liste_images();
			InitializeComponent();
			afficher_image("score");
		}

		private void init_liste_images()
		{
			listeImages.Add("score", "Images/ketchupmayo_old.png");
			listeImages.Add("nuggets", "Images/nuggets.png");
			listeImages.Add("sel_ou_poivre", "Images/seloupoivre.png");
			listeImages.Add("menus", "Images/menus.png");
			listeImages.Add("addition", "Images/addition.png");
			listeImages.Add("burger_de_la_mort", "Images/burger.png");
		}

		private void afficher_image(string key)
		{
			Image img = Image.FromFile(listeImages[key]);
			pictureBox1.Image = img;
		}

		private void evenement_clavier(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Space:
					afficher_image("score");
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
					break;
				case Keys.Down:
					break;
				case Keys.Right:
					break;
				case Keys.Left:
					break;
			}
		}
	}
}
