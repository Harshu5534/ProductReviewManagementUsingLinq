using System;
namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Welcome To Product Review Management-----------");
            //List for product review
            List<ProductReview> reviewList=new List<ProductReview>();
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

            //Display list
            foreach (var product in reviewList)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine(product.ProductID + " | " + product.UserID + " | " + product.Rating + " | " + product.Review + " | " + product.IsLike);
            }
        }
    }
}