namespace HomePracticeI;
internal class MainProgram
{
    const int errorNum = 2147483647;

    public void Run()
    {
        //První úkol

        int int01 = AskNumber();

        PrintDelimiter();

        int int02 = AskNumber();

        PrintDelimiter();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        if (int01 == errorNum && int02 == errorNum)
        {
            Console.WriteLine("Proč píšeš písmena. Řekl jsem čísla ne?");
        }
        else if (int01 == errorNum || int02 == errorNum)
        {
            Console.WriteLine("Jedno ze zadaných čísel není číslo.");
        }
        else if (int01 > int02)
        {
            Console.WriteLine(int01 + " je větší.");
        }
        else if (int01 < int02)
        {
            Console.WriteLine(int02 + " je větší.");
        }
        else
        {
            Console.WriteLine("Čísla jsou stejně dlouhá. ");
        }

        Console.ForegroundColor = ConsoleColor.White;

        PrintDelimiter();

        Console.WriteLine("Zmáčkni jakoukoli klávesu pro pokračování.");
        Console.ReadKey();


        Console.Clear();


        //Druhý úkol

        int int03 = AskNumber();

        PrintDelimiter();

        int int04 = AskNumber();

        PrintDelimiter();

        int int05 = AskNumber();

        PrintDelimiter();

        int int06 = AskNumber();

        PrintDelimiter();

        int int07 = int03 + int04;

        int int08 = int05 * int06;

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        if (int03 == errorNum || int04 == errorNum || int05 == errorNum || int06 == errorNum)
        {
            Console.WriteLine("Proč píšeš písmena. Řekl jsem čísla ne?");
        }
        else if (int07 > int08)
        {
            Console.WriteLine("Sečtení prvních dvou čísel (výsledek " + int07 +") je větší než násobení druhých dvou čísel.");
        }
        else if (int07 < int08)
        {
            Console.WriteLine("Násobení druhých dvou čísel (výsledek " + int08 +") je větší než sčítaní prvních dvou čísel.");
        }
        else
        {
            Console.WriteLine("Čísla jsou stejně dlouhá.");
        }

        Console.ForegroundColor = ConsoleColor.White;

        PrintDelimiter();

        Console.WriteLine("Zmáčkni jakoukoli klávesu pro pokračování.");
        Console.ReadKey();

        Console.Clear();

        //Úkol 3

        int int09 = AskNumber();

        PrintDelimiter();

        int int10 = AskNumber();

        PrintDelimiter();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Zadejte operaci (add, sub, mul, div): ");
        Console.ForegroundColor = ConsoleColor.Red;
        string oper = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;

        PrintDelimiter();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        if (int09 == errorNum && int10 == errorNum)
        {
            Console.WriteLine("Proč píšeš písmena. Řekl jsem čísla ne?");
        }
        else if (int09 == errorNum || int10 == errorNum)
        {
            Console.WriteLine("Jedno ze zadaných čísel není číslo.");
        }
        else if (oper == "add")
        {
            Console.WriteLine("Sečtení čísel " + int09 + " a " + int10 + " je " + (int09+int10) + ".");
        }
        else if (oper == "sub")
        {
            Console.WriteLine("Odečtení čísel " + int09 + " a " + int10 + " je " + (int09-int10) + ".");
        }
        else if (oper == "mul")
        {
            Console.WriteLine("Násobení čísel " + int09 + " a " + int10 + " je " + (int09*int10) + ".");
        }
        else if (oper == "div")
        {
            Console.WriteLine("Dělení čísel " + int09 + " a " + int10 + " je " + (int09/int10) + ".");
        }
        else
        {
            Console.WriteLine("Nebyla zadána validní operace.");
        }

        Console.ForegroundColor = ConsoleColor.White;

        PrintDelimiter();
    }


    public int SafelyConvertToInt(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result;
        }
        else
        {
            return errorNum;
        }
    }

    public void PrintDelimiter()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public int AskNumber()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Zadejte číslo: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string a = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.White;
        int b = SafelyConvertToInt(a);
        return b;
    }
}
