/* 
 Opgave 5: Opret en metode der tager en tekst ”C# er et fantastisk sprog!” 
 og returnere en List<string>. 
 ”C#”, ”er”, ”et”, ”fantastisk”, ”Sprog!”. 
  Det skal naturligvis laves således at den kan gøre dette med en vilkårlig tekst. 
*/

List<string> jeps = ReturnStringAsList("C# er et fantastisk sprog!");

for(int i = 0; i < jeps.Count; i++)
{
    Console.WriteLine(jeps[i]);
}
 

List<string> ReturnStringAsList(string text)
{
    // split text ved HVER ' ' mellemrum og gem i variabel splitString
    string[] splitString = text.Split(' ');

    // array til en List<string>
    List<string> convertedString = new List<string>(splitString);

    // returner den nyoprettede convertedString til invoker
    return convertedString;
}