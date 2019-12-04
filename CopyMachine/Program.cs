using System;

namespace CopyMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //normal use case
            var copyMachine1 = new CopyMachine();
            copyMachine1.AcceptMoney(100);
            copyMachine1.SelectDevice(Device.Usb);
            copyMachine1.SelectDocument("MyResume.pdf");
            copyMachine1.PrintDocument();
            copyMachine1.SelectDocument("MyResume(2).pdf");
            copyMachine1.PrintDocument();
            copyMachine1.ReturnChange();
            
            //can return money in any state
            var copyMachine2 = new CopyMachine();
            Console.WriteLine(copyMachine2.Balance);
            copyMachine2.AcceptMoney(50);
            Console.WriteLine(copyMachine2.Balance);
            copyMachine2.ReturnChange();
            Console.WriteLine(copyMachine2.Balance);
            
            //"stupid user" use case
            var copyMachine3 = new CopyMachine();
            try
            {
                copyMachine3.SelectDocument("MyResume.pdf");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"machine 3: {ex.Message}");
            }
            copyMachine3.AcceptMoney(100);
            try
            { 
                copyMachine3.PrintDocument();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"machine 3: {ex.Message}");
            }
            copyMachine3.SelectDevice(Device.Usb);
            copyMachine3.SelectDocument("MyResume.pdf");
            copyMachine3.PrintDocument();
            copyMachine3.ReturnChange();
        }
    }
}