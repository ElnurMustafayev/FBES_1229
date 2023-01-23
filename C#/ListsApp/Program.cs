namespace ListsApp {
    class MyClass<T> {
        public T MyVar;

        public void Func() {
            Console.WriteLine(typeof(T));
        }
    }

    struct MyStruct<T1, T2> {
        public T1 num1;
        public T2 num2;
    }

    class Product {
        public string Name;
        public string Description;
        public decimal Price;
        public bool InStock;

        public Product(string name, string description, decimal price, bool inStock) {
            Name = name;
            Description = description;
            Price = price;
            InStock = inStock;
        }
    }

    class Program {
        static void Main() {
            //var products = new List<Product>(10);

            //var product = new Product(
            //    name: "Coconad",
            //    description: "Black",
            //    price: 0.99m,
            //    inStock: false);

            //products.Add(product);
            //products.Add(product);
            //products.Add(product);
            //products.Add(product);
            //products.Add(product);

            //products.RemoveAt(2);

            //for (int i = 0; i < products.Count; i++) {
            //    var currentProduct = products[i];
            //    Console.WriteLine($"{currentProduct.Name}: {currentProduct.Price}$");
            //}





            //var nums = new List<int>();
            //nums.Add(1);
            //nums.Add(3);
            //nums.Add(2);
            //nums.Add(3);

            //nums.Remove(3);
            //nums.RemoveAt(0);
            //nums.RemoveAt(0);

            //for (int i = 0; i < nums.Count; i++) {
            //    Console.WriteLine(nums[i]);
            //}




            //var list1 = new List<int>();            // good
            //MyStruct<int, decimal> list2 = new();   // bad




            //MyStruct<int, string> myStruct = new MyStruct<int, string>();

            //MyClass<decimal> obj1 = new MyClass<decimal>();
            //obj1.MyVar; //decimal type

            //MyClass<string> obj2 = new MyClass<string>();
        }

        static void Func<T>(T obj) {
            Console.WriteLine(obj);
        }
    }
}