using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_4
{
    class CareTaker
    {
        private List<Memento> states;

        public CareTaker()
        {
            states = new List<Memento>();
        }

        public void StoreState(Memento newState)
        {
            states.Add(newState);
        }

        public Memento GetState(int state)
        {
            if (state > states.Count - 1 || state < 0)
            {
                Console.WriteLine("Invalid! Restoring the latest one!");
                state = states.Count - 1;
            }
            return states[state];
        }

        public void PrintStates()
        {
            int i = -1;
            if(states.Count == 0)
            {
                Console.WriteLine("No save points!");
            }
            foreach(Memento state in states)
            {
                i++;
                Console.WriteLine("(" + i + ") - " + states[i].OwnerName + " with balance of " + states[i].Balance + " - " + states[i].MementoTime);
            }
        }

        public void ClearAll()
        {
            states.Clear();
        }

        public int Count()
        {
            return states.Count;
        }

        public void DeleteState(int state)
        {
            states.RemoveAt(state);
        }
    }
}
