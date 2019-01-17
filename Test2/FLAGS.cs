using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public static class FLAGS
    {
        [Flags]
        public enum MODELS
        { SETTINGS, PATIANTMANGE, TESTMANGE,VISTEINFON }
    }
}
