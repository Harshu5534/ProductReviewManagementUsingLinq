using System;
namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Welcome To Product Review Management-----------");
            //List for product review
            List<ProductReview> reviewList = new List<ProductReview>();
            reviewList.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 2, UserID = 1, Rating = 7, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 3, UserID = 1, Rating = 4, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 4, UserID = 1, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 5, UserID = 1, Rating = 6, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 6, UserID = 1, Rating = 2, Review = "Very Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 7, UserID = 1, Rating = 1, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 8, UserID = 1, Rating = 10, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 9, UserID = 1, Rating = 9, Review = "Very Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 10, UserID = 1, Rating = 10, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 11, UserID = 1, Rating = 8, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 12, UserID = 1, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 13, UserID = 1, Rating = 7, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 14, UserID = 1, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 15, UserID = 1, Rating = 6, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 16, UserID = 1, Rating = 2, Review = "Very Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 17, UserID = 1, Rating = 1, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 18, UserID = 1, Rating = 10, Review = "Good", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 19, UserID = 1, Rating = 9, Review = "Very Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 20, UserID = 1, Rating = 10, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 21, UserID = 1, Rating = 8, Review = "Nice", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 22, UserID = 1, Rating = 5, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 23, UserID = 1, Rating = 7, Review = "Bad", IsLike = false });
            reviewList.Add(new ProductReview() { ProductID = 24, UserID = 1, Rating = 3, Review = "Good", IsLike = true });
            reviewList.Add(new ProductReview() { ProductID = 25, UserID = 1, Rating = 6, Review = "Good", IsLike = false });
            
            bool end = true;
            while (end)
            {
                Console.WriteLine("\nSelect Option\n1.CreateProductReview\n2.Retrive Top 3 Review\n3.Retrive Top 3 Record With Product Id\n4.Get Top Records Count With ProductId\n5.Skip Top 5 Records" +
                    "\n6.Get All Records\n7.Create Data Table\n8.Find average rating\n9.End Of Program");
                Console.WriteLine("\nEnter Option For Exicute The Program");
                int option = Convert.ToInt16(Console.ReadLine());
                Operations operations = new Operations();
                switch (option)
                {
                    case 1:
                        operations.Display(reviewList);
                        break;
                    case 2:
                        operations.GetTop3Records(reviewList);
                        break;
                    case 3:
                        operations.GetTopRecordsWithProductId(reviewList);
                        break;
                    case 4:
                        operations.GetTopRecordsCountWithProductId(reviewList);
                        break;
                    case 5:
                        operations.SkipTop5Records(reviewList);
                        break;
                    case 6:
                        operations.GetAllRecords(reviewList);
                        break;
                    case 7:
                        operations.Datatables();
                        break;
                    case 8:
                        operations.AvgRating(reviewList);
                        break;
                    case 9:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("\n--------------Please Enter the Correct option--------------\n");
                        break;
                }
            }
        }
    }
}