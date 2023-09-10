
/* Opgave 9: Opret en liste med 5 ord, udskriv dem i omvendt rækkefølge */

List<string> listWith5Words = new List<string> { "Æble", "Pære", "Banan", "Citron", "Kiwi"};

listWith5Words.Reverse();

Console.WriteLine($"{listWith5Words[0]}\n{listWith5Words[1]}\n{listWith5Words[2]}\n{listWith5Words[3]}\n{listWith5Words[4]}");


// --------------------------------------------------------------------------------------------------------------------------- //



/* Opgave 10:  Opret en liste med 10 tal, udskriv summen af disse */

List<double> doubleListe = new List<double> { 1.88, 11.13, 2.123, 44.66, 7.15, 256.1, 54.66, 66.5, 4.4, 87.2};

Console.WriteLine($"\nTotal sum af de 10 tal: {doubleListe.Sum()}");



// --------------------------------------------------------------------------------------------------------------------------- //


/* Opgave 11: Udskriv hvor mange elementer der i de to lister tilsammen */

Console.WriteLine($"\ndoublelList: {doubleListe.Count} indexes");
Console.WriteLine($"listWith5Words: {listWith5Words.Count} indexes");

Console.WriteLine($"\nSum af indexes: {doubleListe.Count + listWith5Words.Count}");