﻿using System;
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
    }
}
