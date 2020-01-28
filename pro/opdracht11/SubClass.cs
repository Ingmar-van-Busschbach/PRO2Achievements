using System;

using NameSpace2;

namespace opdracht11
{
    class SubClass
    {
        protected static int staticValueInClass = 60;

        public int valueInClass = 50;
        public static int Function2Static()
        {
            int temporalValueInClass = 40;
            return temporalValueInClass;
        }

        public int Function2()
        {
            int temporalValueInClass = 30;
            return temporalValueInClass;
        }
    }
}
