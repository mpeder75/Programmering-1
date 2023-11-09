/*
Lambda opgave: 
Modellen er en vare:
(id, navn, beskrivelse, indkøbspris, salgspris(Beregnet), lokation(Hyldenummer)) 

Lav metoder i en classe, der har en liste over varer (10 stykker), der returnerer resultat af følgende: 
• Find alle de varer der har en udsalgspris på over Kr. 200 
• Find ud af hvor mange der har en indkøbspris på over Kr. 200 
• Returner det mindste id i listen 
• Returner alle varer sorteret på navn descending 

Sortering af data sker kun med Lambda. 
Brug F11 til at steppe igennem koden og følg programafvikling 
*/

using Session_14___Exercises___lambda.Models;

Item myItems = new Item();

myItems.hardcodedItemList.ToString();Console.WriteLine();