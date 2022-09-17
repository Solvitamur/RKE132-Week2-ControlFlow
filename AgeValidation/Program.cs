// See https://aka.ms/new-console-template for more information
// Rakendus küsib kasutajal sisestada tema vanuse
// Kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "You are too young to use instagram"
// muul juhul
// konsoolis kuvatakse "welcome to instagram"

Console.WriteLine("Enter your age:");

string UserAge = Console.ReadLine();
int UserAgeNum = 0;

//boolean - true/false
bool isAgeNumber = Int32.TryParse(UserAge, out UserAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {UserAgeNum} years old.");

if(isAgeNumber)
{
    if (UserAgeNum >= 13)
    {
        Console.WriteLine("Welcome to instagram!");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age.");
}




//int UserAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

//if(UserAge >= 13)
//{
//    Console.WriteLine("Welcome to instagram");
//}
//else //if (userage < 13)
//{
//    Console.WriteLine("You are too young to use Instagram");
//}