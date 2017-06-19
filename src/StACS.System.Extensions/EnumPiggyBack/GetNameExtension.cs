namespace System
{
    public static class GetNameExtension
    {
        /// <summary>
        ///     Gets the name of source enum
        /// </summary>
        /// <param name="source">The source enum to execute against</param>
        /// <returns>The string value of the enum name</returns>
        public static string GetName(this Enum source)
        {
            return Enum.GetName(source.GetType(), source);
        }
    }
}