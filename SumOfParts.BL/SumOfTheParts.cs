namespace SumOfParts.BL
{
    public class SumOfTheParts : ISumOfParts
    {
        //public int[] PartsSums(int[] ls)
        //{
        //    if (ls.Length == 0)
        //    {
        //        return new int[] { 0 };
        //    }

        //    var result = new List<int> { ls.Sum() };

        //    var forIteration = ls.Reverse().ToList();

        //    for (int i = ls.Length -1; i >= 0; i--)
        //    {
        //        forIteration.RemoveAt(i);

        //        result.Add(forIteration.Sum());
        //    }

        //    return result.ToArray();
        //}

        public int[] PartsSums(int[] ls)
        {
            if (ls.Length == 0)
            {
                return new int[] { 0 };
            }

            var lsList = ls.ToList();

            var result = new List<int>();

            SumCalculator(result, lsList);

            return result.ToArray();
        }

        public void SumCalculator(List<int> result, List<int> lsList) 
        {
            if (lsList.Count == 0)
            {
                result.Add(0);
            }

            if (lsList.Count > 0)
            {
                result.Add(lsList.Sum());

                lsList.RemoveAt(0);

                SumCalculator(result, lsList);
            }
        }
    }
}