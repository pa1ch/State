using System;
using System.Diagnostics.CodeAnalysis;

namespace CopyMachine.States
{
    public class SelectDocumentState : StateBase
    {
        public override void AcceptMoney(CopyMachine machine, int money)
        {
            throw new Exception($"Just select document, man");
        }

        public override void SelectDevice(CopyMachine machine, Device device)
        {
            throw new Exception($"Just select document, man");
        }

        public override void SelectDocument(CopyMachine machine, [NotNull] string document)
        {
            machine.SelectedDocument = document ?? throw new ArgumentException("Document name can't be null");
            Console.WriteLine($"You select document: \"{machine.SelectedDocument}\"");
            machine.State = new PrintDocumentState();
        }

        public override void PrintDocument(CopyMachine machine)
        {
            throw new Exception($"Just select document, man");
        }
    }
}