using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace image_statistics
{
    internal class Class1
    {



        public double Maximum(double[] arr)
        {
            double maxElement = arr[0];
            for (int index = 1; index < arr.Length; index++)
            {
                if (arr[index] > maxElement)
                    maxElement = arr[index];
            }
            return maxElement;
        }



        public double Minimum(double[] arr)
        {
            double minElement = arr[0];
            for (int index = 1; index < arr.Length; index++)
            {
                if (arr[index] < minElement)
                    minElement = arr[index];
            }
            return minElement;
        }

        public double Avg(double[] arr)
        {
            double sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            float average = (float)sum / arr.Length;
           
            return average;
        }



        public double Variance(double[] arr)
        {

            if (arr.Length > 1)
            {

                // Get the average of the values

                double avg = Avg(arr);
                double sumOfSquares = 0.0;

                foreach (double num in arr)
                {

                    sumOfSquares += Math.Pow((num - avg), 2.0);

                }

                // Finally divide it by n - 1 (for standard deviation variance)

                // Or use length without subtracting one ( for population standard deviation variance)

                return sumOfSquares / (arr.Length - 1);

            }

            else { return 0.0; }

        }

      

        public double StandardDeviation(double variance)

        {

            return Math.Sqrt(variance);

        }




        public static void Main(string[] args)
        {
         
            double[] arr = {1,2,3,4,5,6,7,8 };


            //Image image = Image.FromFile(@"C:\Users\hassa\source\repos\image statistics\image statistics\gray2.png");
            Bitmap bmp = new Bitmap("D:\\gray2.png");
            Color[][] matrix;
            int height = bmp.Height;
            int width = bmp.Width;
            if (height > width)
            {
                matrix = new Color[bmp.Width][];
                for (int i = 0; i <= bmp.Width - 1; i++)
                {
                    matrix[i] = new Color[bmp.Height];
                    for (int j = 0; j < bmp.Height - 1; j++)
                    {
                        matrix[i][j] = bmp.GetPixel(i, j);
                    }
                }
                Console.WriteLine(matrix);
            }
            else
            {
                matrix = new Color[bmp.Height][];
                for (int i = 0; i < bmp.Height - 1; i++)
                {
                    matrix[i] = new Color[bmp.Width];
                    for (int j = 0; j < bmp.Width - 1; j++)
                    {
                        matrix[i][j] = bmp.GetPixel(i, j);
                    }
                }
                Console.WriteLine(matrix.ToString());
            }
            

            Class1 class1 = new Class1();

            Console.WriteLine(class1.Avg(arr));

            Console.WriteLine(class1.Minimum(arr));
            
            double variance = class1.Variance(arr);

            Console.WriteLine(class1.StandardDeviation(variance));

            Console.WriteLine(class1.Maximum(arr));
            Console.ReadLine();
        }
        
        
    }

  
}

   

