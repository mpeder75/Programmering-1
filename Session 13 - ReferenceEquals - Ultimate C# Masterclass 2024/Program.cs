
//! Undersøge om 2 objekter har samme adresse i memory (og om de så også har samme reference)
var john = new Person { Id = 1, FirstName = "John" };
var sameAsJohn = new Person { Id = 1, FirstName = "John" };
// Hvis sameAsJohn sættes lig med john, har de sann reference og metode returnere true
/* var sameAsJohn = john; */

Console.WriteLine("Are references equal? " + object.ReferenceEquals(john, sameAsJohn));


//! Undersøge om 2 datatyper har samme adresse i memory (og om de så også har samme reference)
Console.WriteLine(object.ReferenceEquals(1, 1));


//! Undersøge om 2 NULL værdier har samme adresse i memory (og om de så også har samme reference)
Console.WriteLine(object.ReferenceEquals(null, null));





class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}


