using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

namespace BurgerQuiz
{
    public partial class ScoreForm : Form
    {
        private MainForm mainForm;
        private Dictionary<Keys, ETransition> keysTransitionBinding;
        private int scoreKetchup;
        private int scoreMayo;
        private FontFamily customFontFamily;

        public ScoreForm(MainForm parent)
        {
            //Initialisation des paramètres
            InitializeComponent();
            mainForm = parent;
            MdiParent = parent;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

            //Touches du clavier déclenchant les transitions
            keysTransitionBinding = new Dictionary<Keys, ETransition>()
            {
                { Keys.N, ETransition.NUGGETS },
                { Keys.S, ETransition.SEL_OU_POIVRE },
                { Keys.M, ETransition.MENUS },
                { Keys.A, ETransition.ADDITION },
                { Keys.B, ETransition.BURGER_DE_LA_MORT }
            };

            //Initialisation des scores
            scoreKetchup = 0;
            scoreMayo = 0;

            //Création de la police personnalisée
            customFontFamily = LoadCustomFont();
            KetchupScoreLabel.Font = new Font(customFontFamily, 30);
            MayoScoreLabel.Font = new Font(customFontFamily, 30);
        }

        /// <summary>
        /// Load custom burger quiz font
        /// </summary>
        /// <returns>Burger Quiz font family</returns>
        private FontFamily LoadCustomFont()
        {
            //Garde les polices en mémoire
            PrivateFontCollection pfc = new PrivateFontCollection();
            //Lire la police
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("BurgerQuiz.horseshoeslemonade.ttf");
            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();
            //Sauvegarde de la police dans la collection
            unsafe
            {
                fixed (byte * pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }
            return pfc.Families[0];
        }

        /// <summary>
        /// Update score display
        /// </summary>
        private void UpdateScoreDisplay()
        {
            KetchupScoreLabel.Text = scoreKetchup + " MIAMS";
            MayoScoreLabel.Text = scoreMayo + " MIAMS";
        }

        /// <summary>
        /// Event when keyboard pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //TRANSITIONS
            if (keysTransitionBinding.ContainsKey(e.KeyCode))
            {
                mainForm.ShowTransition(keysTransitionBinding[e.KeyCode]);
            }
            else
            {
                switch (e.KeyCode)
                {
                    //SCORE
                    case Keys.Up:
                        scoreKetchup++;
                        break;
                    case Keys.Down:
                        scoreKetchup--;
                        break;
                    case Keys.Right:
                        scoreMayo++;
                        break;
                    case Keys.Left:
                        scoreMayo--;
                        break;
                    //TAILLE POLICE
                    case Keys.Add:
                        AjusterTaillePolice(10);
                        break;
                    case Keys.Subtract:
                        AjusterTaillePolice(-10);
                        break;
                }
                UpdateScoreDisplay();
            }
        }

        /// <summary>
        /// Change font size
        /// </summary>
        /// <param name="valeur"></param>
        private void AjusterTaillePolice(float valeur)
        {
            float taillePolice = (KetchupScoreLabel.Font.Size + valeur) > 1 ? KetchupScoreLabel.Font.Size + valeur : 1;
            KetchupScoreLabel.Font = new Font(customFontFamily, taillePolice);
            MayoScoreLabel.Font = new Font(customFontFamily, taillePolice);
        }
    }
}
