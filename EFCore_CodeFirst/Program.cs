// See https://aka.ms/new-console-template for more information

// Tạo thêm UserOrders => 1-n: 1 user có nhiều đơn hàng
// Tạo thêm Product => 1 table
// Tạo bảng UserOrderProduct (giống bảng product: quantity, note, discount) quan hệ 1-n với UserOrder 

using EFCore_CodeFirst;
using EFCore_CodeFirst.Enitity;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
string[] name = new string[] { "Phuc", "Thien", "Quy", "Tuan", "Huy", "TheAnh", "Thinh" };
string[] product = new string[] { "Cloth", "Car", "Toy", "Food", "Drink" };
for (int i = 0; i < 5000; i++)
{
    try
    {
        using CodeFirstDBContext context = new();

        Random random = new Random();
        int f = random.Next(100000, 100000000);
        string pass = f.ToString();
        string fName = name[random.Next(0, name.Length)];
        string email = fName + "@gmail.com";
        User user = new()
        {
            Name = fName,
            Email = email,
            Password = pass
        };

        // Define the range for the random date
        DateTime startDate = new DateTime(2022, 1, 1);
        DateTime endDate = new DateTime(2023, 12, 31);

        // Generate a random number of days between the start and end dates
        
        int range = (endDate - startDate).Days;
        int randomDays = random.Next(range);

        // Add the rando number of days to the start date
        DateTime randomDate = startDate.AddDays(randomDays);
        UserDetail userDetail = new()
        {
            Avatar = "",
            Age = random.Next(1, 100),
            Birthday = randomDate,
            UserId = i,

        };

        Product product1 = new()
        {
            Name = "Product " + i.ToString(),
            Price = random.Next(100000, 10000000).ToString()+" "+"VND",
            IsActive = true
        };
        //List<string>  orderDetails = new();
        //for (int j = 0; j < random.Next(1,i+1); j++)
        //{
        //    string ordils = string.Join(",", random.Next(1,j+1).ToString());
        //    orderDetails.Add(ordils);
        //}

        //UserOrder usersd = new()
        //{
        //    UserID = i,
        //    OrderDetails = orderDetails.ToString(),

        //};

        //UserOrderProduct userOrderProduct = new()
        //{
        //    Quantity = random.Next(1, 5),
        //    Note = "ko",
        //    Discount = random.Next(1, 10),
        //    UserOrderId = random.Next(1, i+2),
        //    ProductId = random.Next(1, i + 2),


        //};

        _ = context.Users.Add(user);
        //_ = context.UserOrders.Add(usersd);
        _ = context.Products.Add(product1);
        //_ = context.userOrderProducts.Add(userOrderProduct);
        _ = context.UserDetails.Add(userDetail);
        int value = context.SaveChanges();
        Console.WriteLine(value>1);
        Console.WriteLine("Inserted product! " + i);
        Console.WriteLine("Inserted Userdetails! " + i);
        Console.WriteLine("Inserted user! " + i);
        //Console.WriteLine("Inserted product! " + i);
        //Console.WriteLine("Inserted product! " + i);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}