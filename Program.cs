using System;

class Ali
{
    public static void Main()
    {
        Costumer C1 = new Costumer();
        C1.ID = 101;
        C1.Name = "John Lorusso";
        C1.Salary = 5000;
        C1.gender = "Male";

        Costumer C2 = new Costumer();
        C2.ID = 102;
        C2.Name = "Ibrahim Arabaki";
        C2.Salary = 6000;
        C2.gender = "Male";

        Costumer C3 = new Costumer();
        C3.ID = 103;
        C3.Name = "Mary Luisse";
        C3.Salary = 7000;
        C3.gender = "Female";

        List<Costumer> Male = new List<Costumer>();
        Male.Add(C1);
        Male.Add(C2);

        Console.WriteLine("Printing the Male List.");
        Console.WriteLine("--------------------------------------------------------------------------------------");


        foreach (Costumer CM in Male)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", CM.ID, CM.Name, CM.Salary, CM.gender);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }     
        
        List<Costumer> Female = new List<Costumer>();
        Female.Add(C3);

        Console.WriteLine("Printing the Female List.");
        Console.WriteLine("--------------------------------------------------------------------------------------");


        foreach (Costumer CF in Male)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", CF.ID, CF.Name, CF.Salary, CF.gender);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }    

        List<Costumer> CompleteList = new List<Costumer>();

        Console.WriteLine("AddRange Function");
        Console.WriteLine("--------------------------------------------------------------------------------------");

        CompleteList.AddRange(Male);
        CompleteList.AddRange(Female);

        Console.WriteLine("Both Lists Combined");
        Console.WriteLine("Printing the Combined List");
        Console.WriteLine("--------------------------------------------------------------------------------------");

        foreach (Costumer C in CompleteList)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.gender);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        Console.WriteLine("Swapping Male & Female Items in the List using Insert & RemoveAt Functions");

        CompleteList.Insert(0,C3);
        CompleteList.RemoveAt(3);

        Console.WriteLine("Items Swapped");
        Console.WriteLine("--------------------------------------------------------------------------------------");

        foreach (Costumer C in CompleteList)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.gender);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }

        Console.WriteLine("Removing Male Gender using RemoveAll Function");
        Console.WriteLine("--------------------------------------------------------------------------------------");

        CompleteList.RemoveAll(x => x.gender == "Male");

        foreach (Costumer C in CompleteList)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Gender = {3}", C.ID, C.Name, C.Salary, C.gender);
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }        
    }
}

public class Costumer
{
    public int ID {get; set; }
    public string Name {get; set; }
    public int Salary {get; set; }
    public string gender {get; set;}
}