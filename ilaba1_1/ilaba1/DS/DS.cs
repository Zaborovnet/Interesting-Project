using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace DSapp.DS
{
    public class DS1
    {

        public  int D(int args)
        {

            int D;
            D = args * 2;
            return D;

        }

        public  double S(int args)
        {

            double S;
            S = Math.PI*args*args;
            return S;

        }
    }
}
