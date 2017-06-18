namespace System
{
    public static class IsLessThanDecimalExtension
    {
        /// <summary>
        ///     Evaluates if the source decimal is less than provided decimal
        /// </summary>
        /// <param name="source">The source decimal to evaluate</param>
        /// <param name="minimumValue">The decimal to evaluate against</param>
        /// <returns>Boolean indicating if source decimal is less than the provided decimal or not</returns>
        public static bool IsLessThan(this decimal source, decimal minimumValue)
        {
            return source < minimumValue;
        }
    }
}