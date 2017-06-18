namespace System
{
    public static class IsGreaterThanDecimalExtension
    {
        /// <summary>
        ///     Evaluates if the source decimal is greater than provided decimal
        /// </summary>
        /// <param name="source">The source decimal to evaluate</param>
        /// <param name="minimumValue">The decimal to evaluate against</param>
        /// <returns>Boolean indicating if source decimal is greater than the provided decimal or not</returns>
        public static bool IsGreaterThan(this decimal source, decimal minimumValue)
        {
            return source > minimumValue;
        }
    }
}