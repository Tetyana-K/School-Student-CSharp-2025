using System;

namespace Demo__IDisposable
{
    // managed resources - managed by CLR (part of .NET)
    // unmanaged resource - некеровані ресурси (зєднання з базами даних, графічні ресурси, файлові дескриптори)
    class DBConnection : IDisposable
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
            //throw new Exception ("Smth happened");
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

            //DBConnection db = new DBConnection();
            //db.Open("aa.mdf");
            //db.Work();

            //db.Dispose();

            using (DBConnection db = new DBConnection())
            {
                db.Open("aa.mdf");
                db.Work();

                //db.Dispose(); --- неявно спрацює при закритті блоку
            }

            GC.Collect(0);
            System.Threading.Thread.Sleep(3000);

        }
    }
}
