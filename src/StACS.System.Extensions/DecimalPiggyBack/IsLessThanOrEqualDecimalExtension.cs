namespace System
{
    public static class IsLessThanOrEqualDecimalExtension
    {
        /// <summary>
        ///     Evaluates if source decimal is less than or equal to provided decimal
        /// </summary>
        /// <param name="source">The source decimal to evaluate</param>
        /// <param name="minimumValue">The decimal to evaluate against</param>
        /// <returns>Boolean indicating if the source decimal is less than or equal to the provided decimal or not</returns>
        public static bool IsLessThanOrEqual(this decimal source, decimal minimumValue)
        {
            return source <= minimumValue;
        }
    }
}
