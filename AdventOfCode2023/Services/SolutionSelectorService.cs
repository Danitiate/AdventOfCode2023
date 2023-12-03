﻿using AdventOfCode2023.Models;
using System.Collections.Generic;

namespace AdventOfCode2023.Services
{
    public class SolutionSelectorService
    {
        public static List<ISolution> GetRequestedSolutions(string userInput)
        {
            var solutions = new List<ISolution>();
            var inputAsInt = int.Parse(userInput);
            switch (inputAsInt)
            {
                case 1: solutions.AddRange([new Solutions.Day_1.SolutionA(), new Solutions.Day_1.SolutionB()]); break;
                case 2: solutions.AddRange([new Solutions.Day_2.SolutionA(), new Solutions.Day_2.SolutionB()]); break;
                case 3: solutions.AddRange([new Solutions.Day_3.SolutionA()]); break;
            }

            return solutions;
        }
    }
}
