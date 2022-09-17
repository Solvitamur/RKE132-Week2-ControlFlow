// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal tema perekonnanime
//Lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr./Ms. [Kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char UserGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (söne) formaadis

Console.WriteLine("Please, enter your last name:");
string UserLastName = Console.ReadLine();

if (UserGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserLastName}!");
}
else if(UserGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserLastName}!");
}
else
{
    Console.WriteLine($"Welcome {UserLastName}!");
}


