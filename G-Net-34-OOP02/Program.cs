using G_Net_34_OOP02.childs;
using helper_1;
using System.ComponentModel;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace G_Net_34_OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1
            #region q1
            //        Q1: Identify the type of relationship in each scenario below(Inheritance, Association, Aggregation, Composition, or Dependency):

            //a) A University has Departments. If the university is closed, the departments no longer exist.

            //Composition
            //b) A Driver uses a Car.The driver does not own the car.
            //association 
            //c) A Dog is an Animal.
            //inheritance
            //d) A Team has Players. If the team is deleted, the players still exist.
            //agreation
            //e) A method receives a Logger as a parameter and calls it inside the method only.
            //dependency
            #endregion
            #region q2
            //        Q2: Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field.Can a child class in a different assembly access it? What about through an object instance from outside?
            //no , yes theough an object  instance from outside it can be accessed because  protected is accessible by any class in the same assembly
            //b) What is the difference between protected internal and private protected?
            //private protected is only accessible wittin the same assembly and by drivied class,protected is accessible witin the same  assembly and by derivied class and by any class in  the same assembly
            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //when applied to a class it pervents other class from inherting,in method it pervents overrrideing

            //d) Can you create an object from a sealed class using new? Why or why not?
            // i can  its only effect the inheritance not the  object creation

            #endregion
            #endregion

            #region part 2 
            Cinema_cs cinema = new Cinema_cs("IMAX");

                cinema.OpenCinema();

                Ticket t1 = new StandardTicket("Inception", 120, 5);
                Ticket t2 = new VIPTicket("Avengers", 200, true);
                Ticket t3 = new IMAXTicket("Dune", 180, false);

                cinema.AddTicket(t1);
                cinema.AddTicket(t2);
                cinema.AddTicket(t3);

                cinema.PrintAllTickets();
            //cinema.CalcGroupDiscount();  //msh 3aiz y return

                cinema.CloseCinema();
            }
        }
        #endregion
    }
    

