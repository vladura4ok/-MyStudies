using System;

namespace UtilityLibraries
{
    public static class StringLibrary
    {
        public static int StartsWithUpper(int first, int second)
        {
            int result = 0;
            for (int i = 0; i < first; i++)
                result += second;
            return result;
        }
    }
}