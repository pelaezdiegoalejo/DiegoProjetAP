using PelaezAutoPartsDiego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PelaezAutoPartsDiego.Utility
{
    public class Validation
    {

        public static Usager ValidationUsager (Usager usager)
        {
            //Usager de Exj
            Usager UsagerModel = new Usager
            {
                Id = 1,
                Nom = "Diego Alejandro Pelaez",
                UsagerP = "diego",
                Password = "123",
                Telephone = "5115455555",
                Adresse = "4455 Avnoot",
                CodePostal = "Q2Q5T5",
                TypeUsager = "ADMIN",

            };
            if ((UsagerModel.UsagerP.Equals(usager.UsagerP)) && (UsagerModel.Password.Equals(usager.Password)))
            {
                return UsagerModel;
            }
            else
            {
                return null;
            } 
                       
        }
    }
}