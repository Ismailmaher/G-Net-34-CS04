using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Linq.Expressions;
using System.Text;

namespace G_Net_34_CS04
{
    internal class Program
    {
        static void Main(string[] args) { 
        #region G-Net-34-CS04 
        #region Question 1
        //(a) Explain why this code is inefficient.Reference what happens in memory.
        //answer (a)because the code creates a new string object every time it concatenates, which can lead to increased memory usage and slower performance due to the need to allocate new memory for each concatenation.
        //(b) Rewrite the code using StringBuilder to be more efficient.
        //answer (b)You can use a StringBuilder to efficiently concatenate strings without creating multiple string objects.
        //StringBuilder productList = new StringBuilder();
        //for (int i = 1; i <= 5000; i++)
        //{
        //    productList.Append("PROD-");
        //    productList.Append(i);
        //    productList.Append(",");
        //}
        //(c) Add timing code (using Stopwatch) to both versions and report
        // the time difference.
        //Stopwatch Sw1 = Stopwatch.StartNew();
        //string productList = "";

        //for(int i=1; i <= 5000; i++)
        //{
        //    productList += "PROD-" + i + ",";
        //}

        //Sw1.Stop();
        //Console.WriteLine("String Time: " + Sw1.ElapsedMilliseconds + " ms");
        //    Stopwatch Sw2 = Stopwatch.StartNew();
        //    StringBuilder sb = new StringBuilder();

        //    for (int i = 1; i <= 5000; i++)
        //    {
        //        sb.Append("PROD-");
        //        sb.Append(i);
        //        sb.Append(",");
        //    }

        //Sw2.Stop();
        //    Console.WriteLine("StringBuilder Time: " + Sw2.ElapsedMilliseconds + " ms");
        #endregion

        #region Question 2
        Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            double price = 0;
            if (age < 5)
                price = 0;
            else if (age <= 12)
                price = 30;
            else if (age <= 59)
                price = 50;
            else
                price = 25;
            Console.Write("Enter day number (0 Sunday to 6 Saturday): ");
            int day = int.Parse(Console.ReadLine());
            if (day == 5 || day == 6)
            {
                price += 10;
            }
            Console.Write("Student ID? (yes/no): ");
            string student = Console.ReadLine().ToLower();
            if (student == "yes")
            {
                price *= 0.8;
            }
            Console.WriteLine("Final price: " + price + " LE");

            #endregion

        #region Question 3
            //(a)A traditional switch statement
            //aswer(a)
            //string fileExtension = ".pdf";
            //string fileType;
            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;

            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;

            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;

            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;

            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}
            //Console.WriteLine(fileType);

            //}
            // (b)A switch expression
            //answer (b)
            //string fileExtension = ".pdf";
            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _ => "Unknown File Type"
            //};
            //Console.WriteLine(fileType);
            #endregion
        #endregion

        #region Question 4
            int tem = 35;
            String Weather = tem < 0 ? "Freezing! Stay indoors."
                           : tem < 25 ? "Cold. Wear a jacket."
                           : tem < 35 ? "Warm. Stay hydrated."
                           : "Hot! Avoid sun exposure.";
            Console.WriteLine(Weather);
        #endregion
        }
    }
}
