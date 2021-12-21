using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Garage<T> where T : Vehicle, IEnumerable
    {
        protected T[] Vehicles;
        private int capacity;

        public Garage( int capacity)
        {
            this.capacity = Math.Max(capacity, 1);
            Vehicles = new T[capacity];

        }

        public T getVehiclebyIndex(int index)
        {
            return Vehicles[index];
        }

        public IEnumerator GetVehicles()
        {
            foreach(var v in Vehicles)
            {
                yield return v;
            }
        }

    }
}
