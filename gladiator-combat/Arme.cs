using System;

namespace gladiatorcombat
{
	public class Arme:Equipement, IAttaquer
	{
		private int _level;
		private double _rateAtq;
		#region IAttaquer implementation

		public int level {
			get {
				return this._level;
			}
			set {
				_level = value;
			}
		}

		public double rateAtq {
			get {
				return this._rateAtq;
			}
			set {
				this._rateAtq = value;
			}
		}

		public bool hit ()
		{
			return this.rateRandom (this.rateAtq / gladiateur.malus);
		}

		#endregion
		public Arme (string nom, int point ):base(nom, point){}
		public Arme (string nom, int point, int level, double rateAtq):this(nom, point) {
			this.level = level;
			this.rateAtq = rateAtq;
		}
	}
}

