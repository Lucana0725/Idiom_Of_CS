using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator
{
    // 売上集計クラス
    internal class SalesCounter
    {
        // フィールド
        private List<Sale> _sales;

        // コンストラクタ
        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }

        // 店舗別売上を求めるメソッド
        public Dictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales)   // Saleオブジェクトを1行ずつ受け取って処理したいので、"Sale sales in _sales"
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
