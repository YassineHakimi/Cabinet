using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetCore
{
    public class Client
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string NumTel { get; set; }


        public ICollection<Dossier> Dossiers { get; set; }
        public ICollection<Visite> Visites { get; set; }

        public override string ToString()
        {
            return string.Format("Id : {0} Nom : {1} Prenom : {2} Date de naissance : {3} Adresse : {4} NumTel : {5}",
                Id, Nom, Prenom, DateNaissance, Adresse, NumTel);
        }

    }
}
