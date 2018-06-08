using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC3.Unity.TetrahedralGrowth
{
    ///<summary>
    ///
    /// </summary>
    /// 
    public struct Tetra
    {
        public int A;
        public int B;
        public int C;
        public int D;


        public Tetra(int v0, int v1, int v2, int v3)
        {
            A = v0;
            B = v1;
            C = v2;
            D = v3;

        }
    }
}