using System;

namespace _02Exceptions
{
    /// <summary>
    /// execution: Ctrl + F5
    /// </summary>
    class Program
    {
        private static void CurrentDomain_FirstChanceException(object sender, System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs e)
        {
            Console.WriteLine("--- FirstChanceException ---");
            Console.WriteLine(e.Exception);
            Console.WriteLine("--- FirstChanceException ---");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"--- UnhandledException --- IsTerminating: {e.IsTerminating}");
            Console.WriteLine(((Exception)e.ExceptionObject).ToString());
            Console.WriteLine("--- UnhandledException ---");
        }

        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.FirstChanceException += CurrentDomain_FirstChanceException;

            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            try
            {
                Console.WriteLine("Main try starts");
                SubProgramOne();
                Console.WriteLine("Main try ends.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Main catch starts");
                Console.WriteLine($"Main : {ex.ToString()}");
                throw;
                Console.WriteLine("Main catch ends.");
            }
            finally
            {
                Console.WriteLine("Main finally starts");
                Console.WriteLine("Main finally ends.");
            }
        }

        private static void SubProgramOne()
        {
            try
            {
                Console.WriteLine("SubProgramOne try starts");
                SubProgramTwo();
                Console.WriteLine("SubProgramOne try ends.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SubProgramOne catch starts");
                Console.WriteLine($"SubProgramOne: {ex.ToString()}");
                throw;
                Console.WriteLine("SubProgramOne catch ends.");
            }
            finally
            {
                Console.WriteLine("SubProgramOne finally starts");
                Console.WriteLine("SubProgramOne finally ends.");
            }
        }

        private static void SubProgramTwo()
        {
            try
            {
                Console.WriteLine("SubProgramTwo try starts");
                throw new ConfuseCurrencyException("EUR should be transferred from this account, but the invoice contains HUF !");
                Console.WriteLine("SubProgramTwo try ends.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SubProgramTwo catch starts");
                Console.WriteLine($"SubProgramTwo: {ex.ToString()}");
                throw;
                Console.WriteLine("SubProgramTwo catch ends.");
            }
            finally
            {
                Console.WriteLine("SubProgramTwo finally starts");
                Console.WriteLine("SubProgramTwo finally ends.");
            }
        }
    }
}
