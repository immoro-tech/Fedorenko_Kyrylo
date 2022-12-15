using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5;
public class Loop
{
    internal class Friend
    {

        private string _name = "";
        private string _surname = "";
        public string Name { get => _name; set => _name = value.ToUpper(); }
        public string Surname { get => _surname; set => _surname = value.ToUpper(); }

        public override string ToString()
        {
            return $"({Surname}, {Name})";
        }


    }
    public static string FriendList(string friendlist)
    {
        string[] friendsName = friendlist.Split(';');
        List<Friend> friends = new List<Friend>();

        foreach (string friendName in friendsName)
        {
            string[] name = friendName.Split(':');
            try
            {
                friends.Add(new Friend()
                {
                    Name = name[0],
                    Surname = name[1]
                });
            }
            catch (Exception)
            {
                throw new Exception("Format failure...");
            }
        }


        var resultlist = friends.OrderBy(friend => friend.Surname)
            .ThenBy(friend => friend.Name)
            .Select(friend => friend.ToString());
        return string.Join("", resultlist);

    }

    static void Main()
    {
        string actual = ("Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");
        Loop loop = new Loop();
        Console.WriteLine(FriendList(actual));

    }

}





