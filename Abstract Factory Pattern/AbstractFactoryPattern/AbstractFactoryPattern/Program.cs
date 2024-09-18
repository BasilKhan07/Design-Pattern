using AbstractFactoryPattern;

Country country1 = Country.ENGLAND;
ILanguage language1 = InternationalProvider.CreateLanguage(country1);
ICapitalCity capital1 = InternationalProvider.CreateCapital(country1);

language1.Greet();
Console.WriteLine("Total Population: " + capital1.GetPopulation());
Console.WriteLine("Top Attraction: " + string.Join(",", capital1.ListTopAttractions()));

Console.WriteLine("\n");

Country country2 = Country.SPAIN;
ILanguage language2 = InternationalProvider.CreateLanguage(country2);
ICapitalCity capital2 = InternationalProvider.CreateCapital(country2);

language2.Greet();
Console.WriteLine("Total Population: " + capital2.GetPopulation());
Console.WriteLine("Top Attraction: " + string.Join(",", capital2.ListTopAttractions()));