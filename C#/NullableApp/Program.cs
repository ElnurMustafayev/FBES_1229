namespace NullableApp;

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public bool IsMarried { get; set; }
}

class Program
{
    static User? GetUser(bool GetNull = true)
    {
        return !GetNull
            ? new User()
            {
                Name = null,
                IsMarried = true,
                Age = 32,
            }
            : null;
    }

    static void Main()
    {
        if (false) {
            var user = new User() {
                Name = null,
            };

            var test = user?.IsMarried!;
        }

        if (false) {
            int? num = null;

            num ??= 10;

            Console.WriteLine(num);
        }

        if(false) {
            //IEnumerable<User> users = new List<User>();
            //User found = users.FirstOrDefault(u => u.Age >= 0)!;

            //if((found ?? throw new ArgumentException())?.IsMarried) {

            //}

            //bool? condition = null;
            //if(condition != null && condition == true) {
            //    Console.WriteLine("IF");
            //}

            //Console.WriteLine(found!.IsMarried);
            
            //User user = GetUser(GetNull: true)!;
            //Console.WriteLine(user.IsMarried);
        }

        if(false) {
            int? num = 123;

            if(true)
                num = null;

            Console.WriteLine(num == null ? 0 : num);
            Console.WriteLine(num ?? 0);

            var res = num?.ToString()?.ToString()?.ToString()?.ToString()?.ToString();
            var result = num ?? num ?? num ?? num ?? num ?? num ?? num ?? num;
        }

        if(false) {
            User? user = new User() {
                Name = null
            };

            var obj = user.Name?.ToUpper();
        }

        if(false)
        {
            User? user = GetUser();
            //if(user != null)
            //{
            //    Console.WriteLine(user.Age);
            //}

            // Nullchecks
            user = GetUser(GetNull: false);

            var name = user?.Name;
            var upperName = name?.ToUpper();

            Console.WriteLine(upperName == user?.Name?.ToUpper());

            //var name = user?.Name?.ToUpper();
            //Console.WriteLine(user?.Age);





            //  IEnumerable<User> users = new List<User>();
            //  User? user = users.FirstOrDefault();
        }

        if(false)
        {
            //Nullable<bool> isMarried = null;
            //Console.WriteLine(isMarried.HasValue);
            //Console.WriteLine(isMarried.Value);

            bool? isMarried = null;
            int? num = null;

            Console.WriteLine();

            return;
            if(isMarried is null)
            {
                Console.WriteLine(isMarried);
                Console.WriteLine("isMarried is null!!!");
            }
            else
            {
                isMarried = !isMarried;
                Console.WriteLine(isMarried);
            }
        }

        if(false)
        {
            Nullable<int> age = null;

            Console.WriteLine(age);

            if (age.HasValue)
            {
                age += 10;

                Console.WriteLine(age.Value);
            }
            else
            {
                Console.WriteLine("Age is null");
            }
        }

        if(false) {
            //int age = null;


            //User user = new User()
            //{
            //    Name = "Elnur",
            //    Age = null,
            //    IsMarried = null,
            //};
        }
    }
}