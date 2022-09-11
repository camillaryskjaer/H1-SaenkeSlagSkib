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

        private readonly ShipEnum ship;
        private int length;
        private int health;


        public int Health   
        {
            get { return health; }
            protected internal set { health = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// Constructor for ships, not abstract, cause this is the one i use for all my ships, cause i saw no reason to have 5 empty constructors for the different type of ships, cause nothing new would be added, so i define the ship with an enum
        /// </summary>
        /// <param name="ship"></param>
        /// <param name="length"></param>
        public Ship(ShipEnum ship, int length):base("Ship","Hit!!")
        {
            this.ship = ship;
            this.length = length;
            this.health = length;

        }
        protected internal void HitHealth()
        {
            health -= 1;
        }
    }
}
