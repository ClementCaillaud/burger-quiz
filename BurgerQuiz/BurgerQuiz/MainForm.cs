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
    public partial class MainForm : Form
    {
        private TransitionForm transitionForm;
        private ScoreForm scoreForm;

        public MainForm()
        {
            InitializeComponent();
            
            scoreForm = new ScoreForm(this);
            ShowScore();
        }

        /// <summary>
        /// Show transition form
        /// </summary>
        /// <param name="nom">Transition to show</param>
        public void ShowTransition(ETransition nom)
        {
            scoreForm.Hide();
            transitionForm = new TransitionForm(this);
            transitionForm.Show();
            transitionForm.ShowTransition(nom);
        }

        /// <summary>
        /// Show score form, don't forget to close transition form if video was played
        /// </summary>
        public void ShowScore()
        {
            scoreForm.Show();
        }
        public void ShowScore(TransitionForm transitionForm)
        {
            transitionForm.Close();
            ShowScore();
        }
    }
}
