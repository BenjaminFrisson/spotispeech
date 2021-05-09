module Demo
{
    sequence<string> strTab;
    sequence<byte> byteTab;

    interface Printer
    {
        strTab GetNames();
        strTab GetNamesByParam(string s);
        void ClosedWindow();
        void ChangeTrack(string track);
        bool UploadFile(string name, string file);

    }
}