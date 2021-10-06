using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GebruikVanTuple
{
    internal class Student
    {
        internal int Id {  get; set; }
        internal string Naam {  get; set; }
        internal DateTime GeboorteDatum {  get; set; }
        internal DateTime Ingeschreven {  get; set; }
        internal string Richting {  get; set; }
        internal string Straat {  get; set; }
        internal string Postcode {  get; set; }
        internal string Woonplaats {  get; set; }

        // ...
        // Voor de student zijn constructors en andere methoden aanwezig
        // ...

        // We voorzien een methode "Inschrijving" die slechts 3 waarden teruggeeft:
        //      Id, Ingeschreven en Richting

        // Traditioneel moeten we daarvoor een class of een struct voorzien, en wordt dit als volgt uitgewerkt:
        internal Inschrijvingsgegevens Inschrijving()
        {
            return new Inschrijvingsgegevens()
                        {
                            Id = Id,
                            Ingeschreven = Ingeschreven,
                            Richting = Richting
                        };
        }

        // Je kan deze methode ook schrijven zonder een struct (of klasse) Inschrijvingsgegevens te maken:
        internal Tuple<int, DateTime, string> InschrijvingMetTuple()
        {
            return Tuple.Create(Id, Ingeschreven, Richting);
        }

    }

    internal struct Inschrijvingsgegevens
    {
        internal int Id;
        internal DateTime Ingeschreven;
        internal string Richting;
    }
}
