using System;
namespace csPratice
{
    partial class DataTableTest
    {
        public DataTableTest()
        {
            Console.WriteLine("***DataTableClass init***");
            System.Data.DataTable dt = new System.Data.DataTable();


            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("4");
            dt.Columns.Add("5");

            System.Data.DataRow row = dt.NewRow();
            row["1"] = "1";
            row["2"] = "2";
            row["3"] = "3";
            row["4"] = "4";
            row["5"] = "5";
            dt.Rows.Add(row);

            for(int i = 0; i<dt.Columns.Count; i++){
                Console.Write(dt.Rows[0].ItemArray[i] + "\t");    
            }
            Console.WriteLine();
            Console.WriteLine("***DataTableClass exit***");
            
        }

        
    }
}
 