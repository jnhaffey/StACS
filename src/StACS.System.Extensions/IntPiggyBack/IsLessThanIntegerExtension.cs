namespace System
{
    public static class IsLessThanIntegerExtension
    {
        /// <summary>
        ///     Evaluates if the source integer is less than provided integer
        /// </summary>
        /// <param name="source">The source integer to evaluate</param>
        /// <param name="minimumValue">The integer to evaluate against</param>
        /// <returns>Boolean indicating if source integer is less than the provided integer or not</returns>
        public static bool IsLessThan(this int source, int minimumValue)
        {
            return source < minimumValue;
        }
    }
}