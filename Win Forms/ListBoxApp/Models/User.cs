using System.Text;

namespace ListBoxApp.Models
{
    public class User
    {
        private string name;
        private string password;

        public string ImageUrl { get; set; }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(
                        paramName: nameof(value),
                        message: $"User's {nameof(name)} can not be empty!");

                this.name = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException(
                        paramName: nameof(value),
                        message: $"User's {nameof(password)} can not be empty!");

                bool containsDigit = false;
                foreach (char symbol in value)
                {
                    if (char.IsDigit(symbol))
                    {
                        containsDigit = true;
                        break;
                    }
                }

                if (containsDigit == false)
                {
                    throw new ArgumentException(
                        message: "Password must contain at least 1 digit symbol!",
                        paramName: nameof(value));
                }

                this.password = value;
            }
        }
        public string MaskPassword
        {
            get
            {
                if (string.IsNullOrEmpty(this.Password))
                    return string.Empty;

                StringBuilder result = new StringBuilder(this.Password.Length);

                for (int i = 0; i < this.Password.Length; i++)
                    result.Append('*');

                return result.ToString();
            }
        }

        public override string ToString() => $"{Name} - {MaskPassword}";
    }
}
