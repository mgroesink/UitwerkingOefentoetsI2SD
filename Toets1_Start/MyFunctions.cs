namespace I1SD_Toets1_Start
{
    public static class MyFunctions
    {
        /// <summary>
        /// Returns the string "Welkom bij deze ASP-NET / C# toets"
        /// </summary>
        /// <returns></returns>
        public static string Hallo()
        {
            return "Welkom bij deze ASP-NET / C# toets";
        }

        /// <summary>
        /// Gets the number sequence.
        /// </summary>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static List<(int, decimal)> GetNumberSequence(int max)
        {
            // Check the input. Minimal value is 5, maximum value is 20.
            if(max < 5 || max > 20)
            {
                throw new ArgumentException("De waarde voor max moet tussen 5 en 20 liggen.");
            }
            var tupels = new List<(int, decimal)>();
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    tupels.Add((i, i * i));
                }
                else
                {
                    tupels.Add((i, (decimal)Math.Pow(i, i)));
                }
            }
            return tupels;
        }
    }
}
