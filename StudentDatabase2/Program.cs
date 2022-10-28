using StudentDatabase2;


List<string> studentInfo = new List<string>()
{ "Alice", "Bradley", "Charles", "Danica" };

foreach (string name in studentInfo)
{ Console.WriteLine(name); }

Console.ReadKey();

Console.WriteLine("Select a student fron the list.");
string studentName = Console.ReadLine();

Console.WriteLine($"{studentName}'s );