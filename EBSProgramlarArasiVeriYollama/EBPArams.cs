using System;

namespace EBSProgramlarArasiVeriYollama
{
    class EBPArams
    {
        private static object[] EBSARgument = null;
        public static void Set(object[] arg)
        {

            EBSARgument = arg;
        }

        public static object[] Get()
        {
            return EBSARgument;
        }
    }
}
