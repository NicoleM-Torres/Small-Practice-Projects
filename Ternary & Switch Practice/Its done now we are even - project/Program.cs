using System.Linq.Expressions;
int favorsDone = 0;

int favorsOwed = (favorsOwed / 3) ? "You owe favors" : "No favors owed";
Console.WriteLine(favorsOwed);

//INPUT
Console.WriteLine("Enter mount of favors completed: ");
favorsDone = int.Parse(Console.ReadLine());

//OUTPUT



//switch statement

switch (favorsOwed)
{
    case 1:
        Console.WriteLine("You owe favors");
        break;
    case 2:
        Console.WriteLine("You do not owe any favors");
        break;
    case 3:
        Console.WriteLine();
        break;



}
