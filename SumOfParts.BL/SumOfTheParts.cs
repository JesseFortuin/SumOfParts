namespace SumOfParts.BL
{
    public class SumOfTheParts : ISumOfParts
    {
        public int[] PartsSums(int[] ls)
        {
            if (ls.Length == 0)
            {
                return new int[] { 0 };
            }

            var result = new List<int> { ls.Sum() };

            var forIteration = ls.Reverse().ToList();

            for (int i = ls.Length -1; i >= 0; i--)
            {
                forIteration.RemoveAt(i);

                result.Add(forIteration.Sum());
            }

            return result.ToArray();
        }
    }
}