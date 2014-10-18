using System;

namespace gladiatorcombat
{
	public class Equipement
	{
		protected string _nom;
		protected int _point;
		protected Random _random = new Random();
		protected Gladiateur _gladiateur;
		public string nom {
			get {
				return _nom;
			}
			set {
				_nom = value;
			}
		}

		public int point {
			get {
				return _point;
			}
			set {
				_point = value;
			}
		}


		public Random random {
			get {
				return _random;
			}
			set {
				_random = value;
			}
		}

		public Gladiateur gladiateur {
			get {
				return _gladiateur;
			}
			set {
				_gladiateur = value;
			}
		}

		public Equipement (string nom, int point)
		{
			this.nom = nom;
			this.point = point;
		}

		protected bool rateRandom (double rate) {
			double rand = this.random.NextDouble();
			bool result =  rand <= rate / 100;
			rand = 0;
			return result;
		}

	}
}

