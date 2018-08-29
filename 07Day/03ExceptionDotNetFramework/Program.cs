using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExceptionDotNetFramework
{
    /// <summary>
    /// execution: Ctrl + F5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
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

                //Exception handling approaches:
                //1. we swallow the exception, we do not throw it

                //2. let's throw the exception one more
                //throw;

                //3. let's throw the exception received one more
                //throw ex;

                //4. let's throw own exception
                //throw new ApplicationException("Own exception");

                //5. let's throw own exception, but we pack it into the exception as innerexception.

                // We rethrow the exception as innerexception for information.
                throw new ApplicationException("Main own exception", ex);

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

                //throw;

                // We rethrow the exception as innerexception for information.
                throw new ApplicationException("SubProgramOne own exception", ex);

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
                throw new Exception("EUR should be transferred from this account, but the invoice contains HUF !");
                Console.WriteLine("SubProgramTwo try ends.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SubProgramTwo catch starts");
                Console.WriteLine($"SubProgramTwo: {ex.ToString()}");

                //throw;

                // We rethrow the exception as innerexception for information.
                throw new ApplicationException("SubProgramTwo own exception", ex);

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
