using System;

internal class Program
{
    private static void Main(string[] args)
    {
       Products product1 = new Products();
        product1.ProductName = "Bilgisayar";
        product1.ProductDescription = "Yeni Nesil Bilgisayarlar";
        product1.ProductCategory = "Apple";
        product1.ProductPrice = 55000;
        product1.ProductDiscount = 10;
        product1.ProductStock = 3;

        Products product2 = new Products();
        product2.ProductName = "Cep Telefonu";
        product2.ProductDescription = "Yeni Nesil Telefonlar";
        product2.ProductCategory = "Samsung";
        product2.ProductPrice = 32000;
        product2.ProductDiscount = 7;
        product2.ProductStock = 12;

        Products product3 = new Products();
        product3.ProductName = "Kahve Makinası";
        product3.ProductDescription = "Tam Otomatik Kahve Makinası";
        product3.ProductCategory = "Philips";
        product3.ProductPrice = 28000;
        product3.ProductDiscount = 2;
        product3.ProductStock = 24;

        Products product4 = new Products();
        product4.ProductName = "Kurutma Makinası";
        product4.ProductDescription = "Çok Programlı";
        product4.ProductCategory = "Arçelik";
        product4.ProductPrice = 12000;
        product4.ProductDiscount = 4;
        product4.ProductStock = 48;



        Products[] products = new Products[] { product1, product2, product3, product4 };

        Console.WriteLine("------WİTH FOREACH------");
        foreach (var product in products)
        {
            Console.WriteLine("Ürün İsmi : " + "" + product.ProductName + " / Ürün Kategorisi : " + "" + product.ProductCategory + " / Ürün Fiyatı : " +""+product.ProductPrice);
        }

        Console.WriteLine("------WİTH FOR------");

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine("Ürün İsmi : " + products[i].ProductName + " /Ürün Fiyatı : " + products[i].ProductPrice + " /Kalan Stok : " + products[i].ProductStock);
        }

        Console.WriteLine("------WİTH WHİLE------");

        int k = 0;
        while (k<products.Length)
        {
            Console.WriteLine("Ürün İsmi : " + products[k].ProductName + " /Ürün Fiyatı : " + products[k].ProductPrice + " /Kalan Stok : " + products[k].ProductStock + " /İNDİRİM : " +products[k].ProductDiscount);
            k++;
        }
    }
}

class Products
{
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public string ProductCategory { get; set; }
    public int ProductPrice { get; set;}
    public int ProductDiscount { get; set; }
    public int ProductStock { get; set; }

}