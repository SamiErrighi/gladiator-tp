using System;
using System.Collections.Generic;

namespace gladiatorcombat
{
	public class Joueur
	{
		private string _nom;
		private string _prenom;
		private string _pseudo;
		private DateTime _inscription;
		private List<Equipe> _equipes;
		private Equipe _currentEquipe;

		//getter/setter
		public string nom {
			get {
				return _nom;
			}
			set {
				_nom = value;
			}
		}

		public string prenom {
			get {
				return _prenom;
			}
			set {
				_prenom = value;
			}
		}

		public string pseudo {
			get {
				return _pseudo;
			}
			set {
				_pseudo = value;
			}
		}

		public DateTime inscription {
			get {
				return _inscription;
			}
			set {
				_inscription = value;
			}
		}

		public List<Equipe> equipes {
			get {
				return _equipes;
			}
			set {
				_equipes = value;
			}
		}

		public Equipe currentEquipe {
			get {
				return _currentEquipe;
			}
			set {
				_currentEquipe = value;
			}
		}

		public Joueur()
		{
			this.inscription = DateTime.Now;
			this.equipes = new List<Equipe> ();
		}

		public Joueur (string nom, string prenom, string pseudo)
			:this()
		{
			this.nom = nom;
			this.prenom = prenom;
			this.pseudo = pseudo;
		}

		public Joueur (string nom, string prenom, string pseudo,  List<Equipe> equipes)
			:this(nom, prenom, pseudo)
		{
			this.equipes = equipes;
		}
		//add equipe to collection
		public void AddEquipe(Equipe equipe)
		{
			if (this.equipes.Count < 5) {
				this.equipes.Add (equipe);
			}
		}

		//define the current equipe for the game
		public void selectEquipe(Equipe equipe)
		{
			this.currentEquipe = equipe;
		}
	}
}

