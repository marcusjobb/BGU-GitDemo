// See https://aka.ms/new-console-template for more information
Console.WriteLine("+------------------+");
Console.WriteLine("| Hello, GitWorld! |");
Console.WriteLine("+------------------+");

Random rnd = new Random();
int slumptal = rnd.Next(1, 101);

Console.WriteLine(slumptal);

Console.WriteLine("Ett rymdskepp är på väg mot din stad och ska stjäla all världens popcorn");
Console.WriteLine("Du måste skicka upp en missil, med koordinater mellan 1 och 100");
Console.WriteLine("Du har 10 försök innan rymdskeppet landar och stjäl all popcorn från jorden");

string gissarFörHögt = "Kapten, din gissning var för hög";
string gissarFörLågt= "Kapten, din gissning var för låg";
string gissarRätt = "Kapten! Du har sprängt UFOt! Yay! Världens popcorn är trygg igen!";
string förlorat = "Oh Noes! Kapten du schabblade och UFOt snodde all popcorn i världen!!!";

Console.ReadLine();