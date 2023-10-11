using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesCalculator
{
    // 売上集計クラス
    internal class SalesCounter
    {
        // フィールド
        private IEnumerable<Sale> _sales;


        // コンストラクタ(修正前)
        //public SalesCounter(List<Sale> sales)
        //{
        //    _sales = sales;
        //}
        // コンストラクタ(修正後)
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }


        // 売上データを読み込み、Saleオブジェクトのリストを返す
        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();    // 空のリストを作成
            var lines = File.ReadAllLines(filePath);   // ファイルの中身を一気に読み込み、配列linesとして保持
            foreach (var line in lines)
            {
                var items = line.Split(',');
                var sale = new Sale    // ここでCSVファイルの中身を各プロパティにセットしている(オブジェクト初期化子を利用)
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);    // saleをリストsalesへ追加する。この次は次の1行を同じ処理をしていく。
            }
            return sales;
        }


        // 店舗別売上を求めるメソッド
        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)   // Saleオブジェクトを1行ずつ受け取って処理したいので、"Sale sales in _sales"
            {
                if (dict.ContainsKey(sale.ShopName))    // Dictionaryのキーとして、指定した(回ってきたSaleの1行に)店舗名が含まれていれば
                {
                    dict[sale.ShopName] += sale.Amount;     // 同じ店舗として売上を加算する
                } 
                else
                {
                    dict[sale.ShopName] = sale.Amount;      // 違う店舗なので、売上は加算せずそのまま
                }
            }
            return dict;
        }

    }
}
