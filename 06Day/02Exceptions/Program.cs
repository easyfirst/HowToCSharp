using System;
using System.Runtime.CompilerServices;

namespace _02Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // here is the execution
                Console.WriteLine("Main try starts");

                //If you want to indicate in the program that the application is not prepared for a particular situation,
                //then we'll "drop an exception."

                //the application throw exception if the 'situation = Situations.One'.
                //var situation = Situations.One;

                //the application runs without exception if the 'situation = Situations.Null'.
                var situation = Situations.Null;

                switch (situation)
                {
                    case Situations.One:
                        Console.WriteLine($"It is OK: {situation}");
                        break;
                    case Situations.Two:
                        Console.WriteLine($"It is OK: {situation}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"something bad: { situation}");
                        break;  // this will never get to run.
                }

                Console.WriteLine("Main try ends");
            }
            catch (ArgumentException ex)
            {   // This branch only receives the exceptions that are filed from the filter type.
                Console.WriteLine("Main ArgumentException catch starts");

                Console.WriteLine(ex.ToString());

                Console.WriteLine("Main ArgumentException catch ends");
            }
            catch (OutOfMemoryException) { }        //This can be written because there is no common set compared to the previous one.
            catch (InvalidOperationException) { }   //This can be written because there is no common set compared to the previous one.
            catch (SystemException) { }             //I can filter on an ever-expanding set
            //catch {} for .NETs before 2.0, this kind of filtering needed to capture bugs outside the framework

            catch (RuntimeWrappedException) { } //https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.runtimewrappedexception.wrappedexception?redirectedfrom=MSDN&view=netframework-4.7.2#System_Runtime_CompilerServices_RuntimeWrappedException_WrappedException
            //in dotnet 2.0 already exists, this filters out errors outside the framework

            catch (Exception ex)
            {   // this branch gets control when it is
                // 1. an unmanaged exception in the try branch
                // AND
                // 2. the created filter condition is true for the created exception

                Console.WriteLine("Main Exception catch starts");

                Console.WriteLine(ex.ToString());

                Console.WriteLine("Main Exception catch ends");
                //throw;
            }
            finally
            {   // Whatever happens before it, the code here is definitely going to happen
                Console.WriteLine("Main finally starts");

                Console.WriteLine("Main finally ends");
            }


            Console.ReadLine();
        }
    }
}
