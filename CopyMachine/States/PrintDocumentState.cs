using System;

namespace CopyMachine.States
{
    public class PrintDocumentState : StateBase
    {
        public override void AcceptMoney(CopyMachine machine, int money)
        {
            throw new Exception($"Just press the PRINT button");
        }

        public override void SelectDevice(CopyMachine machine, Device device)
        {
            throw new Exception($"Just press the PRINT button");
        }

        public override void SelectDocument(CopyMachine machine, string document)
        {
            throw new Exception($"Just press the PRINT button");
        }

        public override void PrintDocument(CopyMachine machine)
        {
            machine.Balance -= CopyMachine.PrintPrice;
            Console.WriteLine($"Printing {machine.SelectedDocument}...");
            machine.State = new ReturnChangeState();
        }
    }
}