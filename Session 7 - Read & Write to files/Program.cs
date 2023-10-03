//todo Læse og printe fra en fil
/*

// 1. Opsæt HVOR filen befinder sig - @ gør at det er en string literal 
string filePath = @"c:\Demos\Test.txt";

// 2. Nu læses fra .txt med File class (som returnere et string array),
//    metoden ReadAllLines() skal have filePath som argument
//    (ellers ved den ikke hvilken fil den skal læse)

// File.ReadAllLines(filePath);

//! Hvis man vil have den som List - Tolist() konvertere array til en List
 List<string> lines = File.ReadAllLines(filePath).ToList();


// 3. Printe den læste fil
for (int i = 0; i < lines.Count; i++)
{
    Console.WriteLine($"Printing from for-loop: {lines[i]}");
}

int counter = 0;
while(counter < lines.Count)
{
    Console.WriteLine($"Printing from while-loop: {lines[counter]}");
    counter++;
}

//todo Skrive til en fil

// 1. Tilføj det man vil til den List man allerede har
lines.Add("Sue,Storm,www.stormMother.com");

// 2. Nu skal man skrive til filen med File.WriteAllLines()
// Angiv i metoden WriteAllLines(placering, List eller Array)
File.WriteAllLines(filePath, lines);

// 3. print det man har tilføjet
int count = 0;
while(count < lines.Count)
{
    Console.WriteLine(lines[count]);
    count++;
}
*/

//todo Populate List Person

using Session_7___Read___Write_to_files;

string filePath = @"c:\Demos\Test.txt";

// 1. List oprettes, der skal indeholde Person objekt fra Person.cs
List<Person> people = new List<Person>();

// 2. List<Person> skal nu populates
// Vi læser fra filen(filePath), og konvertere til List med .ToList()
// og gemmes i variablen lines
List<string> lines = File.ReadAllLines(filePath).ToList();

// 3. Nu loppes lines array igennem, og når der er et komma (,) skal der splittes
for (int i = 0; i < lines.Count; i++)
{
    string line = lines[i];
    string[] entries = line.Split(',');

    Person newPerson = new Person();

    newPerson.FirstName = entries[0];
    newPerson.LastName = entries[1];
    newPerson.Url = entries[2];

    people.Add(newPerson);
}

for (int i = 0; i < people.Count; i++)
{
    var person = people[i];
    Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Url}");

}

/*
foreach(var person in people)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Url}");
}
*/


//todo Adding person to List
people.Add(new Person { FirstName = "Gregg", LastName = "Jones", Url = "www.test.com" });

List<string> output = new List<string>();

for (int i = 0; i < people.Count; i++)
{
    var person = people[i];

    output.Add($"{person.FirstName}, {person.LastName}, {person.Url}");
}

Console.WriteLine("writing to text file");

File.WriteAllLines(filePath, output);

Console.WriteLine("All entries written");

for (int i = 0; i < people.Count; i++)
{
    var person = people[i];
    Console.WriteLine($"{person.FirstName} {person.LastName}: {person.Url}");
}
