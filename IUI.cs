namespace Garage
{
    interface IUI
    {
        string AskForStrInput(string prompt);
        int AskForIntInput(string prompt);
        void PrintString(string message);
    }
}