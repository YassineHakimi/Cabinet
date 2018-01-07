using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetCore
{
    public static class VisiteExtension
    {
        public static double HonoraireVisite(Sujet sujet)
        {
            if (sujet == Sujet.Civil) return 100;
            if (sujet == Sujet.Administratif) return 150;
            if (sujet == Sujet.Constitutionnel) return 200;
            if (sujet == Sujet.Penal) return 250;

            return 0;
        }
    }
}
