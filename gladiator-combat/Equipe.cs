using System;
using System.Collections.Generic;
using System.Linq;

namespace gladiatorcombat
{
	public class Equipe
	{
		private string _nom;
		private string _description;
		private  Ratio _ratio;
		private List<Gladiateur> _gladiateurs;

		public string nom {
			get {
				return _nom;
			}
			set {
				_nom = value;
			}
		}

		public string description {
			get {
				return _description;
			}
			set {
				_description = value;
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

		public List<Gladiateur> gladiateurs {
			get {
				return _gladiateurs;
			}
			set {
				_gladiateurs = value;
			}
		}
			
		public Equipe ()
		{
			this.ratio = new Ratio ();
			this.gladiateurs = new List<Gladiateur> ();
		}

		public Equipe (string nom, string description):this()
		{
			this.nom = nom;
			this.description = description;
		}

		public void addGladiator(Gladiateur gladiateur)
		{
			this.gladiateurs.Add (gladiateur);
			gladiateur.equipe = this;
			if (this.gladiateurs.Count == 3) {
				this.orderGladiators ();
			}
		}
		//order gladiator by order attributes
		public void orderGladiators()
		{
			this.gladiateurs = (from Gladiateur g in this.gladiateurs
				orderby g.order
				select g).ToList ();
		}

	}
}

