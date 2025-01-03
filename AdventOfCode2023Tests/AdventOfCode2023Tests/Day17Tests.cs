using AdventOfCode2023.Solutions.Day_17;

namespace AdventOfCode2023Tests
{
    public class Day17Tests
    {
        List<string> testStringInput = new List<string>
        {
            "2413432311323",
            "3215453535623",
            "3255245654254",
            "3446585845452",
            "4546657867536",
            "1438598798454",
            "4457876987766",
            "3637877979653",
            "4654967986887",
            "4564679986453",
            "1224686865563",
            "2546548887735",
            "4322674655533"
        };

        [Fact]
        public void SolutionA1()
        {
            var sut = new SolutionA();

            var result = sut.TestSolve(testStringInput);

            Assert.Equal("102", result.Output);
        }

        [Fact]
        public void SolutionA2()
        {
            var sut = new SolutionA();
            testStringInput = new List<string>
            {
                "11111",
                "22221",
                "33331",
                "22221",
                "11111"
            };

            var result = sut.TestSolve(testStringInput);

            Assert.Equal("9", result.Output);
        }

        [Fact]
        public void SolutionA3()
        {
            var sut = new SolutionA();
            testStringInput = new List<string>
            {
                "12222",
                "12222",
                "11111",
                "12222",
                "12222"
            };

            var result = sut.TestSolve(testStringInput);

            Assert.Equal("11", result.Output);
        }

        [Fact]
        public void SolutionA4()
        {
            var sut = new SolutionA();
            testStringInput = new List<string>
            {
                "1111",
                "4491",
                "2221",
                "2221",
                "2291"
            };

            var result = sut.TestSolve(testStringInput);

            Assert.Equal("11", result.Output);
        }

        [Fact]
        public void SolutionB()
        {
            var sut = new SolutionB();

            var result = sut.TestSolve(testStringInput);

            Assert.Equal("94", result.Output);
        }
    }
}