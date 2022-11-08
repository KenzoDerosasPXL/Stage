using System.Text.RegularExpressions;

string nummer;
Console.Write($"Geef een nummer: ");
nummer = (Console.ReadLine());
while (!Regex.IsMatch(nummer, @"^\d+$") || nummer.Contains("0"))
{
    Console.Write($"Geef een nummer: ");
    nummer = (Console.ReadLine());
}

string[] nummers = new string[nummer.Length];
for (int i = 0; i < nummer.Length; i++)
{
    string a = nummer.Substring(i, 1);
    switch (nummer.Substring(i, 1))
    {
        case "1":
            nummers[i] = "   ";
            break;
        case "2":
            nummers[i] = "abc";
            break;
        case "3":
            nummers[i] = "def";
            break;
        case "4":
            nummers[i] = "ghi";
            break;
        case "5":
            nummers[i] = "jkl";
            break;
        case "6":
            nummers[i] = "mno";
            break;
        case "7":
            nummers[i] = "pqrs";
            break;
        case "8":
            nummers[i] = "tuv";
            break;
        case "9":
            nummers[i] = "wxyz";
            break;
    }
}

Console.WriteLine();
if (nummer.Length == 1)
{
    for (int i = 0; i < nummers[0].Length; i++)
    {
        Console.WriteLine(nummers[0].Substring(i,1));
    }
}
else
{
    for (int i = 0; i < 1; i++)
    {
        for (int k = 0; k < nummers[i].Length; k++)
        {
            for (int p = 0; p < nummers[i + 1].Length; p++)
            {
                Console.Write(nummers[i].Substring(k, 1).Replace(" ", ""));
                for (int a = 1; a < nummer.Length; a++)
                {
                    Console.Write(nummers[a].Substring(p, 1).Replace(" ", ""));
                }
                Console.WriteLine();
            }

        }
    }
}


//The exercise consists of creating and parsing one form field where a string is used as input.
//This string should be validated since we only want numbers.

//Using this number sequence, we would like all possible string combinations this number can generate according to the following specifications:

//1->nothing
//2->ABC
//3->DEF
//4->GHI
//5->JKL
//6->MNO
//7->PQRS
//8->TUV
//9->WXYZ

//Note that we follow the layout used on a phone dial.

//Example:
//input: 23
//output:
//AD
//AE
//AF
//BD
//BE
//...
//CF