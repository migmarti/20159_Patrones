using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormField {
    class Program {
        static void Main(string[] args) {

            ValidateEmail emailType = new ValidateEmail();
            ValidateNumber numberType = new ValidateNumber();

            StringField emailField1 = new StringField(emailType, "test@email.com");
            StringField emailField2 = new StringField(emailType, "adasdad");
            StringField numberField1 = new StringField(numberType, "1010");
            StringField numberField2 = new StringField(numberType, "weeeeee");

            Console.WriteLine("\n- Email Fields -\n");
            emailField1.testMessage();
            emailField2.testMessage();
            Console.WriteLine("\n- Number Fields -\n");
            numberField1.testMessage();
            numberField2.testMessage();
            Console.ReadKey();
        }
    }
}
