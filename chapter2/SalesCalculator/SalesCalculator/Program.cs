using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * SalesCounter sales = new SalesCounter(ReadSales("sales.csv")); に関して
             * SalesCounterインスタンスを生成するときにsales.csvを渡したReadSales()を渡し、ReadSales()がsales.csvを読み込んでSaleオブジェクトのリストを作り、
             * SaleオブジェクトのリストがSalesCounterのコンストラクタに入りフィールド変数_saleとして格納される。そしてそれらの結果がsalesとしてここで保持される という流れ。
             */
            //SalesCounter sales = new SalesCounter(SalesCounter.ReadSales("sales.csv"));
            SalesCounter sales = new SalesCounter("sales.csv");

            IDictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<string, int> obj in amountPerStore)
            {
                Console.WriteLine($"{obj.Key}：{obj.Value}円");
            }
        }

    }
}
