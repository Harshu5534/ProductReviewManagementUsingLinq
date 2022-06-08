using System;
using System.Collections.Generic;
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
        public void Display(List<ProductReview> list)
        {
            //Display list
            foreach (var product in list)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(product.ProductID + " | " + product.UserID + " | " + product.Rating + " | " + product.Review + " | " + product.IsLike);
            }
        }
    }
}
