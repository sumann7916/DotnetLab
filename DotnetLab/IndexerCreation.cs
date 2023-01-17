using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetLab
{
    internal class IndexerCreation
    {
        private int[] arr = new int[10];

        public int this[int i]
        {
            get {
                return arr[i];
            }
            set {
                arr[i] = value;
            }
        }



    }
}
