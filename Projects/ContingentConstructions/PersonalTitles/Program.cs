using System;

namespace PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            if (gender == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
//Обръщение според възраст и пол
//Да се напише конзолна програма, която прочита възраст(реално число) и пол(&#39;m&#39; или &#39;f&#39;), въведени от
//потребителя, и отпечатва обръщение измежду следните:
// &quot; Mr.&quot; – мъж(пол &#39;m&#39;) на 16 или повече години
// &quot; Master&quot; – момче(пол &#39;m&#39;) под 16 години
// &quot; Ms.&quot; – жена(пол &#39;f&#39;) на 16 или повече години
// &quot; Miss&quot; – момиче(пол &#39;f&#39;) под 16 години