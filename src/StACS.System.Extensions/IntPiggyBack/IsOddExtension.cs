namespace System
{
    public static class IsOddExtension
    {
        /// <summary>
        ///     Evaluates if integer is odd
        /// </summary>
        /// <param name="source">The source integer to evaluate</param>
        /// <returns>Boolean indicating if integer is odd or not</returns>
        public static bool IsOdd(this int source)
        {
            return source % 2 != 0;
        }
    }
}