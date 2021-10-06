// Demonstratie van het gebruik van Tuple

using GebruikVanTuple;

Student student = new Student()
                        { 
                            Id = 20210197,
                            Ingeschreven = new DateTime(2021, 9, 15),
                            GeboorteDatum= new DateTime(2003, 3, 18),
                            Naam = "Jan Jansens",
                            Postcode= "1070",
                            Richting = "Graduaat Programmeren",
                            Straat = "Onderwijsstraat",
                            Woonplaats = "Anderlecht"
                        };

// Ophalen inschrijvingsgegevens zonder Tuple:
Inschrijvingsgegevens ig = student.Inschrijving();
Console.WriteLine("Inschrijving: Student " + ig.Id + " is ingeschreven op " + ig.Ingeschreven + " voor " + ig.Richting);

// Ophalen inschrijvingsgegevens met Tuple:
Tuple<int, DateTime, string> inschrijving = student.InschrijvingMetTuple();
Console.WriteLine("Inschrijving: Student " + inschrijving.Item1 + " is ingeschreven op " + inschrijving.Item2 + " voor " + inschrijving.Item3);