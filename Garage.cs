using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    //Vehicle, IEnumerable, new ()
    public class Garage<T> : IEnumerable<T>
    {
        private T[] Vehicles;
        public int capacity;

        public Garage(int capacity)
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



        public bool AddVehicle(T item)
        {
            {
                bool addedToSlot = false;
                for (int i = 0; i < Vehicles.Length; i++)
                {
                    if (Vehicles[i] == null)
                    {
                        Vehicles[i] = item;
                        addedToSlot = true;
                        break;
                    }
                }
                return addedToSlot;

            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
