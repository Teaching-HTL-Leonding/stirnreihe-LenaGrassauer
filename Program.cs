using System.Xml.Serialization;
using Stirnreihe.Data;
var line = new LineOfPersons();

do
{
    System.Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?\n 1) Add a person to the line\n 2) Print the line \n 3) Clear the line \n 4) Exit");
    System.Console.Write("Your Choice: ");
    int choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            
            System.Console.Write("First Name: ");
            string firstName = Console.ReadLine()!;
            System.Console.Write("Last Name: ");
            string lastName = Console.ReadLine()!;
            System.Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine()!);

            Person newPerson = new Person(firstName, lastName, height);
            line.AddToFront(newPerson);

            break;
        case 2:
            for(var node = line.First; node != null; node = node.Next)
            {
                Console.WriteLine(node.Person.ToString());
            }
            break;
        case 3:
            System.Console.WriteLine("The line has been cleared!");
            line.Clear();
            break;
        case 4: return;
        default : break;
    }

} while (true);
