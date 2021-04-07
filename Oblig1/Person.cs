using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// int= hele tall, double= med komma, desimal /( ikke hele tall). Bruker man float så må man ha " f" som suffix etter tallet med komma. Float tar mindre plass i minne enn det double vil gjøre. Funksjoner = metoder som i javascript. () void returnerer ingenting.

namespace Oblig1
{
   public class Person

    {
        public int? Id;
        public string FirstName;
        public string LastName;
        public int? BirthYear;
        public int? DeathYear;
        public Person Father;
        public Person Mother;

        public string GetDescription()
        {
            string output = String.Empty;

            if (FirstName != null) output += $"{FirstName} ";
            if (LastName != null) output += $"{LastName} ";
            if (Id != null) output += $"(Id={Id})";
            if (BirthYear != null) output += $" Født: {BirthYear} ";
            if (DeathYear != null) output += $"Død: {DeathYear} ";
            if (Father !=null)
            {
                if (Father.FirstName != null) output += $"Far: {Father.FirstName} ";
                if (Father.Id != null) output += $"(Id={Father.Id}) ";
            }
            if (Mother != null)
            {
                if (Mother.FirstName != null) output += $"Mor: {Mother.FirstName} ";
                if (Mother.Id != null) output += $"(Id={Mother.Id})";
            }
            


            //output +=
            //    $"{FirstName} {LastName} (Id={Id}) Født: {BirthYear} Død: {DeathYear} Far: {Father.FirstName} (Id={Father.Id}) Mor: {Mother.FirstName} (Id={Mother.Id})";

            var text = output.Trim();
            return text; 
           
        }
            
    }
}
//"Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)"