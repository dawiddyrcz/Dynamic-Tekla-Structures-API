using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic.Tekla.Structures
{
    public enum SomeEnum
    {
        Value1,
        Value2
    }

    public static class SomeEnumMethods
    {
        public static string GetSomething(this SomeEnum some)
        {
            return "something";
        }
    }

    public class M
    {
        public static void SSS()
        {
            var ss = SomeEnum.Value1;
            ss.GetSomething();
        }
    }
}
