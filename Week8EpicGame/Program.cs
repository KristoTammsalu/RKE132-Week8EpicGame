string folderPath = @"C:\\Users\\kristi.tammsalu\\Program\\Programmeerimine";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Harry Potter", "Ratatouille", "Shrek", "Jack Sparrow" };
//string[] villains = { "Mr. Burns", "Joker", "Megamind", "Voldemort", "Dracula" };



string[] weapon = { "random stick", "a spoon", "a cat", "small rock", "water gun" };



string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");


string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} tries to take over the world!");



static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int RandomIndex = rnd.Next(0, someArray.Length);
    string ranomStringFromArray = someArray[RandomIndex];
    return ranomStringFromArray;
}
