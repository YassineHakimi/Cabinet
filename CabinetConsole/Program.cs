using CabinetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client
            {
                Id = 1,
                Nom = "ben ahmed",
                Prenom = "ahmed",
                Adresse = "22 sdd",
                NumTel = "212121",
                DateNaissance = DateTime.Parse("18/04/1995")
            };

            Client c2 = new Client
            {
                Id = 2,
                Nom = "ben mohamed",
                Prenom = "mohamed",
                Adresse = "45 sazd",
                NumTel = "2555521",
                DateNaissance = DateTime.Parse("19/06/1980")
            };

            Visite v1 = new Visite
            {
                Id = 1,
                DateVisite = DateTime.Parse("19/06/2017"),
                SujetVisite = Sujet.Civil
            };

            Visite v2 = new Visite
            {
                Id = 2,
                DateVisite = DateTime.Parse("19/08/2017"),
                SujetVisite = Sujet.Penal
            };

            Visite v3 = new Visite
            {
                Id = 3,
                DateVisite = DateTime.Parse("25/06/2017"),
                SujetVisite = Sujet.Constitutionnel
            };

            Visite v4 = new Visite
            {
                Id = 4,
                DateVisite = DateTime.Parse("19/08/2004"),
                SujetVisite = Sujet.Administratif
            };

            c1.Visites = new List<Visite> { v1, v2 };
            c2.Visites = new List<Visite> { v3, v4 };

            // Test dernière question
            var frais = VisiteExtension.HonoraireVisite(c1.Visites.ElementAt(1).SujetVisite);
            Console.WriteLine("les frais : " + frais);


            // Test d'ajouter visite de la classe Gestion Cabinet
            GestionCabinet gestion = new GestionCabinet();
            gestion.Clients.Add(c1);
            gestion.Clients.Add(c2);

            try
            {
                gestion.AjouterVisite(200, 3);
            }
            catch (ClientNonTrouve ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
