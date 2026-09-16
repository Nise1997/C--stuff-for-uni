namespace  pz1
{
    class pz1
    {
        class Task2
        {
            public static int[] arrayer()
            {
                int[] arr = new int[10];
                Random rnd = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(1, 101);
                }
                return arr;
            }

            public static void printarry(int[] arr)
            {
                Console.WriteLine(" - array - ");
                foreach (int el in arr)
                {
                    Console.WriteLine(el);
                }
            }
        }

        class Task3
        {
            private static double sumaary(int[] arr)
            {
                double suma = 0;
                foreach (int el in arr)
                {
                    suma += el;
                }
                return suma;
            }
            public static double arrayavg(int[] arr)
            {
                sumaary(arr);
                return sumaary(arr) /  arr.Length;
            }

            public static void MaxMinANDprint(int[] arr)
            {
                int max = arr[0];
                int min = arr.Min();
                foreach (int el in arr)
                {
                    if (el > max)
                    {
                        max = el;
                    }
                }
                Console.WriteLine("max - " + max + " min - " + min);
            }

            public static void met1(ref int a) // і не нізя стандартне занчення ставить , хоча якшо убрать аут чи рф
            {
                a += 1;
            }

            public static void met2(out int a)
            { // аут можна використовувать для присвоєння значення з других функцій типу тарй парс і тд
                a = 34;  
            }
        }
        
    }
    
};


