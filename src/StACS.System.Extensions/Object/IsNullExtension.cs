namespace StACS.System.ObjectExtensions
{
    public static class IsNullExtension
    {
        /// <summary>
        ///     Evaluates if object is null
        /// </summary>
        /// <param name="source">The object to evaluate</param>
        /// <returns>Boolean indicating if object is null or not</returns>
        public static bool IsNull(this object source)
        {
            return source == null;
        }
    }
}