using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Zaih : Driver
    {
        public Zaih(RaceCar car) : base(car)
        {

            Name = "Zaih";
            SkillLevel = 100;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
