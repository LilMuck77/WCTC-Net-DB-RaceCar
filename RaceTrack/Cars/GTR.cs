using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class GTR : RaceCar
    {
		public GTR()
		{
			Name = "GTR";
			TopSpeed = 140;
		}
		public override void StartEngine()
		{
			Console.WriteLine($"The {Name} goes VVROOOOM VVROOOOM!");
		}
	}
}
