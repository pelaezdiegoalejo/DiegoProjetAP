using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PelaezAutoPartsDiego.Utility
{

    public class TraiteFichierUsager
    {
        string line;
        char[] charParametreSeparator = new char[] { ',' };
        char[] charSeparatorsLine = new char[] { ';' };
        string[] UsagerPass;
        int contador = 0;
        StreamReader ObjecReader;


        //Read file Usagers.txt -return collection avec Nom et pas registres dans le fichier
        public  string[] splitLineUsager() {
            
            ObjecReader = File.OpenText("U:\\Projet\\Usagers.txt");
            try
            {
                string line = ObjecReader.ReadLine();

                while (line != null)
                {

                    //contador =+ 1;
                    // string[] readUsagerComplete = line.Split(charSeparatorsLine);
                    // string[] splitUsager = readUsagerComplete[0].Split(charParametreSeparator);
                    string[] splitUsager = line.Split(charParametreSeparator);
                    UsagerPass[contador] = splitUsager[2].ToString();
                    UsagerPass[contador+1] = splitUsager[3].ToString();
                    UsagerPass[contador+2] = splitUsager[0].ToString();
                    contador =+ 3;
                     line = ObjecReader.ReadLine();
                }
            }
            catch(FileNotFoundException e){
           

            }
            finally{
                ObjecReader.Close();
            }
            return UsagerPass;  
        }
        public string[]GetInfoCompleteUsager (string id)
        {
            bool retrouve = false;
            string[] Usager = new string[8];
            ObjecReader = File.OpenText("U:\\Projet\\Usagers.txt");
            string line = ObjecReader.ReadLine();
            try
            {
                while (retrouve == false && line != null) 
                {
                    Usager = line.Split(charParametreSeparator); 
                    if(Usager[0].Trim().Equals(id))
                    {
                        retrouve = true;
                        return Usager;
                    }
                    else
                    {
                        line = ObjecReader.ReadLine();
                    }
                }
            }
            catch(FileNotFoundException e)
            {

            }
            finally
            {
                ObjecReader.Close();
            }
            return Usager;
        }

    }
}