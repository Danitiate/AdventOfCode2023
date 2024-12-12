﻿using AdventOfCode.Core.Models;
using System;

namespace AdventOfCode2023.Solutions.Day_18
{
    /**
     *  PART 1
     *  1. 
     **/
    public class SolutionA : Solution
    {
        protected override string GetSolutionOutput()
        {
            var minimumAmountOfHeatLoss = CalculateLavaVolume();
            return minimumAmountOfHeatLoss.ToString();
        }

        private int CalculateLavaVolume()
        {
            throw new NotImplementedException();
        }
    }
}