using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Materials
{
    //Abstract class for enhirentence for Ships, Hitmarks, Water ETC
    public abstract class Material
    {
        private string type;
        private string design;
        private string hitSound;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Hitsound
        {
            get { return hitSound; }
            private set { hitSound = value; }
        }

        public string Design
        {
            get { return design; }
            set { design = value; }
        }


        /// <summary>
        /// Constructor for material for all the materials
        /// </summary>
        /// <param name="type"></param>
        /// <param name="hitSound"></param>
        public Material(string type, string hitSound)
        {
            this.type = type;
            this.hitSound = hitSound;
            this.design = "■";
        }
    }
}
