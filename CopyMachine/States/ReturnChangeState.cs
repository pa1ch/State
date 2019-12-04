using System;

namespace CopyMachine.States
{
    public class ReturnChangeState : StateBase
    {
        public override void AcceptMoney(CopyMachine machine, int money)
        {
            throw new Exception("You can print another document or return the remaining money");
        }

        public override void SelectDevice(CopyMachine machine, Device device)
        {
            throw new Exception("You can print another document or return the remaining money");
        }

        public override void SelectDocument(CopyMachine machine, string document)
        {
            machine.State = new SelectDocumentState();
            machine.SelectDocument(document);
        }

        public override void PrintDocument(CopyMachine machine)
        {
            throw new Exception("You can print another document or return the remaining money");
        }
    }
}