using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormField {
    class ValidateNumber : IValidable {
        public bool validate(String value) {
            return value.All(Char.IsDigit);
        }
    }
}
