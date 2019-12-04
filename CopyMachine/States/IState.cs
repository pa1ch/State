namespace CopyMachine.States
{
    public interface IState
    {
        void AcceptMoney(CopyMachine machine, int money);
        void SelectDevice(CopyMachine machine, Device device);
        void SelectDocument(CopyMachine machine, string document);
        void PrintDocument(CopyMachine machine);
        void ReturnChange(CopyMachine machine);
    }
}