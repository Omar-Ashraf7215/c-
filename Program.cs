namespace days
{
    internal class Program
    {
        //public static void print(string statment)
        //{
        //    Console.WriteLine($"hello{statment}");
        //}
        static void Main(string[] args)
        {
            #region exception handling

            //try
            //{
            //    //int x = int.Parse(Console.ReadLine());
            //    //int y = int.Parse(Console.ReadLine());
            //    //float z = x / y;
            //    //Console.WriteLine($"result ={z}");
            //    checked
            //    {
            //        int s1 = int.MaxValue;
            //        int s2 = int.MinValue;
            //        Console.WriteLine(s1);
            //        Console.WriteLine(s2);
            //        s1 += s1;
            //        Console.WriteLine(s1);
            //    }
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"please enter valid number not zero value");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine($"OverflowException");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error , Unkown Error {ex}");
            //}
            //finally
            //{
            //    Console.WriteLine("hello");
            //}
            #endregion
            #region Casting
            //Conversion -Compatable -NonCompatable
            //-implict -explict
            //Conversion - Compatable -implict
            //byte x = 200;
            //int y = x;
            //Console.WriteLine(y);

            ////Conversion -Compatable -explict

            //checked
            //{
            //   int z = 300;
            //   byte s =(byte)z;
            //   Console.WriteLine(s); 
            //}

            //try
            //{
            //    string str ="1234";
            //    int x = Convert.ToInt32(str);
            //    Console.WriteLine(x);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Please Enter Valid Value , Number only");
            //}
            //try
            //{
            //    string str = null;
            //    int x = int.Parse(str);
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Please Enter Valid Value , nut null");
            //}
            //int z;
            //bool result =int.TryParse("123k",out z);
            //if (result == true)
            //{
            //    Console.WriteLine("valid");
            //    Console.WriteLine($"value {z}");
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}




            #endregion
            #region Array
            //ID array
            //Defin
            //float[] degreeOfStudent = new float[3] {2,2,2};
            ////syntac suger
            //float[] degreeOfStudent1 = {2,2,2};
            //set of array
            //degreeOfStudent1[0] = 7;
            //degreeOfStudent1[1] = 10;
            //degreeOfStudent1[2] = 11;
            //get from array
            //Console.WriteLine($"Degree 1:{degreeOfStudent1[0]}");
            //Console.WriteLine($"Degree 2:{degreeOfStudent1[1]}");
            //Console.WriteLine($"Degree 3:{degreeOfStudent1[2]}");
            //for (int i = 0; i < degreeOfStudent1.Length; i++)
            //{
            //    Console.WriteLine($"Please Enter degree{i+1}");
            //    degreeOfStudent1 [i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0;i < degreeOfStudent1.Length; i++)
            //{
            //    Console.WriteLine($"degree {i + 1}:{degreeOfStudent1[i]}");
            //}
            //2D array
            //Defin
            //int[,] ints = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{ 
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine($"Please Enter degree{i + 1},{j+1}");
            //        ints[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < 3; i++) 
            //{
            //    for(int j = 0;j < 3; j++)
            //    {
            //        Console.WriteLine($"degree {i + 1},{j + 1}:{ints[i,j]}");
            //    }
            //}

            #endregion
            
            //print("Omar");
        }
    }
}
