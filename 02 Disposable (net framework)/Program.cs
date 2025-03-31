using System;

namespace Demo__IDisposable
{
    class DBConnection
    {
        private string nameDb;
        private bool isOpen;
        bool isDisposed = false;
        public DBConnection()
        {
            Console.WriteLine("DbConnection ctor");
        }
        public void Open(string nameDb)
        {
            if (isOpen)
            {
                Console.WriteLine($"DB {nameDb} is opened now");
            }
            else
            {
                isOpen = true;
                this.nameDb = nameDb;
            }
        }
        public void Work()
        {
            Console.WriteLine("We got all records from table....");
        }
        public void Dispose() // 
        {
            if (!isDisposed)
            {
                isOpen = false;
                Console.WriteLine($"Disposed done. Is Opened {isOpen}");
                isDisposed = true;
            }
        }
        ~DBConnection()
        {
            Console.WriteLine("-----Finalizer---");
            Dispose();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            DBConnection db = new DBConnection();
            db.Open("aa.mdf");
            db.Work();

            GC.Collect(0);
            System.Threading.Thread.Sleep(3000);
        }
    }
}
