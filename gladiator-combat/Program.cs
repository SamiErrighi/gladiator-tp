using System;
using System.Collections;

namespace gladiatorcombat
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//equipements


			//joueur 1
			Joueur joueur1 = new Joueur ("test", "test", "lol");
			Equipe equipe1 = new Equipe ("A", "ma super equipe");
			equipe1.ratio = new Ratio (3, 4);
			joueur1.AddEquipe (equipe1);

			Gladiateur gladiateur1 = new Gladiateur ("A", 1);
			Gladiateur gladiateur2 = new Gladiateur ("B", 2);
			Gladiateur gladiateur3 = new Gladiateur ("C", 3);

			Gladiateur gladiateur4 = new Gladiateur ("D", 1);
			Gladiateur gladiateur5 = new Gladiateur ("E", 2);
			Gladiateur gladiateur6 = new Gladiateur ("F", 3);

			Gladiateur gladiateur7 = new Gladiateur ("G", 1);
			Gladiateur gladiateur8 = new Gladiateur ("H", 2);
			Gladiateur gladiateur9 = new Gladiateur ("I", 3);

			Gladiateur gladiateur10 = new Gladiateur ("J", 1);
			Gladiateur gladiateur11 = new Gladiateur ("K", 2);
			Gladiateur gladiateur12 = new Gladiateur ("L", 3);

			gladiateur1.AddEquipement (Armury.littleShield ());
			gladiateur1.AddEquipement (Armury.helmet ());
			gladiateur1.AddEquipement (Armury.dagger());

			gladiateur2.AddEquipement (Armury.rectangularShield());
			gladiateur2.AddEquipement (Armury.dagger());

			gladiateur3.AddEquipement (Armury.spear());
			gladiateur3.AddEquipement (Armury.helmet());

			gladiateur4.AddEquipement (Armury.trident());
			gladiateur4.AddEquipement (Armury.helmet());

			gladiateur5.AddEquipement (Armury.sword());
			gladiateur5.AddEquipement (Armury.net());
			gladiateur5.AddEquipement (Armury.helmet());

			gladiateur6.AddEquipement (Armury.dagger());
			gladiateur6.AddEquipement (Armury.littleShield());
			gladiateur6.AddEquipement (Armury.helmet());

			gladiateur7.AddEquipement (Armury.dagger());
			gladiateur7.AddEquipement (Armury.helmet());
			gladiateur7.AddEquipement (Armury.sword());

			gladiateur8.AddEquipement (Armury.helmet());
			gladiateur8.AddEquipement (Armury.sword());
			gladiateur8.AddEquipement (Armury.dagger());

			gladiateur9.AddEquipement (Armury.helmet());
			gladiateur9.AddEquipement (Armury.trident());
			gladiateur9.AddEquipement (Armury.dagger());

			gladiateur10.AddEquipement (Armury.helmet());
			gladiateur10.AddEquipement (Armury.trident());
			gladiateur10.AddEquipement (Armury.dagger());

			gladiateur11.AddEquipement (Armury.dagger());
			gladiateur11.AddEquipement (Armury.trident());

			gladiateur12.AddEquipement (Armury.dagger());
			gladiateur12.AddEquipement (Armury.trident());
			//gladiateur1.equipements.Contains (armure1);

			joueur1.equipes[0].addGladiator (gladiateur1);
			joueur1.equipes[0].addGladiator (gladiateur2);
			joueur1.equipes[0].addGladiator (gladiateur3);
			//joueur 2
			Joueur joueur2 = new Joueur ("test2", "test2", "lol2");
			Equipe equipe1_joueur2 = new Equipe ("B", "ma super equipe2");
			equipe1_joueur2.ratio = new Ratio (1, 0);
			joueur2.AddEquipe (equipe1_joueur2);

			joueur2.equipes[0].addGladiator (gladiateur4);
			joueur2.equipes[0].addGladiator (gladiateur5);
			joueur2.equipes[0].addGladiator (gladiateur6);

			//joueur 3
			Joueur joueur3 = new Joueur ("test3", "test3", "lol3");
			Equipe equipe1_joueur3 = new Equipe ("C", "ma super equipe3");
			equipe1_joueur3.ratio = new Ratio (0, 2);
			joueur3.AddEquipe (equipe1_joueur3);

			joueur3.equipes[0].addGladiator (gladiateur7);
			joueur3.equipes[0].addGladiator (gladiateur8);
			joueur3.equipes[0].addGladiator (gladiateur9);

			//joueur 4
			Joueur joueur4 = new Joueur ("test4", "test4", "lol4");
			Equipe equipe1_joueur4 = new Equipe ("D", "ma super equipe4");
			equipe1_joueur4.ratio = new Ratio (4, 4);
			joueur4.AddEquipe (equipe1_joueur4);

			joueur4.equipes[0].addGladiator (gladiateur10);
			joueur4.equipes[0].addGladiator (gladiateur11);
			joueur4.equipes[0].addGladiator (gladiateur12);

			//game instance
			Tournoi tournoi = new Tournoi ();
			tournoi.addEquipe (joueur1.equipes [0]);
			tournoi.addEquipe (joueur2.equipes [0]);
			tournoi.addEquipe (joueur3.equipes [0]);
			tournoi.addEquipe (joueur4.equipes [0]);

			tournoi.startTournoi ();
		}
	}
}
