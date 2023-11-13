using Session_14___Delegate;

//! Delegate er en type der onddeholder en reference til en metode

//! Dvs. Når delegate kaldes, vil den method der er opsat reference til blive kørt


// 5. instans af HelperClass
HelperClass helperClass = new HelperClass();

// 3. instans af delegate med PrintToConsole som argument
RefToPrint print = new RefToPrint(PrintToConsole);      

// 6. HelperClass metoden 
helperClass.PrintSum(10, 20, print);



// 1. metode der skal printe oprettes
void PrintToConsole(string result)
{
    Console.WriteLine(result);
}

// 2. delegate oprettes - HUSK returtype (void) skal være ens i PrintToConsole og RefToPrint
public delegate void RefToPrint(string result);



