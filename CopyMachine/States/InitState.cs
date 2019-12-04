using System;

namespace CopyMachine.States
{
    public class InitState : StateBase
    {
        public override void AcceptMoney(CopyMachine machine, int money)
        {
            machine.Balance += money;
            Console.WriteLine($"Now your balance = {machine.Balance}");
            machine.State = new SelectDeviceState();
        }

        public override void SelectDevice(CopyMachine machine, Device device)
        {
            throw new Exception("Please, deposit money first");
        }

        public override void SelectDocument(CopyMachine machine, string document)
        {
            throw new Exception("Please, deposit money first");
        }

        public override void PrintDocument(CopyMachine machine)
        {
            throw new Exception("Please, deposit money first");
        }
    }
}