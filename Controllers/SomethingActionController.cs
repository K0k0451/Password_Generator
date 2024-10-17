using Password_Generator.Model;
using Password_Generator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator.Controller
{
    public class SomethingActionController
    {
        public void Start()
        {
            Something something = new Something();
            Display display = new Display();

            something.ReadInput();

            display.Print(something.GeneratePasswords());
        }
    }
}
