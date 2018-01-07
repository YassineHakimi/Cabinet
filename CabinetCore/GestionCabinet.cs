using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetCore
{
    public class GestionCabinet
    {
        public List<Client> Clients = new List<Client>();
        public List<Dossier> Dossiers = new List<Dossier>();
        public List<Visite> Visites = new List<Visite>();

        public bool ClientExistant(string nom, string prenom)
        {
            return Clients.Exists(c => c.Nom.Equals(nom) && c.Prenom.Equals(prenom));
        }

        public void AjoutClient(Client client)
        {
            Clients.Add(client);
        }

        public void AjouterVisite(double honoraire, int id)
        {
            if (honoraire >= 0)
            {
                if (Clients.Exists(c => c.Id == id))
                {
                    var visite = new Visite { Honoraire = honoraire };
                    Visites.Add(visite);
                }
                else
                {
                    throw new ClientNonTrouve("Client non trouvé !!");
                }
            }
            
        }

        public void SupprimerDossier()
        {
            Dossiers.RemoveAll(d => d.StatutDossier == Statut.Cloturé);
        }
    }
}
