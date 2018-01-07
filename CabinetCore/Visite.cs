using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetCore
{
    public class Visite
    {
        public int Id { get; set; }
        public DateTime DateVisite { get; set; }
        public double Honoraire { get; set; }
        public Sujet SujetVisite { get; set; }

        public Client Client { get; set; }


        public override string ToString()
        {
            return "ID : " + Id + " Date Visite : " + DateVisite + " Honoraire : " + Honoraire;
        }

    }

    public enum Sujet
    {
        Civil, Administratif, Constitutionnel, Penal
    }
}
