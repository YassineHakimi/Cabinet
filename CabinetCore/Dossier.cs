using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetCore
{
    public class Dossier
    {
        public int Id { get; set; }
        public string TypeDossier { get; set; }
        public string Tribunal { get; set; }
        public string Jugement { get; set; }
        public Statut StatutDossier { get; set; }

        public Client Client { get; set; }

        public override string ToString()
        {
            return string.Format("Id : {0} Type Dossier : {1} Tribunal : {2} Jugement : {3} Statut : {4}",
                Id, TypeDossier, Tribunal, Jugement, StatutDossier);
        }

    }

    public enum Statut { Cloturé, En_Cours}
}
