/*
Ask for the number of female cats
Get that input from the user
Ask for the input of male cats
Get that input from the user
Calculate percentage
*/

String userInput;
float femaleCats;
float maleCats;
float totalCats;

Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("-- Hello, Welcome To Cat Purrcentage Clawculator 9000 --");
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine(" - How male cats are there? ");
userInput = Console.ReadLine(); //femaleCats = Convert.ToInt32(Console.ReadLine()); Compound statement 
femaleCats = Convert.ToInt32(userInput);

Console.WriteLine(" - How male cats are there? ");
userInput = Console.ReadLine(); 
maleCats = Convert.ToInt32(userInput);

totalCats = femaleCats + maleCats;

double maleCatPercentage = maleCats / totalCats;
double femaleCatPercentage = femaleCats / totalCats;

maleCatPercentage = maleCatPercentage * 100;
femaleCatPercentage = femaleCatPercentage * 100;

Console.WriteLine($" - Female Cate Percentage: \t\t {femaleCatPercentage.ToString("0.00")}" + "%"); //shorten decimal points .ToString("0.00")
Console.WriteLine($" - Male Cate Percentage:   \t\t" + maleCatPercentage.ToString("0.00") + "%");

char firstChar = userInput[0];

