namespace System
{
    static class StringCut
    {
        public static string Cut(this string obj, int n)
        {
            if(obj.Length <= n)
            {
                return obj;
            }
            else
            {
                return obj.Substring(0, n) + "...";
            }
        }
    }
}
