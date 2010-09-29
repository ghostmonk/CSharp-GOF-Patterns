namespace Command.Core
{
    interface Receiver
    {
        void Connect();
        void Diagnostics();
        void Reboot();
        void Shutdown();
        void Disconnect();
    }
}
