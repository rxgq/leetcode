using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.easy
{
    public class ParkingSystem {

        public int b;
        public int m;
        public int s;

        public ParkingSystem(int big, int medium, int small) {
            b = big;
            m = medium;
            s = small;
        }
    
        public bool AddCar(int carType) {
            if (carType == 1) {
                if (b == 0) return false;
                b--;
            }

            if (carType == 2) {
                if (m == 0) return false;
                m--;
            }

            if (carType == 3) {
                if (s == 0) return false;
                s--;
            }

            return true;
        }
    }
}
