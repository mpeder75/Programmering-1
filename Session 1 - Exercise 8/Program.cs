/*
Opret følgende variabler:

 *Fornavn
 *efternavn
 *adresse (gade/vej)
 *husnummer 
 *postnummer
 *by
 *fødselsdato
 
Udskriv dem ved hjælp af placeholders.
 */

string fornavn = "Michael";
string efternavn = "Pedersen";
string adresse = "Chr M Østergaardsvej";
string husnummer = "2a.";
int postnummer = 8700;
string by = "Horsens";
string fødselsdato = "11 April";


Console.WriteLine($"Mit navn er: {fornavn} {efternavn} og jeg bor på {adresse} {husnummer} i " +
    $"{by}, postnummer {postnummer}. Jeg er født {fødselsdato}");
