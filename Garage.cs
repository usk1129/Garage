using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    //Vehicle, IEnumerable, new ()
    public class Garage<T>
    {
        private T[] Vehicles;
        public int capacity;

        public Garage( int capacity)
        {
            Vehicles = new T[capacity];

        }


        public IEnumerator<T> GetVehicles()
        {
            foreach (var item in Vehicles)
            {
                yield return (T)(IEnumerator<T>)item;
            }
        }

    }
}
