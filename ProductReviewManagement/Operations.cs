using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Operations
    {
        public void GetTop3Records(List<ProductReview> list)
        {
            var result = list.OrderByDescending(x=>x.Rating).Take(3).ToList();
            Display(result);
        }
        public void GetTopRecordsWithProductId(List<ProductReview> list)
        {
            var result=list.Where(x => x.Rating > 3 && (x.ProductID == 1 || x.ProductID == 4 || x.ProductID == 9)).Take(3).ToList();
            Display(result);
        }
        public void GetTopRecordsCountWithProductId(List<ProductReview> list)
        {
            var result = list.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            foreach(var data in result)
            {
                Console.WriteLine(data.ProductID + " " +data.Count);
            }
        }
        public void SkipTop5Records(List<ProductReview> list)
        {
            var result = list.OrderByDescending(x => x.Rating).Skip(5).ToList();
            Display(result);
        }
        public void GetAllRecords(List<ProductReview> list)
        {
            var result = list.OrderBy(x => x.ProductID).Select(x => new { productId = x.ProductID, Review = x.Review });
        }
        public void Display(List<ProductReview> list)
        {
            //Display list
            foreach (var product in list)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(product.ProductID + " | " + product.UserID + " | " + product.Rating + " | " + product.Review + " | " + product.IsLike);
            }
        }
        public void Datatables()
        {
            //created datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Review");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Islike");
            //created row
            dt.Rows.Add("1", "2", "Good", "4", "True");
            dt.Rows.Add("2", "2", "Bad", "5", "False");
            dt.Rows.Add("3", "1", "Very Good", "5", "False");
            dt.Rows.Add("4", "2", "Good", "4", "True");
            dt.Rows.Add("5", "2", "Bad", "5", "False");
            dt.Rows.Add("6", "1", "Very Good", "5", "False");
            dt.Rows.Add("7", "2", "Good", "4", "True");
            dt.Rows.Add("8", "2", "Bad", "5", "False");
            dt.Rows.Add("9", "1", "Very Good", "5", "False");
            dt.Rows.Add("10", "2", "Good", "4", "True");
            dt.Rows.Add("11", "2", "Bad", "5", "False");
            dt.Rows.Add("12", "1", "Very Good", "5", "False");
            dt.Rows.Add("13", "2", "Good", "4", "True");
            dt.Rows.Add("14", "2", "Bad", "5", "False");
            dt.Rows.Add("15", "1", "Very Good", "5", "False");
            dt.Rows.Add("16", "2", "Good", "4", "True");
            dt.Rows.Add("17", "2", "Bad", "5", "False");
            dt.Rows.Add("18", "1", "Very Good", "5", "False");
            dt.Rows.Add("19", "2", "Good", "4", "True");
            dt.Rows.Add("20", "2", "Bad", "5", "False");
            dt.Rows.Add("21", "1", "Very Good", "5", "False");
            dt.Rows.Add("22", "2", "Good", "4", "True");
            dt.Rows.Add("23", "2", "Bad", "5", "False");
            dt.Rows.Add("24", "2", "Bad", "5", "False");
            dt.Rows.Add("25", "1", "Very Good", "5", "False");
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }
            IEnumerable<DataRow> rows = dt.AsEnumerable().Where(r => r.Field<string>("Islike") == "True");
            Console.WriteLine("\n-----------Data from datatable who's islike value is true------------");
            
            foreach (DataRow row in rows)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }
        }
        public void AvgRating(List<ProductReview> list)
        {
            var result = list.GroupBy(info => info.ProductID).Select(group => new { products = group.Key, Count = group.Average(a => a.Rating) });
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:{0} => Average Rating :{1}", data.products, data.Count);
            }
        }
    }
}
