using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    //Vehicle, IEnumerable, new ()

    public class Garage<T>: IEnumerable<T>   where T : Vehicle
    {
        private T[] Vehicles;
        public int capacity;


        public Garage(int capacity)
        {
            Vehicles = new T[capacity];
        }

        public void PrintVehicles()
        {
            foreach (var v in Vehicles)
            {
                Console.WriteLine(v.Stats());
            }
        }

        public bool RemoveVehicle(string RegNo)
        {
            bool RemovedFromSlot = false;
     
            for(int i = 0; i < Vehicles.Length; i++)
            {
                if(Vehicles[i] != null)
                {
                    if (Vehicles[i].RegisterNumber == RegNo)
                    {
                        Vehicles[i] = null;
                        RemovedFromSlot = true;
                        break;
                    }
                }
            }

            return RemovedFromSlot;
        }

        public bool FindVehicle(string RegNo)
        {
            bool Found = false;
            for(int i = 0; i < Vehicles.Length; i++)
            {
                if(Vehicles[i] != null)
                {
                    if (Vehicles[i].RegisterNumber == RegNo)
                    {
                        Console.WriteLine(Vehicles[i].Stats());
                        Found = true;
                        break;
                    }
                }
            }
            return Found;
        }

        public bool AddVehicle(T item)
        
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Vehicles.Length; i++)
            {
                if (Vehicles[i] != null)
                {
                    yield return Vehicles[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Vehicles.GetEnumerator();
        }

        internal bool MaxCapacity()
        {
            bool reachedCap = true;
            for (int i = 0; i < Vehicles!.Length; i++)
            {
                if (Vehicles[i] == null)
                {
                    reachedCap = false;

                }
            }
            return reachedCap;
        }
    }



}

