double price = 19.99;
double tax = 0.11;
int quantity = 2;
float discount = 0.1f;
double total = price * quantity;
double totalDiscount = total * discount;
double totalTax = total * tax;
double totalFinal = total - totalDiscount + totalTax;
string repeatedChars = new string('-', 20);
Console.WriteLine(repeatedChars + "Arithmetic Operators" + repeatedChars);
Console.WriteLine("Price of product : \t\t" + price + " * " + quantity);
Console.WriteLine("Total price : \t\t\t" + total);
Console.WriteLine("Total tax : \t\t\t" + totalTax);
Console.WriteLine("Total discount : \t\t" + totalDiscount);
Console.WriteLine("Total Final price : \t\t" + totalFinal);
Console.WriteLine(repeatedChars + "Comparison Operators" + repeatedChars);
Console.WriteLine("is price less that tax: \t" + (price < tax));
Console.WriteLine("is price greater than tax:\t" + (price > tax));

Console.WriteLine(repeatedChars + "Assignment Operators" + repeatedChars);

int a = 5;
Console.WriteLine("the value of a is: {0}",a);
a += 10;
Console.WriteLine("the value of a after reassign += 10 : {0}",a);
a -= 5;
Console.WriteLine("the value of a after reassign -= 5 : {0}",a);
a *= 2;
Console.WriteLine("the value of a after reassign *= 2 : {0}",a);
a /= 2;
Console.WriteLine("the value of a after reassign /= 2 : {0}",a);
a %= 2;
Console.WriteLine("the value of a after reassign %= 2 : {0}",a);
a ^= 2;
Console.WriteLine("the value of a after reassign ^= 2 : {0}",a);
a &= 2;
Console.WriteLine("the value of a after reassign &= 2 : {0}",a);
a |= 2;
Console.WriteLine("the value of a after reassign |= 2 : {0}",a);
a <<= 2;
Console.WriteLine("the value of a after reassign <<= 2 : {0}",a);
a >>= 2;
Console.WriteLine("the value of a after reassign >>= 2 : {0}",a);

Console.WriteLine(repeatedChars + "Comparison Operators" + repeatedChars);

int c = 5;
int b = 4;
Console.WriteLine("the value of c is: {0}",c);
Console.WriteLine("the value of b is: {0}",b);
Console.WriteLine("c == b: 	"+(c==b));
Console.WriteLine("c != b: 	"+(c!=b));
Console.WriteLine("c < b:  \t"+(c<b));
Console.WriteLine("c > b:  \t"+(c>b));
Console.WriteLine("c <= b: \t"+(c<=b));
Console.WriteLine("c >= b: \t"+(c>=b));

Console.WriteLine(repeatedChars + "Logical Operators" + repeatedChars);

bool isSunny = true;
bool isWarm = false;

Console.WriteLine("the value of isSunny is:\t{0}",isSunny);
Console.WriteLine("the value of isWarm is:\t\t{0}",isWarm);
Console.WriteLine("isSunny && isWarm:\t\t"+(isSunny && isWarm));
Console.WriteLine("isSunny || isWarm:\t\t"+(isSunny || isWarm));
Console.WriteLine("!isSunny:\t\t\t"+(!isSunny));
Console.WriteLine("!isWarm:\t\t\t"+(!isWarm));

Console.WriteLine(repeatedChars + "Ternary Operators" + repeatedChars);
