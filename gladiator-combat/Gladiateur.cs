using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;


namespace gladiatorcombat
{
	public class Gladiateur
	{
		//max equipements points
		private string _nom;
		private int _nbPoint;
		private int _order;
		private bool _turn = true;
		private bool _dead = false;
		private int _malus = 1;
		private List<Equipement> _equipements;
		private List<Equipement> _equipementArmes;
		private List<Equipement> _equipementArmures;
		private Equipe _equipe = new Equipe ();
		private  Ratio _ratio;
	
		public string nom {
			get {
				return _nom;
			}
			set {
				_nom = value;
			}
		}

		public int nbPoint {
			get {
				return _nbPoint;
			}
			set {
				_nbPoint = value;
			}
		}

		public List<Equipement> equipements {
			get {
				return _equipements;
			}
			set {
				_equipements = value;
			}
		}

		public List<Equipement> equipementArmes {
			get {
				return _equipementArmes;
			}
			set {
				_equipementArmes = value;
			}
		}

		public List<Equipement> equipementArmures {
			get {
				return _equipementArmures;
			}
			set {
				_equipementArmures = value;
			}
		}

		public bool dead {
			get {
				return _dead;
			}
			set {
				_dead = value;
			}
		}

		public int malus {
			get {
				return _malus;
			}
			set {
				_malus = value;
			}
		}

		public Equipe equipe {
			get {
				return _equipe;
			}
			set {
				_equipe = value;
			}
		}

		public static int MAX_POINT {
			get {
				return MAX_POINT;
			}
		}

		public int order {
			get {
				return _order;
			}
			set {
				_order = value;
			}
		}

		public bool turn {
			get {
				return _turn;
			}
			set {
				_turn = value;
			}
		}

		public Ratio ratio {
			get {
				return _ratio;
			}
			set {
				_ratio = value;
			}
		}

		public Gladiateur () {
			this.ratio = new Ratio ();
		}

		public Gladiateur (string nom, int order):this()
		{
			this.nom = nom;
			this.order = order;
			this.equipements = new List<Equipement> ();
			this.equipementArmures = new List<Equipement> ();
			this.equipementArmes = new List<Equipement> ();
		}

		public void AddEquipement(Equipement equipement)
		{
			if ((this.nbPoint + equipement.point) <= 10) {
				if (equipement is IAttaquer) 
				{
					this.equipementArmes.Add (equipement);
				}

				if (equipement is IDefense) 
				{
					this.equipementArmures.Add (equipement);
				}
				equipement.gladiateur = this;
				this.equipements.Add (equipement);
				this.nbPoint += equipement.point;
			}
		}

		public Gladiateur attack(Gladiateur gladiateur)
		{
			foreach (Arme arme in this.equipementArmes) 
			{
				int count = 0;
				Console.WriteLine (this.nom+ " donne un coup de "+ arme.nom +" à "+ gladiateur.nom);
				if ( !arme.hit () ) {
					Console.WriteLine ("Le coup ne porte pas.");
					continue;
				}

				if (arme is Filet) {
					Console.WriteLine ("Le coup porte.");
					gladiateur.malus = 2;
					continue;
				}

				foreach (IDefense armure in gladiateur.equipementArmures) 
				{
					count++;
					if ( !armure.flee () && count == gladiateur.equipementArmures.Count) {
						this.ratio.nbWin += 1;
						gladiateur.ratio.nbLoose += 1;
						Console.WriteLine ("Le coup porte, "+ gladiateur.nom +" est hors combat.");
						gladiateur.dead = true;
						return this;
					}
					if (count == gladiateur.equipementArmures.Count) {
						Console.WriteLine ("Le coup porte.");
						Console.WriteLine ("l'armure de "+gladiateur.nom+" bloque le coup");
					}
				}
			}
			gladiateur.turn = true;
			this.turn = false;
			return this;
		}
	}
}

