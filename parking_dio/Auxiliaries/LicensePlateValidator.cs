using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace parking_dio.Auxiliaries
{
    public static class LicensePlateValidator
    {
        public static bool ValidatorPlate(string plate)
        {
            if (string.IsNullOrWhiteSpace(plate)) { return false; }

            if (plate.Length > 8) { return false; }

            plate = plate.Replace("-", "").Trim();

            if (char.IsLetter(plate, 4))
            {

                var defaultMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");
                return defaultMercosul.IsMatch(plate);
            }
            else
            {
                var defaultNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");
                return defaultNormal.IsMatch(plate);
            }
        }
    }
}
