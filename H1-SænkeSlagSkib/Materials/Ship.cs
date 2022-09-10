using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Materials
{
    internal class Ship:Material
    {

        protected internal enum ShipEnum
        {
            HangarSkib,
            SlagSkib,
            Destroyer,
            Ubåd,
            PatruljeBåd
        }

        protected internal ShipEnum ship;
        protected internal int length;
        private int health;

        public int Health   
        {
            get { return health; }
            protected internal set { health = value; }
        }

        public Ship(ShipEnum ship, int length):base("Ship","Hit!!")
        {
            this.ship = ship;
            this.length = length;
            this.health = length;

        }
        protected internal void HitHealth()
        {
            Health -= 1;
        }
    }
}
