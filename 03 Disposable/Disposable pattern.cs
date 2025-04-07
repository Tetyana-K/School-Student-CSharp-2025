using System;
using ST = System.Threading; // синонім назви простору
using static System.Console; // відкрили до методів та вл-тей System.Console
using System.IO;

namespace Demo__IDisposable
{
    // керований ресурс -  ним керує CLR (масиви, рядки, те що, створюється у дин памяті, тобто на HEAP)
    // некерований ресурс(зєднання з  БД, файлові дескриптори, зєднання по  мережі, графічні ресурси) - за звільнення таких ресурсів CLR не відповідає, потрібно самим закривати 
    // Клас, який оперує сирим некерованим ресурсом повинен реалізувати IDisposable, тобто метод Dispose(), який закриэ некеровані ресурси, якими користується клас  
    class DBConnection : IDisposable
    {
        private string nameDb;
        private bool isOpen; // наша імітація некерованого ресурсу
        bool isDisposed = false; // прапорець для перевірки чи звільнівся ресурс
        FileStream fs = new FileStream("my.dat", FileMode.OpenOrCreate); //  стандарний клас- обгортка над некерованим ресурсом 
        public DBConnection()
        {
            /*Console.*/
            WriteLine("DbConnection ctor");
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
            Dispose(true); // треба звільняти керовані ресурси (ті що мають метод Dispose)
            GC.SuppressFinalize(this); // подавили(заборонили) виклик фіналізатора(бо  вже звільнили ресурс - connection with DB)

        }
        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing) // true
                {
                    Console.WriteLine("We  are releasing managed resource(which has Dispose) ");
                    fs.Dispose();
                }

                //free unmanaged resource
                isOpen = false;
                Console.WriteLine($"Disposed done. Is Opened {isOpen}");
                isDisposed = true;

            }
        }
        ~DBConnection()
        {
            Console.WriteLine("-----Finalizer---");
            Dispose(false); // звільеяти тільки  некеровані(сирі)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //using (DBConnection db = new DBConnection())
                DBConnection db = new DBConnection();
                {
                    db.Open("aa.mdf");
                    db.Work();
                    throw new Exception("DB Error");
                    //                    db.Dispose();

                } // неявно  у кінці блоку  db.Dispose()

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
