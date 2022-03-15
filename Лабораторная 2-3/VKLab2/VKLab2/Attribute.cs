using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace VKLab2
{
    class Attribute : ValidationAttribute
    {
        private Regex regex = new Regex(@"^{2000,2022}$");
        public override bool IsValid(object value)
        {
            if (regex.IsMatch(value.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
