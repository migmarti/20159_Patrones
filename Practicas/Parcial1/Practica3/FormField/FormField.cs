using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormField {
    abstract class FormField : IValidable {
        public IValidable validationType;
        public bool isValid;
        public string value;
        
        public abstract bool validate(String value);
    }
}
