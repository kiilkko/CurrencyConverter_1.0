using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class ValueConverter
    {
        WebManager newWebmanager;

        public ValueConverter()
        {
            newWebmanager = new WebManager();
        }

        public double CourseParsing(string moneytype)
        {
            string stringCourse = newWebmanager.ConnectionAndSearch(moneytype);
            double course= 0.0;
            bool result = Double.TryParse(stringCourse, out course);
            return course;    

        }


        public string GetValue(string stringInput, string moneyType)
        {
            bool res = Double.TryParse(stringInput, out double input);            
            string Str_value = "" + Math.Round((1 / CourseParsing(moneyType) * input), 2);
            
            return Str_value;
        }

      
    }
}
