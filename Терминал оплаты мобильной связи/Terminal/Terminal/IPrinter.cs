namespace Terminal
{
    public interface IPrinter
    {
        PrinterState GetState();
        void Print(Transaction data);
    }
}