using System;
using System.Data;

namespace WinDataRelation
{
    class Program
    {
        static void Main(string[] args)
        {
            Data.CustomerdetailDataTable ctc = new Data.CustomerdetailDataTable();
            Data.CustomerdetailRow dr = ctc.NewCustomerdetailRow();
            dr["customerName"] = "Dhanshree";
            ctc.Rows.Add(dr);
            foreach (DataRow r in ctc.Rows)
                Console.WriteLine("customerID = {0} , customerName = {1}", r["customerID"], r["customerName"]);
            Console.ReadLine();
        }        
    }
}
