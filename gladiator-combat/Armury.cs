using System;

namespace gladiatorcombat
{
	public class Armury
	{
		public static Armure littleShield() {
			return new Armure ("petit bouclier rond", 5, 20);
		}

		public static Armure rectangularShield() {
			return new Armure ("bouclier rectangulaire", 8, 30);
		}

		public static Armure helmet() {
			return new Armure ("casque", 2, 10);
		}

		public static Arme dagger() {
			return new Arme ("Dague", 2, 5, 60);
		}

		public static Arme sword() {
			return new Arme ("épée", 5, 4, 70);
		}

		public static Arme spear() {
			return new Arme ("lance", 7, 2, 50);
		}

		public static Filet net() {
			return new Filet("filet", 3, 1, 30);
		}

		public static Trident trident() {
			return new Trident ("trident", 7, 3, 40, 10);
		}
	}
}
