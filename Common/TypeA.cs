using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{     // TypeA Accessible Within its Project and Within External Project [Import]

    public class TypeA
    {
        public TypeA() {
            TypeB typeb = new TypeB(); //valid
        }

        private int X;    // Accessible within its scope ONLY
        internal int Y;   // Accessible within its scope and its project
        public int Z;     // Accessible within its scope, its project, and external projects [import]

    }
}
