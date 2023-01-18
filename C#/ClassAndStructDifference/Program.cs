using System.Text;

namespace ClassAndStructDifference {
    struct MyStruct {
        public int num = 20;
        public string name;

        public MyStruct() {
            num = 0;
            name = "Test";
        }

        public MyStruct(int num) {
            this.name = null;
        }
    }

    struct TestStruct {
        public int iNum;
        public float fNum;
    }

    class TestClass {
        public int iNum;
        public float fNum;

        public TestClass(int iNum, float fNum) {
            this.iNum = iNum;
            this.fNum = fNum;
        }
        public TestClass() {

        }
    }

    struct Person {
        public string name;
        public uint age;
        public int[] marks;

        public void ShowInfo() {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Age: {this.age}");
            Console.Write($"Marks: ");

            for (int i = 0; i < marks.Length; i++)
                Console.Write(marks[i] + " ");

            Console.WriteLine();
        }
    }

    class Car {
        public Person driver;
    }


    class Test {
        public int[] nums;

        public Test() {
            nums = new int[3] { 1, 2, 3 };
        }

        public void ShowArr() {
            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");

            Console.WriteLine();
        }
    }

    class Program {
        static void Main() {
            if (false) {
                Test obj1 = new Test();
                Test obj2 = new Test();

                obj1 = obj2;

                obj1.nums = new int[3] { 3, 2, 1 };

                obj1.ShowArr();
                obj2.ShowArr();
            }

            if (false) {
                Person p1 = new Person();
                p1.name = "David";
                p1.age = 15;
                p1.marks = new int[3] { 12, 12, 11 };

                Person p2 = new Person();
                p2 = p1;
                p2.marks[p2.marks.Length - 1] = 12;

                p1.ShowInfo();
                Console.WriteLine();
                p2.ShowInfo();
            }

            if (false) {
                Person p = new Person();
                p.name = "Bob";
                p.age = 45;

                Car car = new Car();
                car.driver = p;
            }

            if(false) {
                TestClass obj1 = new TestClass();
                TestClass obj2 = new TestClass();

                obj1.iNum = 123;
                obj1.fNum = 12.5f;

                obj2 = obj1;

                obj2.iNum += 20;

                Console.WriteLine(obj1.iNum);
                Console.WriteLine(obj1.fNum);
                Console.WriteLine();
                Console.WriteLine(obj2.iNum);
                Console.WriteLine(obj2.fNum);
            }

            if(false) {
                TestStruct obj1 = new TestStruct();
                obj1.iNum = 123;
                obj1.fNum = 12.5f;

                TestStruct obj2 = new TestStruct();
                obj2 = obj1;

                ++obj2.iNum;
                --obj1.fNum;

                Console.WriteLine(obj1.iNum);
                Console.WriteLine(obj1.fNum);
                Console.WriteLine();
                Console.WriteLine(obj2.iNum);
                Console.WriteLine(obj2.fNum);
            }

            if (false) {
                MyStruct obj1 = new MyStruct();
                MyStruct obj2 = new MyStruct(12);

                Console.WriteLine(obj1.num);
                Console.WriteLine(obj1.name);

                Console.WriteLine(obj2.num);
                Console.WriteLine(obj2.name);
            }
        }
    }
}