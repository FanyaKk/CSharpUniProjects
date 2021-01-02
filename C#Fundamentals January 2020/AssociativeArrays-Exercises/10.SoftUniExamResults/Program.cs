using System;
using System.Linq;
using System.Collections.Generic;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> usernameResult = new Dictionary<string, int>();
            Dictionary<string, int> languageSubmissions = new Dictionary<string, int>();

            string command = string.Empty;

            while((command = Console.ReadLine()) != "exam finished")
            {
                string[] input = command.Split("-").ToArray();

                if (input.Contains("banned"))
                {
                    string username = input[0];
                    usernameResult.Remove(username);
                }
                else
                {
                    string username = input[0];
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    if (!usernameResult.ContainsKey(username))
                    {
                        usernameResult.Add(username, points);  
                    }
                    else
                    {
                        if (usernameResult[username] < points)
                        {
                            usernameResult[username] = points;
                        }
                    }
                    if (!languageSubmissions.ContainsKey(language))
                    {
                        languageSubmissions.Add(language, 0);
                    }
                    languageSubmissions[language]++;
                }
            }

            Console.WriteLine($"Results:\n{string.Join(Environment.NewLine, usernameResult.OrderByDescending(v=>v.Value).ThenBy(k=>k.Key).Select(x=>$"{x.Key} | {x.Value}"))}");
            Console.WriteLine($"Submissions:\n{string.Join(Environment.NewLine, languageSubmissions.OrderByDescending(v=>v.Value).ThenBy(k=>k.Key).Select(x=>$"{x.Key} - {x.Value}"))}");
        }
        //static void Main(string[] args)                   //version 1.0
        //{
        //    Dictionary<string, int> participants = new Dictionary<string, int>();
        //    Dictionary<string, int> languages = new Dictionary<string, int>();

        //    string command = "";
        //    int maxPoints = 0;

        //    while ((command = Console.ReadLine()) != "exam finished")
        //    {
        //        string[] input = command.Split("-").ToArray();
        //        string username = input[0];
        //        if (input.Length > 2)
        //        {
        //            string language = input[1];
        //            int points = int.Parse(input[2]);
        //            if (!participants.ContainsKey(username))
        //            {
        //                participants.Add(username, points);
        //            }
        //            if (participants[username] < points)
        //            {
        //                participants[username] = points;
        //            }

        //            if (!languages.ContainsKey(language))
        //            {
        //                languages.Add(language, 0);
        //            }
        //            languages[language]++;
        //        }
        //        else
        //        {
        //            foreach (var item in participants)
        //            {
        //                if (item.Key == username)
        //                {
        //                    participants.Remove(username);
        //                }
        //            }
        //        }
        //    }
        //    participants = participants
        //        .OrderByDescending(kvp => kvp.Value)
        //        .ThenBy(kvp => kvp.Key)
        //        .ToDictionary(a => a.Key, b => b.Value);
        //    languages = languages
        //        .OrderByDescending(kvp => kvp.Value)
        //        .ThenBy(kvp => kvp.Key)
        //        .ToDictionary(a => a.Key, b => b.Value);
        //    Console.WriteLine("Results:");
        //    foreach (var participant in participants)
        //    {
        //        Console.WriteLine($"{participant.Key} | {participant.Value}");
        //    }
        //    Console.WriteLine("Submissions:");
        //    foreach (var lang in languages)
        //    {
        //        Console.WriteLine($"{lang.Key} - {lang.Value}");
        //    }
        //}
    }
}
//10. * SoftUni Exam Results
//
//Judge statistics on the last Programing Fundamentals exam was not working correctly, so you have the task to take
//all the submissions and analyze them properly. You should collect all the submissions and print the final results and
//statistics about each language that the participants submitted their solutions in.
//You will be receiving lines in the following format: "{username}-{language}-{points}" until you receive
//"exam finished". You should store each username and his submissions and points.
//You can receive a command to ban a user for cheating in the following format: "{username}-banned". In that
//case, you should remove the user from the contest, but preserve his submissions in the total count of submissions
//for each language.
//After receiving "exam finished" print each of the participants, ordered descending by their max points, then by
// username, in the following format:
//Results:
//{username} | {points}
//…
//After that print each language, used in the exam, ordered descending by total submission count and then by
//language name, in the following format:
//Submissions:
//{language} – {submissionsCount}
//…
//Input / Constraints
//
//Until you receive "exam finished" you will be receiving participant submissions in the following format:
//"{username}-{language}-{points}".
//You can receive a ban command -> "{username}-banned"
//The points of the participant will always be a valid integer in the range[0 - 100];
//
//Output
//
// Print the exam results for each participant, ordered descending by max points and then by username, in the
//following format:
//Results:
//{username} | {points}
//…
// After that print each language, ordered descending by total submissions and then by language name, in the
//following format:
//Submissions:
//{language} – {submissionsCount}
//…
// Allowed working time / memory: 100ms / 16MB.
//
//Examples
//
//Input                     Output                  Comment
//---------------------------------------------------------------------------------------------------------------
//Pesho-Java-84             Results:                We order the participant descending by max points and
//Gosho-C#-84               Kiro | 94               then by name, printing only the username and the max
//Gosho-C#-70               Gosho | 84              points.
//Kiro-C#-94                Pesho | 84              After that we print each language along with the count of
//exam finished             Submissions:            submissions, ordered descending by submissions count, and
//                          C# - 3                  then by language name.
//                          Java - 1
//---------------------------------------------------------------------------------------------------------------
//Pesho-Java-91             Results:                Kiro is banned so he is removed from the contest, but
//Gosho-C#-84               Pesho | 91              he`s submissions are still preserved in the languages
//Kiro-Java-90              Gosho | 84              submissions count.
//Kiro-C#-50                Submissions:            So althou there are only 2 participants in the results,
//Kiro-banned               C# - 2                  there are 4 submissions in total.
//exam finished             Java - 2