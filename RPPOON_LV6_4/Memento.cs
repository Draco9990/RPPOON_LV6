using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV6_4
{
    class Memento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }
        public DateTime MementoTime { get; private set; }
        public Memento(string ownerName, string ownerAdress, decimal balance)
        {
            this.OwnerName = ownerName;
            this.OwnerAddress = ownerAdress;
            this.Balance = balance;
            this.MementoTime = DateTime.Now;
        }
    }
}
