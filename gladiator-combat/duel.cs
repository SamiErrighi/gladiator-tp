using System;
using System.Collections;

namespace gladiatorcombat
{
	public class Duel
	{
		private Gladiateur _gladiateur1;
		private Gladiateur _gladiateur2;
		private Gladiateur _winner;
		private Gladiateur _looser;
		private bool _finish = false;
		private bool _equality;

		public Gladiateur gladiateur1 {
			get {
				return _gladiateur1;
			}
			set {
				_gladiateur1 = value;
			}
		}

		public Gladiateur gladiateur2 {
			get {
				return _gladiateur2;
			}
			set {
				_gladiateur2 = value;
			}
		}

		public Gladiateur winner {
			get {
				return _winner;
			}
			set {
				_winner = value;
			}
		}

		public Gladiateur looser {
			get {
				return _looser;
			}
			set {
				_looser = value;
			}
		}

		public bool equality {
			get {
				return _equality;
			}
			set {
				_equality = value;
			}
		}

		public bool finish {
			get {
				return _finish;
			}
			set {
				_finish = value;
			}
		}

		public Duel (Gladiateur gladiateur1, Gladiateur gladiateur2)
		{
			this.gladiateur1 = gladiateur1;
			this.gladiateur2 = gladiateur2;
			this.startDuel ();
		}

		//start duel 20 turn max
		public void startDuel()
		{
			for (int i = 0; i <= 20; i++) 
			{
				if (this.gladiateur2.dead || this.gladiateur1.dead) {
					this.resetDuel ();
					this.winner = this.gladiateur1;
					this.looser = this.gladiateur2;
					if (this.gladiateur1.dead) 
					{
						this.winner = this.gladiateur2;
						this.looser = this.gladiateur1;
					}
					break;
				}
				if (this.gladiateur1.turn) {
					this.gladiateur1.attack (this.gladiateur2);

				} else {
					this.gladiateur2.attack (this.gladiateur1);
				}
			}

			if (!this.gladiateur2.dead && !this.gladiateur1.dead) 
			{
				this.setEquality ();
				this.resetDuel ();
			}
		}

		//reset malus for gladitors
		public void resetDuel() {
			this.gladiateur1.malus = 1;
			this.gladiateur2.malus = 1;
			this._finish = true;
		}

		//if no winner set equality
		public void setEquality() {
			this.equality = true;
			this.gladiateur1.ratio.nbEquality += 1;
			this.gladiateur2.ratio.nbEquality += 1;
			this.gladiateur1.dead = true;
			this.gladiateur2.dead = true;
		}
	}
}

