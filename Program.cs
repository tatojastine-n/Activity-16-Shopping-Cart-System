using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cart = new List<string>();
            bool running = true;

            Console.WriteLine("Welcome to the Shopping Cart System!");

            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Clear cart");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1: 
                            Console.Write("Enter item name to add: ");
                            string itemToAdd = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(itemToAdd))
                            {
                                cart.Add(itemToAdd);
                                Console.WriteLine($"'{itemToAdd}' added to cart.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid item name.");
                            }
                            break;

                        case 2: 
                            if (cart.Count == 0)
                            {
                                Console.WriteLine("Cart is empty.");
                                break;
                            }

                            Console.Write("Enter item name to remove: ");
                            string itemToRemove = Console.ReadLine();
                            if (cart.Remove(itemToRemove))
                            {
                                Console.WriteLine($"'{itemToRemove}' removed from cart.");
                            }
                            else
                            {
                                Console.WriteLine("Item not found in cart.");
                            }
                            break;

                        case 3: 
                            if (cart.Count == 0)
                            {
                                Console.WriteLine("Your cart is empty.");
                            }
                            else
                            {
                                Console.WriteLine("\nYour Cart:");
                                for (int i = 0; i < cart.Count; i++)
                                {
                                    Console.WriteLine($"{i + 1}. {cart[i]}");
                                }
                            }
                            break;

                        case 4: 
                            cart.Clear();
                            Console.WriteLine("Cart cleared.");
                            break;

                        case 5: 
                            running = false;
                            Console.WriteLine("Thank you for shopping with us!");
                            break;

                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
    }
}
