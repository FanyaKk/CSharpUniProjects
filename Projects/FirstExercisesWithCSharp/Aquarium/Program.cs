using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            double aquariumLenght = double.Parse(Console.ReadLine());
            double aquariumWidth = double.Parse(Console.ReadLine());
            double aquariumHeight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aquariumCapacity = aquariumLenght * aquariumWidth * aquariumHeight;
            double totalLiters = aquariumCapacity * 0.001;
            double calculatedPercents = percent * 0.01;
            double litersNeeded = totalLiters * (1 - calculatedPercents);

            Console.WriteLine("{0:f3}", litersNeeded);// f3 се добавя, когато е необходимо резултатът да бъде закръглен до определн брой цифри след десетичната запетая - в случая 3. Ако това условие липсва се параметърът е скобите ще изглежда така: {0}!

        }
    }
}
//Рожден ден
//За рождения си ден Любомир получил аквариум с формата на паралелепипед.Първоначално прочитаме от
//конзолата на отделни редове размерите му – дължина, широчина и височина в сантиметри.Трябва да се
//пресметне колко литра вода ще събира аквариума, ако се знае, че определен процент от вместимостта му е
//заета от пясък, растения, нагревател и помпа.
//Един литър вода се равнява на един кубичен дециметър/ 1л=1 дм 3 /.
//Да се напише програма, която изчислява литрите вода, която са необходими за напълването на аквариума.