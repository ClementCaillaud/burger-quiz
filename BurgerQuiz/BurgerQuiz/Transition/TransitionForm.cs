using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BurgerQuiz
{
    public partial class TransitionForm : Form
    {
        private MainForm mainForm;
        private Dictionary<ETransition, Transition> listeTransitions;
        private Transition transitionToShow;

        public TransitionForm(MainForm parent)
        {
            InitializeComponent();
            mainForm = parent;
            MdiParent = parent;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;

            listeTransitions = new Dictionary<ETransition, Transition>()
            {
                { ETransition.NUGGETS,              new Transition("Transition/Images/nuggets.png",     "Transition/Videos/nuggets-transition.mp4") },
                { ETransition.SEL_OU_POIVRE,        new Transition("Transition/Images/seloupoivre.png", "Transition/Videos/selt-pepper-transition.mp4") },
                { ETransition.MENUS,                new Transition("Transition/Images/menus.png",       "Transition/Videos/menus-transition.mp4") },
                { ETransition.ADDITION,             new Transition("Transition/Images/addition.png",    "Transition/Videos/addition-transition.mp4") },
                { ETransition.BURGER_DE_LA_MORT,    new Transition("Transition/Images/burger.png",      "Transition/Videos/death-burger-transition.mp4") }
            };
        }

        /// <summary>
        /// Play a transition
        /// </summary>
        /// <param name="nom">Transition to show</param>
        public void ShowTransition(ETransition nom)
        {
            transitionToShow = listeTransitions[nom];

            if (transitionToShow.Video != "")
            {
                ShowVideo();
            }
            else if (transitionToShow.Image != "")
            {
                ShowImage();
            }
        }

        /// <summary>
        /// Show image transition
        /// </summary>
        private void ShowImage()
        {
            if (transitionToShow.Image != "")
            {
                VideoPlayer.Hide();
                PictureBox.Show();
                Image img = Image.FromFile(transitionToShow.Image);
                PictureBox.Image = img;
                PictureBox.Show();
            }
        }

        /// <summary>
        /// Play video transition
        /// </summary>
        private void ShowVideo()
        {
            if (transitionToShow.Video != "")
            {
                PictureBox.Hide();
                VideoPlayer.Show();
                VideoPlayer.URL = transitionToShow.Video;
                VideoPlayer.Ctlcontrols.play();
            }
        }

        /// <summary>
        /// Event when keyboard pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransitionForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    mainForm.ShowScore(this);
                    break;
            }
        }

        /// <summary>
        /// Event when video state change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VideoPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(e.newState == 8)
            {
                ShowImage();
            }
        }
    }
}
