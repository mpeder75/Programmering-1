using Session_7___Exercise.DataAccess;

string root = @"c:\demo\";


MyFileReader reader = new MyFileReader(root);

// Læse fra en fil
for (int i = 1; i < reader.txtLines.Length; i++)
{
    string[] temp = reader.txtLines[i].Split(';');
    Console.WriteLine($"Id:{temp[0]}\t FirstName: {temp[1]}\t LastName: {temp[2]}");
}


// Skrive til en fil, data kommer fra en List
List<string> stringList = new List<string> { "1;Homer; Simpson", "2;Marge; Simpson" };

string path = Path.Combine(root, "michael.csv");

File.WriteAllLines(path, stringList);





