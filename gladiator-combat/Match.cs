using System;
using System.Collections.Generic;
using System.Linq;
namespace gladiatorcombat
{
	public class Match
	{
		private Equipe _equipe1;
		private Equipe _equipe2;
		private Equipe _winner;
		private Duel _duel; //set to the current duel
		private List<Duel> _duelist;

		public Equipe equipe1 {
			get {
				return _equipe1;
			}
			set {
				_equipe1 = value;
			}
		}

		public Equipe equipe2 {
			get {
				return _equipe2;
			}
			set {
				_equipe2 = value;
			}
		}
			
		public Equipe winner {
			get {
				return _winner;
			}
			set {
				_winner = value;
			}
		}

		public List<Duel> duelist {
			get {
				return _duelist;
			}
			set {
				_duelist = value;
			}
		}

		public Match (){
			this.duelist = new List<Duel> ();
		}


		public Match (Equipe equipe1):this()
		{
			this.equipe1 = equipe1;
		}

		public Match (Equipe equipe1, Equipe equipe2):this(equipe1)
		{
			this.equipe2 = equipe2;
		}

		//start duel
		public void start()
		{
			Console.WriteLine ("Equipe " + this.equipe1.nom + " contre équipe " + this.equipe2.nom);
			Equipe winner = this.gladiatorsFight (this.equipe1.gladiateurs, this.equipe2.gladiateurs);
			Console.WriteLine ("Equipe " + winner.nom + " gagne le match.");

		}
		public Equipe gladiatorsFight(List<Gladiateur> gladiators1,List<Gladiateur> gladiators2 ) {
			bool over = false;
			Gladiateur gladiatorWinner = null;

			//filter gladitors by death
			gladiators1 = this.filterGladiators (gladiators1);
			gladiators2 = this.filterGladiators (gladiators2);

			//check if gladiators is all dead
			if (gladiators1.Count == 0) {
				this.winner = this.equipe2;
				this.equipe2.ratio.nbWin += 1;
				this.equipe1.ratio.nbLoose += 1;
				return this.winner;
			} else if (gladiators2.Count == 0) {
				this.winner = this.equipe1;
				this.equipe1.ratio.nbWin += 1;
				this.equipe2.ratio.nbLoose += 1;
				return this.winner;
			}

			//start fight
			foreach (Gladiateur gladiator1 in gladiators1) 
			{
				if (over) {break;}
				foreach (Gladiateur gladiator2 in gladiators2) 
				{
					Console.WriteLine ("Duel " + (this.duelist.Count + 1));
					this._duel = new Duel (gladiator1, gladiator2);
					this.duelist.Add (this._duel);
					if (this._duel.equality) {
						over = true;
						break;
					}
					if (this._duel.winner != gladiator1 || this._duel.finish) {
						gladiatorWinner = gladiator1;
						over = true;
						break;
					}
				}
			}

			//check the result of fight
			if (this._duel.equality || gladiatorWinner == this._duel.winner) {
				this.gladiatorsFight (gladiators1, gladiators2);
			}else{
				this.gladiatorsFight (gladiators2, gladiators1);
			}

			return this.winner;
		}

		private List<Gladiateur> filterGladiators (List<Gladiateur> gladiators) {
			gladiators = (from Gladiateur g in gladiators
				where g.dead == false
				select g).ToList ();
			return gladiators;
		}
	
	}
}

