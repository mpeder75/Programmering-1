/*
 Opret en konsolapp, der skriver 
"I dag har vi mandag d. 23. oktober 2017 og kl. er 14.46". 
Hvor ugedagen, datoen og klokkeslættet tages fra DateTime. 
*/


// 1. dagsDato variabel oprettes af datatypen DateTime, som assignes DateTime.Now
DateTime dagsdato = DateTime.Now;

// 2. Her printes dagsdato ud
Console.WriteLine($"I dag har vi {dagsdato.DayOfWeek} d. {dagsdato.Day} {dagsdato.ToString("MMMM")} {dagsdato.Year} og kl er {dagsdato.Hour}.{dagsdato.Minute}");


