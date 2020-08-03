using System;

namespace IsEven
{
    public static class Is
    {
        public static bool Even(int value)
        {
            return value % 2 == 0;
        }

        public static bool Odd(int value)
        {
            return value % 2 != 0;
        }

    }
}
