using System;

namespace gladiatorcombat
{
	public class Ratio
	{
		private int _nbWin;
		private int _nbLoose;
		private int _nbEquality;

		public int nbLoose {
			get {
				return _nbLoose;
			}
			set {
				_nbLoose = value;
			}
		}

		public int nbWin {
			get {
				return _nbWin;
			}
			set {
				_nbWin = value;
			}
		}

		public int nbEquality {
			get {
				return _nbEquality;
			}
			set {
				_nbEquality = value;
			}
		}

		public Ratio ()
		{
		}

		public Ratio(int nbWin):this() 
		{
			this.nbWin = nbWin;
		}

		public Ratio(int nbWin, int nbLoose):this(nbWin)
		{
			this.nbLoose = nbLoose;
		}

		public int ratioVictory () {
			Console.WriteLine ((this.nbWin * 100) / (this.nbWin + this.nbLoose));
			return (this.nbWin * 100) / (this.nbWin + this.nbLoose);
		}
	}
}

