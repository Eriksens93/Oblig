using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1
{
    public class FamilyApp
    {
        public List<Person> People;

        public FamilyApp(params Person[] people)
        {
            People = new List<Person>(people);
        }

        public string WelcomeMessage = @"
hjelp => viser en hjelpetekst som forklarer alle kommandoene
liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert.
vis<id> => viser en bestemt person med mor, far og barn(og id for disse, slik at man lett kan vise en av dem)";
        public string CommandPrompt ="=>";

        public string HandleCommand(string commands)  
        {
            if (commands == "hjelp")
            {
                return WelcomeMessage; 
            }

            if (commands == "liste")
            {
                return ListeCommand(People);
            }

            if (commands.Contains("vis "))
            {
                return VisPersonId(commands);
            }

            else return "FailCommando";
        }

        private static string ListeCommand(List<Person> People)
        {
            string tekst = string.Empty;
            foreach (var i in People)
            {
                tekst += i.GetDescription() + "\n";
            }
            return tekst;
            
        }

        public string VisPersonId(string commands)
        {
            var children = new List<Person>();
            var tekst = "";
            var søkeID = Int32.Parse(commands.Substring(4));

            for (var i = 0; i< People.Count; i++)
            {
                if (People[i].Id == søkeID)
                {
                    tekst += People[i].GetDescription() + "\n";
                }

                if (People[i].Father != null )
                {
                    if (People[i].Father.Id == søkeID)
                    {
                        children.Add(People[i]);
                    }
                }

                if (People[i].Mother != null)
                {
                    if (People[i].Mother.Id == søkeID)
                    {
                        children.Add(People[i]);
                    }
                }

            }

            if (children.Count != 0)
            {
                tekst += "  Barn:\n";
                for (var i = 0; i < children.Count; i++)
                {
                    tekst += $"    {children[i].FirstName} (Id={children[i].Id}) Født: {children[i].BirthYear}\n";
                }
            }

            return tekst;

        }

    }
}
 