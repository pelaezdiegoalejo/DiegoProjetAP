using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PelaezAutoPartsDiego.Models
{
    public class Usager
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        [Required (ErrorMessage ="Nom de usager Invalid")]
        [Display(Name ="Usager")]
        public string UsagerP { get; set; }
        [Required(ErrorMessage = "Password Invalid")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set;}
        public string TypeUsager { get; set; }

        public Usager()
        {
        }

        public Usager(string UsagerP, string Pwd)
        {
            this.UsagerP = UsagerP;
            Password = Pwd;
        }
public Usager(int id, string nom, string usagerP, string password, string telephone, string adresse,string codePostal, string typeUsager)
        {
            Id = id;
            Nom = nom;
            UsagerP = usagerP;
            Password = password;
            Telephone = telephone;
            Adresse = adresse;
            CodePostal = codePostal;
            TypeUsager = typeUsager;
        }
    }
}