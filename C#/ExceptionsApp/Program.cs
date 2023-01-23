namespace ExceptionsApp {
    class Program {
        static bool isNewAzePassport(string fin) {
            if(string.IsNullOrWhiteSpace(fin)) {
                throw new ArgumentNullException(message: "FIN is empty", paramName: "fin");
            }

            if (fin.StartsWith("AA"))
                return true;
            else if (fin.StartsWith("AZE"))
                return false;
            else {
                throw new ArgumentException(message: "Incorrect FIN", paramName: "fin");
            }
        }

        static void Main() {
            try {
                bool result = isNewAzePassport("aa123456");
                Console.WriteLine(result);

                throw new Exception(Console.ReadLine());

                Exception exception = new Exception("This is my error message!");
                throw exception;
            }
            catch (ArgumentException ex) {
                Console.WriteLine($"Argument exception message: '{ex.Message}'");
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception message: '{ex.Message}'");
            }
        }
    }
}