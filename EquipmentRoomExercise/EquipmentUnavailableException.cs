using System;
using System.Collections.Generic;
using System.Text;

namespace EquipmentRoomExercise
{
    internal class EquipmentUnavailableException : Exception
    {
        public int Available { get; }
        public int Amount { get; }
        public EquipmentUnavailableException(int available, int amount) : base($"Requested {amount} items, but only {available} are available.")
        {
            this.Available = available;
            this.Amount = amount;
        }
    }
}
