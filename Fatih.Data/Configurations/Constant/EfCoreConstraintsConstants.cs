using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme.DataAccess.Concrete.EntityFramework.Configurations.Constant
{
    public class EfCoreConstraintsConstants
    {
        public static int NameMaxLenght { get; } = 100;
        public static int DescriptionMaxLenght { get; } = 400;
        public static int ImageMaxLenght { get; } = 400;
        public static string PriceConfig { get; } = "decimal(18,2)";

        public static int EmailMaxLenght { get; } = 100;
        public static int PhoneMaxLenght { get; } = 50;
        public static int CityNameMaxLenght { get; } = 100;
        public static int CountryNameMaxLenght { get; } = 100;
        public static int AddressDetailMaxLenght { get; } = 250;
        public static int PasswordMaxLenght { get; } = 20;

    }
}
