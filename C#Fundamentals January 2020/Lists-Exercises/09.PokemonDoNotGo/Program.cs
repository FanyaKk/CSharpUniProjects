using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDoNotGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            
            int removedNumber = 0;
            int replacingNumber = 0;
            int sumOfRemovedElements = 0;

            while (numbers.Count > 0)
            {
                bool isInRange = true;
                int index = int.Parse(Console.ReadLine());
                
                if (index < 0 || index > numbers.Count - 1)
                {
                    isInRange = false;
                }
                if (isInRange)
                {
                    removedNumber = numbers[index];
                    numbers.RemoveAt(index);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > removedNumber)
                        {
                            numbers[i] -= removedNumber;
                        }
                        else if (numbers[i] <= removedNumber)
                        {
                            numbers[i] += removedNumber;
                        }
                    }
                }
                else if (isInRange == false)
                {
                    if (index < 0)
                    {
                        index = 0;
                        replacingNumber = numbers[numbers.Count - 1];
                    }
                    else if (index > numbers.Count - 1)
                    {
                        index = numbers.Count - 1;
                        replacingNumber = numbers[0];
                    }
                    removedNumber = numbers[index];
                    numbers.RemoveAt(index);
                    numbers.Insert(index, replacingNumber);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] > removedNumber)
                        {
                            numbers[i] -= removedNumber;
                        }
                        else if (numbers[i] <= removedNumber)
                        {
                            numbers[i] += removedNumber;
                        }
                    }
                }
                sumOfRemovedElements += removedNumber;
            }
            Console.WriteLine(sumOfRemovedElements);
        }
    }
}
//Exercise 9. * Pokemon Don’t Go
//Ely likes to play Pokemon Go a lot.But Pokemon Go bankrupted … So the developers made Pokemon Don’t Go out of
//depression. And so Ely now plays Pokemon Don’t Go. In Pokemon Don’t Go, when you walk to a certain pokemon,
//those closer to you, naturally get further, and those further from you, get closer.

//You will receive a sequence of integers, separated by spaces – the distances to the pokemons.Then you will begin
//receiving integers, which will correspond to indexes in that sequence.
//When you receive an index, you must remove the element at that index from the sequence (as if you’ve captured
//the pokemon).

// You must increase the value of all elements in the sequence, which are less or equal to the removed
//element, with the value of the removed element.
// You must decrease the value of all elements in the sequence, which are greater than the removed element,
//with the value of the removed element.

//If the given index is less than 0, remove the first element of the sequence, and copy the last element to its place.
//If the given index is greater than the last index of the sequence, remove the last element from the sequence, and
//copy the first element to its place.
//The increasing and decreasing of elements should be done in these cases, also.The element, whose value you
//should use is the removed element.

//The program ends when the sequence has no elements (there are no pokemons left for Ely to catch).

//Input
// On the first line of input you will receive a sequence of integers, separated by spaces.
// On the next several lines you will receive integers – the indexes.

//Output
// When the program ends, you must print the summed value of all removed elements.

//Constrains
// The input data will consist only of valid integers in the range [-2.147.483.648, 2.147.483.647].

//Examples
//Input        |  Output  |  Comments
//------------------------------------------------------------------------------------------------
//4 5 3        |  14      |  The array is { 4, 5, 3}. The index is 1.
//1            |          |  We remove 5, and we increase all the lower ones and decrease all
//1            |          |  higher ones.
//0            |          |  In this case there are no higher than 5.
//             |          |  The result is { 9, 8}.
//             |          |  The index is 1. So we remove 8, and decrease all the higher ones.
//             |          |  The result is { 1}.
//             |          |  The index is 0. So we remove 1.
//             |          |  There are no elements left, so we print the sum of all removed
//             |          |  elements.
//             |          |  5 + 8 + 1 = 14.
//------------------------------------------------------------------------------------------------
//5 10 6 3 5   |  51      |  Step 1: {11, 4, 9, 11}
//2            |          |  Step 2: {22, 15, 20, 22}
//4            |          |  Step 3: {7, 5, 7}
//1            |          |  Step 4: {2, 2}
//1            |          |  Step 5: {4, 4}
//3            |          |  Step 6: {8}
//0            |          |  Step 7: {} (empty).
//0            |          |  Result = 6 + 11 + 15 + 5 + 2 + 4 + 8 = 51.