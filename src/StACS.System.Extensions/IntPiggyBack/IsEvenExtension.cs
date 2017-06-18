namespace System
{
    public static class IsEvenExtension
    {
        /// <summary>
        ///     Evaluates if integer is even
        /// </summary>
        /// <param name="source">The source integer to evaluate</param>
        /// <returns>Boolean indicating if integer is even or not</returns>
        public static bool IsEven(this int source)
        {
            return source % 2 == 0;
        }
    }
}