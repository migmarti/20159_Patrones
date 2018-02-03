using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormField {
    class StringField : FormField {
        public StringField(IValidable validationType, string value) : base() {
            this.validationType = validationType;
            this.value = value;
        }
        override public bool validate(String value) {
            return validationType.validate(value);
        }
        public void testMessage() {
            Console.WriteLine("Is " + this.value + " valid? " + this.validate(this.value));
        }
    }
}
