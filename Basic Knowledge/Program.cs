using System;
using System.Collections.Generic;

public class Friend
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public override string ToString()
    {
        
        return Name.ToUpper() + Surname.ToUpper();
    }

    
}


public class Loop
{
    public static void Main()
    {
        List<Friend> friends = new List<Friend>();
        friends.Add(new Friend() { Name = "Fired, ", Surname = "Corwill" });
        friends.Add(new Friend() { Name = "Wilfred, ", Surname = "Corwill" });
        friends.Add(new Friend() { Name = "Barney, ", Surname = "TornBull" });
        friends.Add(new Friend() { Name = "Betty, ", Surname = "Tornbull" });
        friends.Add(new Friend() { Name = "Bjon, ", Surname = "Tornbull" });
        friends.Add(new Friend() { Name = "Raphael, ", Surname = "Corwill" });
        friends.Add(new Friend() { Name = "Alfred, ", Surname = "Corwill", });

        

        Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
        Console.WriteLine("Before sort:");
        Console.ResetColor(); // сбрасываем в стандартный

        foreach (Friend friend in friends)
        {
            Console.WriteLine(friend);
        }



        friends.Sort(delegate (Friend x, Friend y)
        {
            if (x.Surname == null && y.Surname == null) return 0;
            else if (x.Surname == null) return -1;
            else if (y.Surname == null) return 1;
            else if (x.Surname == y.Surname) return x.Name.CompareTo(y.Name);
            else return x.Surname.CompareTo(y.Surname);

        });



        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nAfter sort:");
        Console.ResetColor();

        foreach (Friend friend in friends)
        {
            Console.WriteLine(friend);
        }
    }
}