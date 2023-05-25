using SumOfParts.BL;

namespace SumOfParts.Test
{
    public class SumOfPartsTest
    {
        [Fact]
        public void PartsSums_StraightForward()
        {
            //arrange
            ISumOfParts sumOf = new SumOfTheParts();

            var input = new int[] { 1, 2, 3, };

            var expected = new int[] { 6, 5, 3, 0 };

            //act
            var actual = sumOf.PartsSums(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PartsSums_ZeroValueAtStart()
        {
            //arrange
            ISumOfParts sumOf = new SumOfTheParts();

            var input = new int[] { 0, 1, 3, 6, 10 };

            var expected = new int[] { 20, 20, 19, 16, 10, 0 };

            //act
            var actual = sumOf.PartsSums(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PartsSums_LargeFigures()
        {
            //arrange
            ISumOfParts sumOf = new SumOfTheParts();

            var input = new int[] { 744125, 935, 407, 454, 430, 90, 144, 6710213, 889, 810, 2579358 };

            var expected = new int[] { 10037855, 9293730, 9292795, 9292388, 9291934, 9291504, 9291414, 9291270, 2581057, 2580168, 2579358, 0 };

            //act
            var actual = sumOf.PartsSums(input);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void PartsSums_EmptyArray()
        {
            //arrange
            ISumOfParts sumOf = new SumOfTheParts();

            var input = new int[] { };

            var expected = new int[] { 0 };

            //act
            var actual = sumOf.PartsSums(input);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}