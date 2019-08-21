using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerQuiz
{
	class Equipe
	{
		private string nom;
		private int score;

		public Equipe(string nom)
		{
			this.nom = nom;
			this.score = 0;
		}

		public void ajouter_score(int valeur)
		{
			score += valeur;
		}

		public int get_score()
		{
			return score;
		}
	}
}
