using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exception
             * throw new NotImplementedException();
             *try - catch
             * finally
             * -NullReferenceException
             * -DiviedByZeroException
             * -IndexOutOfRangeException
             * -InvalidCastException
             * -NotImplementedException
             * Fange spesifikk
             * Fange alle
             * Call stack
             * Egne Exceptions
             */
             //ExceptionDemo2();
             DemoInvalidCastException();
             ExceptionDemoFinally(5, 0);
             ExceptionDemoFinally(5, 1);
             try
             {
                ExceptionDemo2();
             }
             catch (TerjeException e)
             {
                 Console.WriteLine("TerjeException!");
             }


            try
            {
                ExceptionDemo1();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Prøvde å dele med 0"+ e.Message);
                //throw; --> betyr kast videre
            }

        }

        private static void DemoInvalidCastException()
        {
            object value = 12;
            string s = (string) value;


        }


        private static int ExceptionDemoFinally(int n, int d)
        {
            try
            {
                return n / d;
            }
            catch (DivideByZeroException e)
            {
                return -1;
            }
            finally
            {
                Console.WriteLine($"Dette gjæres uansett ! (n={n}, d={d})");
            }

        }

        private static void ExceptionDemo2()
        {
            throw new TerjeException();
        }

        private static void ExceptionDemo1()
        {


                DivideByZero();

                //IndexOutOfRangeException
            int[] a = new int[10];
            a[20] = 1;

            //NullReferenceException:
            string s = null;
            Console.WriteLine(s.Length);
        }

        private static void DivideByZero()
        {
            //DivideByZeroException
            var i = 0;
            var number = 17 / i;
        }
    }
}
