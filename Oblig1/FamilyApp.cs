using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig1
{
    class FamilyApp
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

            if (commands == "vis")
            {
                return "true";
            }

            return "FailCommando";
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
    }
}
 