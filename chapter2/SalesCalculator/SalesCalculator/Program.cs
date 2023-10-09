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
        }

        // 売上データを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();    // 空のリストを作成
            string[] lines = File.ReadAllLines(filePath);   // ファイルの中身を一気に読み込み、配列linesとして保持
            foreach(string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale    // ここでCSVファイルの中身を各プロパティにセットしている(オブジェクト初期化子を利用)
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);    // saleをリストsalesへ追加する。この次は次の1行を同じ処理をしていく。
            }
            return sales;
        }
    }
}
