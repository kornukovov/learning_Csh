Console.WriteLine("Enter your name");
string name = Console.ReadLine();
if (name.ToLower() == "alex")
{
   Console.WriteLine("Salute Alex!!!");
}
else
{
   Console.WriteLine($"Hello {name}");
}