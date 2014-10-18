using System;

namespace gladiatorcombat
{
	public class Trident:Arme, IDefense
	{
		private double _rateDef;
		#region IDefense implementation

		public double rateDef {
			get {
				return this._rateDef;
			}
			set {
				this._rateDef = value;
			}
		}

		public bool flee ()
		{
			return true;
		}


		#endregion

		public Trident (string nom, int point, int level, double rateAtq, double rateDef)
			:base(nom, point, level, rateAtq)
		{
			this.rateDef = rateDef;
		}



	}
}

