using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Trucker trucker = new Trucker();

            student.walkingBehavior = new WalkFeet();
            teacher.walkingBehavior = new WalkHands();
            trucker.walkingBehavior = new NoWalking();

        }
    }
}
