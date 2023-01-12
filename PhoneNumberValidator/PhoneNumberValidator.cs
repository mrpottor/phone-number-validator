using System;
using System.Text.RegularExpressions;

namespace PhoneNumberValidator
{
    //Please do not change the signature of class methods
    public class PhoneNumberValidator
    {
        static void Main(string[] args)
        {
            // call the functions to validate phone number and display the status
            string PhoneNumber = GetInput();
            int result = ValidatePhoneNumber(PhoneNumber);
            DisplayResult(result);
        }
        public static string GetInput()
        {
            // get phonenumber as input
            string PhoneNumber = Console.ReadLine();
            return PhoneNumber;
        }
        public static void DisplayResult(int result)
        {
            // display status of phone number valid or invalid
            if (result == 1)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
        public static int ValidatePhoneNumber(string input)
        {
            // validate phone-number
            // for null or empty value, function should return -1
            // for invalid phone-number, function should return 0
            // for valid phone-number, function should return 1

            if( input == null || input == "")
            {
                return -1;
            }

            string Expression = @"[d\-]{10}$";
            Regex PhoneRegex = new Regex(Expression);
            
            if(PhoneRegex.IsMatch(input))
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
