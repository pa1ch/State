using System;

namespace CopyMachine.States
{
    public abstract class StateBase : IState
    {
        public abstract void AcceptMoney(CopyMachine machine, int money);
        
        public abstract void SelectDevice(CopyMachine machine, Device device);

        public abstract void SelectDocument(CopyMachine machine, string document);

        public abstract void PrintDocument(CopyMachine machine);
     
        public void ReturnChange(CopyMachine machine)
        {
            if (machine.Balance == 0)
                Console.WriteLine($"Your balance = {machine.Balance}");
            else
                Console.WriteLine($"Returned  {machine.Balance}");
            Console.WriteLine("Profit!");
            Console.WriteLine();
            machine.Reset();
        }
    }
}