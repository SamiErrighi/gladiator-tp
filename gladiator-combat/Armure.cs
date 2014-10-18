using System;

namespace gladiatorcombat
{
	public class Armure:Equipement,  IDefense
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
			bool result = this.rateRandom (this.rateDef);
			return result;

		}

		#endregion

		public Armure (string nom, int point, double rateDef):base(nom, point){
			this.rateDef = rateDef;
		}

	}
}

