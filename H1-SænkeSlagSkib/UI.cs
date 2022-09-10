using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib
{
    internal class UI
    {
        public UI()
        {

        }
        public string WriteConsole(string response)
        {
            Console.WriteLine(response);
            return(Console.ReadLine());
        }
    }
}
