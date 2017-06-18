namespace System
{
    public static class IsGreaterThanOrEqualIntegerExtension
    {
        /// <summary>
        ///     Evaluates if source integer is greater than or equal to provided integer
        /// </summary>
        /// <param name="source">The source integer to evaluate</param>
        /// <param name="minimumValue">The integer to evaluate against</param>
        /// <returns>Boolean indicating if the source integer is greater than or equal to the provided integer or not</returns>
        public static bool IsGreaterThanOrEqual(this int source, int minimumValue)
        {
            return source >= minimumValue;
        }
    }
}