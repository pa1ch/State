using System;

namespace CopyMachine.States
{
    public class SelectDeviceState : StateBase
    {
        public override void AcceptMoney(CopyMachine machine, int money)
        {
            throw new Exception($"Just select device, dude");
        }

        public override void SelectDevice(CopyMachine machine, Device device)
        {
            machine.SelectedDevice = device;
            Console.WriteLine($"You select {machine.SelectedDevice}");
            machine.State = new SelectDocumentState();
        }

        public override void SelectDocument(CopyMachine machine, string document)
        {
            throw new Exception($"Just select device, dude");
        }

        public override void PrintDocument(CopyMachine machine)
        {
            throw new Exception($"Just select device, dude");
        }
    }
}