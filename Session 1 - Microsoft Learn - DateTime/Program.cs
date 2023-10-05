
//todo DateTime objekt oprettes - sættes til dd. & klokkeslet
DateTime myValue = DateTime.Now;


//todo Opret et DateTime objekt med specifik dato - ( Year, Month, Date )
DateTime myBirthDay = new DateTime(1982, 4, 11);
Console.WriteLine(myBirthDay.ToShortDateString());


// 1. myValue printes nu ud - ToString() method
Console.WriteLine(myValue.ToString());


// 2. Udskriv KUN dato - ToShortDateString() method
Console.WriteLine(myValue.ToShortDateString());


// 3. Udskriv KUN klokkeslet - ToShortTimeString() method
Console.WriteLine(myValue.ToShortTimeString());


// 4. Udskriv DATO - ToLongDateString() method - ( ex. 5 Oktober 2023 )
Console.WriteLine(myValue.ToLongDateString());


// 5. Udskriv KLOKKESLET & SEKUNDER - ToLongTimeString()
Console.WriteLine(myValue.ToLongTimeString());



// ---------------- Manipulere DateTime ---------------- //


// 1a. Læg 3 dage til dd. - AddDays() method returnere nyt DateTime objekt
Console.WriteLine(myValue.AddDays(3).ToLongDateString());

// 1b. Læg 3 dage til dd. og gem i variabel dateIn3Days
DateTime dateIn3Days = myValue.AddDays(3);
Console.WriteLine(dateIn3Days);


// 2. Læg 3 timer till nuværendne tid - AddHours() method
Console.WriteLine(myValue.AddHours(3).ToShortTimeString());


// 3. Træk 3 dage fra dd. - AddDays method
Console.WriteLine(myValue.AddDays(-3).ToShortDateString());


// 4. Udskriv KUN måned som tal - Month() method
Console.WriteLine(myValue.Month.ToString());


// 5. Udskriv KUN dd. ugenavn - DatOfWeek() method
Console.WriteLine(myValue.DayOfWeek);


// 6. Sammenlign to datoer, gøres med timespan der beregner forskellen
DateTime birthDate = DateTime.Parse("1982/11/4");

// trækker fødselsdato fra  
TimeSpan myAgeInDays = DateTime.Now.Subtract(birthDate);
Console.WriteLine($"My age is: {myAgeInDays.TotalDays}");

// Beregne en alder ift. dd.
double myAgeInYears = myAgeInDays.TotalDays / 365.25;
Console.WriteLine(myAgeInYears);







