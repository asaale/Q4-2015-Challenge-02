using challenge02_SolidShippingContainer.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge02_SolidShippingContainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //grab each shipping method in a way that will never need updating
            var shippingMethods = new List<IShippingMethod>();
            foreach (Type mytype in System.Reflection.Assembly.GetExecutingAssembly().GetTypes().Where(mytype => mytype.GetInterfaces().Contains(typeof(IShippingMethod))))
            {
                shippingMethods.Add((IShippingMethod)Activator.CreateInstance(mytype));
            }

            //Endlessly loop until the user wants out
            var userWantsToEnterAnotherOrder = true;
            while (userWantsToEnterAnotherOrder)
            {
                //prompt & verify user order weight
                Console.WriteLine("Enter the weight of your package (in lbs) in this format: xx.xx");
                var userInput = Console.ReadLine();
                var weight = 0.0;
                while(!double.TryParse(userInput, out weight) || weight == 0 || weight < 0)
                {
                    Console.WriteLine(userInput + " is not in the right format. try again, dummy");
                    userInput = Console.ReadLine();
                }

                //prompt & verify shipping method
                Console.WriteLine("Please select your shipping method by entering it's ID");
                var id = 0;
                for (int i = 0; i<shippingMethods.Count; i++)
                {
                    id = i + 1;
                    Console.WriteLine(id + " - " + shippingMethods[i].GetName());
                }
                userInput = Console.ReadLine();
                
                while (!int.TryParse(userInput, out id) || id < 0 || id > shippingMethods.Count)
                {
                    Console.WriteLine(userInput + " is not in the right format. try again, dummy");
                    userInput = Console.ReadLine();
                }
                var selectedShipping = shippingMethods[id - 1];

                //prompt user with order cost
                var cost = selectedShipping.CalculateShippingCost(weight);
                Console.WriteLine("the cost of shipping an order weighing " + weight + " lbs via " + selectedShipping.GetName() + " is $" + cost);

                //prompt user to enter another order or exit
                Console.WriteLine("Would you like to enter another Order? Y/N");
                var response = Console.ReadLine();
                userWantsToEnterAnotherOrder = response.ToLower() == "y";
            }
        }
    }
}
