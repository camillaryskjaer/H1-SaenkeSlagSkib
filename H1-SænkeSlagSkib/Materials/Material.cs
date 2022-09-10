using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Materials
{
    public abstract class Material
    {
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string hitSound;

        public string Hitsound
        {
            get { return hitSound; }
            private set { hitSound = value; }
        }


        public Material(string type, string hitSound)
        {
            this.type = type;
            this.hitSound = hitSound;
        }
    }
}
