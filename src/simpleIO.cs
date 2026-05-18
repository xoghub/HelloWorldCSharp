Console.WriteLine("Enter your name: ");
// ? prevent warning : CS8600: Converting null literal or possible null value to non-nullable type.
string? name = Console.ReadLine();
// Console.WriteLine("Hello, " + name + "!");
Console.WriteLine("Enter year of birth: ");
string? birthYear = Console.ReadLine();
int birthYearInt = Convert.ToInt32(birthYear);
int ageInt = 2026 - birthYearInt;
// string.Format 
Console.WriteLine(string.Format("Hello, {0}! You are {1} years old!", name, ageInt));
