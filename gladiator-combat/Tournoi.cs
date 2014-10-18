using System;
using System.Collections.Generic;
using System.Linq;
namespace gladiatorcombat
{
	public class Tournoi
	{
		private List<Equipe> _equipes;
		private List<Match> _matchs;

		public List<Equipe> equipes {
			get {
				return _equipes;
			}
			set {
				_equipes = value;
			}
		}

		public List<Match> matchs {
			get {
				return _matchs;
			}
			set {
				_matchs = value;
			}
		}

		public Tournoi ()
		{
			this.equipes = new List<Equipe> ();
			this.matchs = new List<Match> ();
		}

		public void addEquipe (Equipe equipe)
		{
			this.equipes.Add (equipe);
		}

		public void startTournoi()
		{
			if (this.equipes.Count % 2 == 0) {
				this.order ();
				this.startMatch ();
			} else {
				Console.WriteLine ("pas asser de joueur");
			}
		}

		//order equipes by ratio Victory
		private void order()
		{
			this.equipes = (from Equipe e in this.equipes
				orderby e.ratio.ratioVictory() descending
			                select e).ToList ();
			this.instanceMatch ();
		}

		//set matchs
		private void instanceMatch()
		{
			for (int i = 0; i < (this.equipes.Count); i += 2) 
			{
				Match match = new Match ();
				match.equipe1 = this.equipes [i];
				match.equipe2 = this.equipes [i + 1];
				this.matchs.Add (match);
			}
		}
		//start the tournament
		private void startMatch()
		{
			Console.WriteLine ("Le tournoi commence, les combats suivant vont avoir lieu :");
			foreach (Match match in this.matchs) {
				Console.WriteLine ("l'équipe " + match.equipe1.nom + " contre l'équipe " + match.equipe2.nom);
			}

			Console.WriteLine ("Commençons les combats");
			foreach (Match match in this.matchs) {
				match.start ();
			}
		}
	}
}

