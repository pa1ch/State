using System;
using CopyMachine.States;

namespace CopyMachine
{
    public class CopyMachine
    {
        private int balance;
        
        public int Balance
        {
            get => balance;
            set
            {
                if (value < 0) 
                    throw new ArgumentException();
                balance = value;
            }
        }
        
        public Device SelectedDevice { get; set; }
        public string SelectedDocument { get; set; }
        public const int PrintPrice = 5;

        public IState State { get; set; }

        public CopyMachine()
        {
            State = new InitState();
        }

        public void AcceptMoney(int money)
        {
            State.AcceptMoney(this, money);
        }

        public void SelectDevice(Device device)
        {
            State.SelectDevice(this, device);
        }

        public void SelectDocument(string document)
        {
            State.SelectDocument(this, document);
        }

        public void PrintDocument()
        {
            State.PrintDocument(this);
        }
     
        public void ReturnChange()
        {
            State.ReturnChange(this);
        }

        public void Reset()
        {
            State = new InitState();
            Balance = 0;
            SelectedDocument = null;
        }
    }
}