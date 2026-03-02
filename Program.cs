using System.Diagnostics;
using System.Text;
using System;

namespace G_Net_34_CS04
{
    internal class Program
    {
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
      
        #endregion
    }
}
