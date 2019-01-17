using PelaezAutoPartsDiego.Models;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PelaezAutoPartsDiego.Utility
{
    public class Validation
    {

        public static Usager ValidationUsager (Usager usagerCourant)
        {
            string[] UsagerEtPass;
            string[] InfoUsagerCourant; 

            TraiteFichierUsager line = new TraiteFichierUsager();

            UsagerEtPass = line.splitLineUsager();
            if (usagerCourant.UsagerP.Equals(UsagerEtPass[0]) && (usagerCourant.Password.Equals(UsagerEtPass[1])))
            {
                InfoUsagerCourant = line.GetInfoCompleteUsager(UsagerEtPass[3]);
                Usager UsagerCourant = new Usager
                {
                    Id = int.Parse(InfoUsagerCourant[0]),
                    Nom = InfoUsagerCourant[1],
                    UsagerP = InfoUsagerCourant[2],
                    Password = InfoUsagerCourant[3],
                    Telephone = InfoUsagerCourant[4],
                    Adresse = InfoUsagerCourant[5],
                    CodePostal = InfoUsagerCourant[6],
                    TypeUsager = InfoUsagerCourant[7],
                };
                return usagerCourant;
            }

            return usagerCourant;




            ////Creation d'objet Usager 
            //Usager UsagerModel = new Usager
            //{
            //    Id = 1,
            //    Nom = "Diego Alejandro Pelaez",
            //    UsagerP = "diego",
            //    Password = "123",
            //    Telephone = "5115455555",
            //    Adresse = "4455 Avnoot",
            //    CodePostal = "Q2Q5T5",
            //    TypeUsager = "ADMIN",

            //};



            ////Verification de usager et mot de passe 
            //if ((UsagerModel.UsagerP.Equals(usagerCourant.UsagerP)) && (UsagerModel.Password.Equals(usagerCourant.Password)))
            //{
            //    return UsagerModel;
            //}
            //else
            //{
            //    return null;
            // } 

        }
    }
}