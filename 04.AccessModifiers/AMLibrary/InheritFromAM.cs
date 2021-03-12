using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibrary
{
    class InheritFromAM : AccessAM
    {
        public void TestAccessModifiers()

        {
            ProtectedAM();
            InternalAM();
            PrivateProtectedAM();
            ProtectedInternalAM();
        }
    }
}
