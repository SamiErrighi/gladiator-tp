using System;

namespace gladiatorcombat
{
	public interface IAttaquer
	{
		int level { get; set;}
		double rateAtq { get; set;}
	
		bool hit();
	}
}

