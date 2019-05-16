using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_rturkTeknoloji.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var categories = new List<Category>()
            {
                new Category(){Name = "Camera",Description="Camera Products"},
                new Category(){Name = "Computer",Description="Computer Products"},
                new Category(){Name = "Phone",Description="Telefon Products"},
                new Category(){Name = "Elektronic",Description="Electronic Products"}

            };

            foreach (var category in categories)
            {
                context.Categories.Add(category);
            }
            context.SaveChanges();

            var products = new List<Product>()
            {
                new Product(){Name="Nikon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=true,IsApproved=false,CategoryId=1,Image="1.jpg" },
                new Product(){Name="Canon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=false,IsApproved=false,CategoryId=2 ,Image="2.jpg"},
                new Product(){Name="Nikon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=true,IsApproved=false,CategoryId=2,Image="3.jpg" },
                new Product(){Name="ACS 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=true,IsApproved=true,CategoryId=1 ,Image="4.jpg"},
                new Product(){Name="SGS 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=true,IsApproved=true,CategoryId=1 ,Image="5.jpg"},
                new Product(){Name="Nikon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=true,IsApproved=true,CategoryId=3 ,Image="1.jpg"},
                new Product(){Name="SDD 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=true,IsApproved=false,CategoryId=4,Image="2.jpg" },
                new Product(){Name="Nikon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=false,IsApproved=true ,CategoryId=4,Image="3.jpg"},
                new Product(){Name="Nikon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell d",Price=1200,Stock=25,IsHome=true,IsApproved=false,CategoryId=1 ,Image="4.jpg"},
                new Product(){Name="Nikon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzel",Price=1200,Stock=25,IsHome=true,IsApproved=true,CategoryId=1,Image="2.jpg" },
                new Product(){Name="Nikon 4710",Description="DAHmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzell Hmet Megheerere beraere fgelirr guze l guzel",Price=1200,Stock=25,IsHome=true,IsApproved=true,CategoryId=1 ,Image="1.jpg"},
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
