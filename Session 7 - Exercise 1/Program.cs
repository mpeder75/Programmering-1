using Session_7___Exercise_1.DataAccess;

string root = @"c:\demo\";

DataFromCsv dataFromCsv = new DataFromCsv(root);


Console.WriteLine("Data from file1.csv:");
for (int i = 0; i < dataFromCsv.File1Array.Length; i++)
{
    string[] temp = dataFromCsv.File1Array[i].Split(';');
    Console.WriteLine($"Id:{temp[0]}\tFirstName:{temp[1]}\tLastName:{temp[2]}\tPhone:{temp[3]}\temail:{temp[4]}");
}

Console.WriteLine("\nData from file2.csv:");
for (int i = 0; i < dataFromCsv.File2Array.Length; i++)
{
    string[] temp = dataFromCsv.File2Array[i].Split(';');
    Console.WriteLine($"Id:{temp[0]}\tFirstName:{temp[1]}\tLastName:{temp[2]}\tPhone:{temp[3]}\temail:{temp[4]}");
}

Console.WriteLine("\nCombined Data  file1.csv & file2.csv:");
for (int i = 0; i < dataFromCsv.CombinedCsvData.Length; i++)
{
    string[] temp = dataFromCsv.CombinedCsvData[i].Split(';');
    Console.WriteLine($"Id:{temp[0]}\tFirstName:{temp[1]}\tLastName:{temp[2]}\tPhone:{temp[3]}\temail:{temp[4]}");
}