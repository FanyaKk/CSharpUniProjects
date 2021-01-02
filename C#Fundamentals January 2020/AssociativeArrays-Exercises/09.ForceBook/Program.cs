using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main (string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();

            string command = string.Empty;

            while((command=Console.ReadLine()) != "Lumpawaroo")
            {
                string[] input = command.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command.Contains("|"))
                {
                    string forceSide = input[0];
                    string forceUser = input[1];

                    if (!forceSides.ContainsKey(forceSide))
                    {
                        forceSides.Add(forceSide, new List<string>());
                    }
                    if (!forceSides.Values.Any(v=>v.Contains(forceUser)))
                    {
                        forceSides[forceSide].Add(forceUser);
                    }    
                }
                else if(command.Contains("->"))
                {
                    string forceUser = input[0];
                    string forceSide = input[1];

                    foreach (var side in forceSides)
                    {
                        if (side.Value.Contains(forceUser))
                        {
                            side.Value.Remove(forceUser);
                            break;
                        }
                    }
                    if (!forceSides.ContainsKey(forceSide))
                    {
                        forceSides.Add(forceSide, new List<string>());
                    }
                    forceSides[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }
            forceSides = forceSides
                .OrderByDescending(v => v.Value.Count)
                .ThenBy(k=>k.Key)
                .ToDictionary(a => a.Key, b => (List<string>)b.Value.OrderBy(x=>x).ToList());

            foreach (var side in forceSides)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    Console.WriteLine($"! {string.Join("\n! ", side.Value)}");
                }
            }
        }
        //static void Main(string[] args)                    //version 1.0
        //{
        //    Dictionary<string, List<string>> profiles = new Dictionary<string, List<string>>();

        //    string command = "";

        //    string forceUser = "";
        //    string forceSide = "";

        //    while ((command = Console.ReadLine()) != "Lumpawaroo")
        //    {
        //        //List<string> input = command.Split().ToList();
        //        string[] input = command.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        //        if (command.Contains("|"))
        //        {
        //            //input = command.Split(" | ").ToList();
        //            forceUser = input[1];
        //            forceSide = input[0];

        //            if (!profiles.ContainsKey(forceSide))
        //            {
        //                profiles.Add(forceSide, new List<string>());
        //            }
        //            if(!profiles.Values.Any(x => x.Contains(forceUser)))
        //            {
        //                profiles[forceSide].Add(forceUser);
        //            }   
        //        }
        //        else if (command.Contains("->"))
        //        {
        //            //input = command.Split(" -> ").ToList();
        //            forceUser = input[0];
        //            forceSide = input[1];

        //            foreach (var item in profiles)
        //            {
        //                if (item.Value.Contains(forceUser))
        //                {
        //                    item.Value.Remove(forceUser);
        //                }
        //            }
        //            if (!profiles.ContainsKey(forceSide))
        //            {
        //                profiles.Add(forceSide, new List<string>());   
        //            }
        //            profiles[forceSide].Add(forceUser);
        //            Console.WriteLine($"{forceUser} joins the {forceSide} side!"); 
        //        }
        //    }
        //    profiles = profiles
        //        .OrderByDescending(kvp => kvp.Value.Count)
        //        .ThenBy(kvp => kvp.Key)
        //        .ToDictionary(a => a.Key, b => b.Value);
        //    foreach (var profile in profiles)
        //    {
        //        List<string> sort = profile.Value
        //            .OrderBy(v => v)
        //            .ToList();

        //        if (profile.Value.Count > 0)
        //        {
        //            Console.WriteLine($"Side: {profile.Key}, Members: {sort.Count}");
        //            Console.WriteLine($"! {string.Join("\n! ", sort)}");
        //        }
        //    }
        //}
    }
}
//9. * ForceBook
//
//The force users are struggling to remember which side are the different forceUsers from, because they switch them
//too often.So you are tasked to create a web application to manage their profiles.You should store an information
//for every unique forceUser, registered in the application.
//You will receive several input lines in one of the following formats:
//{forceSide} | {forceUser}
//{forceUser} -> {forceSide}
//The forceUser and forceSide are strings, containing any character.
//If you receive forceSide | forceUser, you should check if such forceUser already exists, and if not, add
//him/her to the corresponding side.
//If you receive a forceUser -> forceSide, you should check if there is such a forceUser already and if so,
//change his/her side.If there is no such forceUser, add him/her to the corresponding forceSide, treating the
//command as a new registered forceUser.
//Then you should print on the console: "{forceUser} joins the {forceSide} side!"
//You should end your program when you receive the command "Lumpawaroo". At that point you should print each
//force side, ordered descending by forceUsers count, than ordered by name.For each side print the forceUsers,
//ordered by name.
//In case there are no forceUsers in a side, you shouldn`t print the side information.

//Input / Constraints
// The input comes in the form of commands in one of the formats specified above.
// The input ends, when you receive the command "Lumpawaroo".
//
//Output
// As output for each forceSide, ordered descending by forceUsers count, then by name, you must print all
//the forceUsers, ordered by name alphabetically.
// The output format is:
//Side: { forceSide}, Members: {forceUsers.Count}
//! {forceUser}
//! {forceUser}
//! {forceUser}
// In case there are NO forceUsers, don`t print this side.
//Examples

//Input                             Output                                       Comments

//Light | Gosho                     Side: Dark, Members: 1                       We register Gosho in
//Dark | Pesho                      ! Pesho                                      the Light side and
//Lumpawaroo                        Side: Light, Members: 1                      Pesho in the Dark
//                                                                               side.After receiving
//                                                                               "Lumpawaroo" we print
//                                                                               ! Gosho both sides, ordered
//                                                                               by membersCount and
//                                                                               then by name.
//
//----------------------------------------------------------------------------------------------------------------
//Lighter | Royal                   Ivan Ivanov joins the Lighter side!          Although Ivan Ivanov
//Darker | DCay                     DCay joins the Lighter side!                 doesn`t have profile,
//Ivan Ivanov -> Lighter            Side: Lighter, Members: 3                    we register him and
//DCay -> Lighter                   ! DCay                                       add him to the
//Lumpawaroo                        ! Ivan Ivanov                                Lighter side.
//                                  ! Royal                                      We remove DCay from
//                                                                               Darker side and add
//                                                                               him to Lighter side.
//                                                                               We print only Lighter
//                                                                               side because Darker
//                                                                               side has no members.