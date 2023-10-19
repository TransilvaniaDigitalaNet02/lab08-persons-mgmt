using System.Text;

namespace PersonsManagement
{
    internal static class PersonConsolePrinter
    {
        public static void Print(Person person)
        {
            if (person is null)
            {
                Console.WriteLine("Warning: cannot print a null person!");
                return;
            }

            Console.WriteLine($"First Name={person.FirstName}");
            Console.WriteLine($"Last Name={person.LastName}");
            Console.WriteLine($"Date of Birth (yyyy/mm/dd)={person.DateOfBirth:yyyy/MM/dd}");
            Console.WriteLine($"Age (as of today)={person.Age}");
            Console.WriteLine($"Address: {GetAddressString(person.Address)}");
        }

        private static string GetAddressString(Address address)
        {
            if (address is null)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            bool otherAddressPartsWritten = false;

            WriteAddressPart(sb, address.Street, ref otherAddressPartsWritten);
            WriteAddressPart(sb, address.StreetNumber, ref otherAddressPartsWritten);
            WriteAddressPart(sb, address.City, ref otherAddressPartsWritten);
            WriteAddressPart(sb, address.County, ref otherAddressPartsWritten);
            WriteAddressPart(sb, address.Country, ref otherAddressPartsWritten);

            return sb.ToString();
        }

        private static void WriteAddressPart(StringBuilder builder, string addressPart, ref bool otherAddressPartsWritten)
        {
            if (!string.IsNullOrWhiteSpace(addressPart))
            {
                if (otherAddressPartsWritten)
                {
                    builder.Append(", ");
                }

                builder.Append(addressPart);
                otherAddressPartsWritten = true;
            }
        }
    }
}
