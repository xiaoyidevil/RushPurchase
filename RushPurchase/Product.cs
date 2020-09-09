using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushPurchase
{
    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int sellOut { get; set; }
        /// <summary>
        /// 飞天茅台53%vol酱香型白酒 500ml(带杯）
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string clickUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string imageUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string startTime { get; set; }
        /// <summary>
        /// 茅台（MOUTAI）
        /// </summary>
        public string brandName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int storeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int price { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string traceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string priceString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int originalPrice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string originalPriceString { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int soldQty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int source { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int limitQty { get; set; }
        /// <summary>
        /// 百货大楼-抚顺百货大楼
        /// </summary>
        public string storeName { get; set; }
        /// <summary>
        /// 贵州飞天茅台
        /// </summary>
        public string promotion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int storeType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int international { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string @global { get; set; }
        /// <summary>
        /// 商场专柜
        /// </summary>
        public string storeTag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int counterId { get; set; }
        /// <summary>
        /// 百货大楼-抚顺百货大楼专柜
        /// </summary>
        public string counterTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string counterClickUrl { get; set; }
    }

    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string key { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem> data { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int httpCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Int64 timestamp { get; set; }
    }

}
