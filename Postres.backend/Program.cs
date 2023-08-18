using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Postres.backend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Postres postre = new Postre();
            postre.menu();

        }
    }
}
