using Assignment.model;
using Assignment.Repository;
using Assignment.Service;
using Microsoft.VisualBasic;
using System;
using System.Reflection;
using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1: Control Flow Statements
            #region Q1 Order Status
            //Console.Write("Enter the order status: ");
            //string orderStatus = Console.ReadLine();
            //if (orderStatus == "Delivered")
            //{
            //    Console.WriteLine("The order is delivered.");
            //}
            //else if (orderStatus == "Processing")
            //{
            //    Console.WriteLine("The order is still being processed.");
            //}
            //else if (orderStatus == "Cancelled")
            //{
            //    Console.WriteLine("The order is cancelled.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid order status");
            //}
            #endregion
            #region Q2 Checking Weights
            //Console.Write("Enter the parcel weight in grams: ");
            //int parcelWeight = int.Parse(Console.ReadLine());
            //switch (parcelWeight)
            //{
            //    case int weight when weight <= 50:
            //        Console.WriteLine("Light parcel.");
            //        break;
            //    case int weight when weight <= 150:
            //        Console.WriteLine("Medium parcel.");
            //        break;
            //    default:
            //        Console.WriteLine("Heavy parcel.");
            //        break;
            //}
            #endregion
            #region Q3  User Authrntiation
            //Console.WriteLine("Welcome to the System :---> ");
            //string empName = "Rakhim";
            //string empPass = "1234";

            //string custName = "Cornwell";
            //string custPass = "5678";

            //Console.WriteLine("Press the following keys to get ahead :");
            //Console.WriteLine("1 --> for Employee");
            //Console.WriteLine("2 --> for Customer");


            //int key = Convert.ToInt32(Console.ReadLine());

            //if(key == 1)
            //{
            //    Console.WriteLine("Welcome to the Employee System : \n");
            //    start:
            //    Console.WriteLine("Press the following keys to continue : \n");

            //    Console.WriteLine("1 --> for Registration");
            //    Console.WriteLine("2 --> for Login");
            //    Console.WriteLine("3 --> for Logout");


            //    int empKey = Convert.ToInt32(Console.ReadLine());

            //    if (empKey == 1)
            //    {
            //        Console.WriteLine("Registering user....");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        Console.WriteLine($"You have successfully registered, {name}");
            //        goto start;

            //    }
            //    else if(empKey == 2)
            //    {
            //        Console.WriteLine("User Login....");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        int tryCount = 0;

            //        if(empName == name && empPass == password)
            //        {
            //            Console.WriteLine($"Welcome {name},continue exploring our system \n");
            //            goto start;
            //        }
            //        else
            //        {
            //            if(tryCount < 3)
            //            {
            //                Console.WriteLine("Please try entering valid username or password");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Your limit is over , please try again after 24 hours \n");
            //            }

            //            goto start;
            //        }
            //    }
            //    else if(empKey == 3)
            //    {
            //        Console.WriteLine("You have successfully logged out \n");

            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Welcome to the Customer System :");
            //start:
            //    Console.WriteLine("Press the following keys to continue : \n");

            //    Console.WriteLine("1 --> for Registration");
            //    Console.WriteLine("2 --> for Login");
            //    Console.WriteLine("3 --> for Logout");
            //    Console.WriteLine("\n");

            //    int custKey = Convert.ToInt32(Console.ReadLine());

            //    if (custKey == 1)
            //    {
            //        Console.WriteLine("Registering user.... \n");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        Console.WriteLine($"You have successfully registered, {name}");
            //        goto start;

            //    }
            //    else if (custKey == 2)
            //    {
            //        Console.WriteLine("User Login.... \n");
            //        Console.WriteLine("Enter your name :");
            //        string name = Console.ReadLine();

            //        Console.WriteLine("Enter your password :");
            //        string password = Console.ReadLine();

            //        int tryCount = 0;

            //        if (custName == name && custPass == password)
            //        {
            //            Console.WriteLine($"Welcome {name},continue exploring our system \n");
            //            goto start;
            //        }
            //        else
            //        {
            //            if (tryCount < 3)
            //            {
            //                Console.WriteLine("Please try entering valid username or password \n");
            //                goto start;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Your limit is over , please try again after 24 hours \n");
            //            }
            //        }
            //    }
            //    else if (custKey == 3)
            //    {
            //        Console.WriteLine("You have successfully logged out \n");

            //    }
            //}
            #endregion
            #region 04 shipments
            //Console.Write("Enter no of couriers: ");
            //int courierslist =int.Parse(Console.ReadLine());
            //for (int i=0; i<courierslist; i++)
            //{
            //    Console.WriteLine("Enter weight of courier: ");
            //    int weight =int.Parse(Console.ReadLine());
            //    if (weight>=0 && weight <= 50)
            //    {
            //        Console.WriteLine("Courier is assigned to shipment1");
            //    }
            //    else if (weight>50 && weight <= 100)
            //    {
            //        Console.WriteLine("Courier is assigned to shipment2");
            //    }
            //    else if (weight > 100)
            //    {
            //        Console.WriteLine("courier is assigned to shipment3");
            //    }
            //    else if (weight < 0)
            //    {
            //        Console.WriteLine("Invalid Weight");
            //    }
            //}
            #endregion
            //Task 2: Loops and Iteration
            #region Q5 Displaying Orders
            //    string[,] orders = {
            //    {"Ram", "Order001", "ProductA"},
            //    {"Rahul", "Order002", "ProductB"},
            //    {"Raghu", "Order003", "ProductC"},
            //    {"ram", "Order004", "ProductA"}
            //};

            //    Console.Write("Enter customer name to display orders: ");
            //    string customerToDisplay = Console.ReadLine();

            //    Console.WriteLine($"Orders for customer: {customerToDisplay}\n");

            //    for (int i = 0; i < orders.GetLength(0); i++)
            //    {
            //        if (orders[i, 0] == customerToDisplay)
            //        {
            //            Console.WriteLine($"Order: {orders[i, 1]}, Product: {orders[i, 2]}");
            //        }
            //    }
            #endregion
            #region Q6 live location tracking
            //Console.WriteLine("Courier is on its way to the destination...");
            //int distanceToDestination = 0; // Replace with the actual distance to the destination
            //int currentLocation = 100;
            //while (currentLocation > distanceToDestination)
            //{
            //    Console.WriteLine($"Courier is at location {currentLocation} km nearer to u.");
            //    // Simulate movement (you might replace this with actual tracking logic)
            //    currentLocation -= 10;
            //    // You can add some delay logic or user input for the next iteration
            //    Console.WriteLine("Press Enter to continue...");
            //    Console.ReadLine();
            //}
            //Console.WriteLine("Courier has reached the destination!");
            #endregion
            //Task 3: Arrays and Data Structures 
            #region Q7 Tracking history of parcel
            //string[,] trackingHistory = new string[5, 2];
            //UpdateTrackingHistory(trackingHistory, "Location 1", "2024-02-10 10:00:00");
            //UpdateTrackingHistory(trackingHistory, "Location 2", "2024-02-12 14:30:00");
            //UpdateTrackingHistory(trackingHistory, "Location 3", "2024-02-15 09:45:00");
            //UpdateTrackingHistory(trackingHistory, "Location 4", "2024-02-18 12:15:00");
            //UpdateTrackingHistory(trackingHistory, "Location 5", "2024-02-20 16:20:00");

            //// Display tracking history
            //DisplayTrackingHistory(trackingHistory);
            //static void UpdateTrackingHistory(string[,] trackingHistory, string location, string timestamp)
            //{
            //    for (int i = 0; i < trackingHistory.GetLength(0); i++)
            //    {
            //        if (trackingHistory[i, 0] == null)
            //        {
            //            trackingHistory[i, 0] = location;
            //            trackingHistory[i, 1] = timestamp;
            //            break;
            //        }
            //    }
            //}
            //static void DisplayTrackingHistory(string[,] trackingHistory)
            //{
            //    Console.WriteLine("Tracking History:");
            //    for (int i = 0; i < trackingHistory.GetLength(0) && trackingHistory[i, 0] != null; i++)
            //    {
            //        Console.WriteLine($"Location: {trackingHistory[i, 0]}, Timestamp: {trackingHistory[i, 1]}");
            //    }
            //}
            #endregion
            #region Q8 nearest Available Courier
            //int[,] couriers = {
            //{ 1, 100 },
            //{ 2, 200 },
            //};
            //// Example present location (assuming present location is 0)
            //int presentLocation = 0;

            //// Find the nearest available courier
            //int[] nearestCourier = FindNearestAvailableCourier(couriers, presentLocation);

            //if (nearestCourier != null)
            //{
            //    Console.WriteLine($"Nearest available courier is Courier {nearestCourier[0]} at distance {nearestCourier[1]}");
            //}
            //else
            //{
            //    Console.WriteLine("No available couriers found.");
            //}
            //static int[] FindNearestAvailableCourier(int[,] couriers, int presentLocation)
            //{
            //    int[] nearestCourier = null;
            //    int minDistance = int.MaxValue;

            //    for (int i = 0; i < couriers.GetLength(0); i++)
            //    {
            //        int courierNumber = couriers[i, 0];
            //        int distance = Math.Abs(couriers[i, 1] - presentLocation);

            //        if (distance < minDistance)
            //        {
            //            minDistance = distance;
            //            nearestCourier = new int[] { courierNumber, couriers[i, 1] };
            //        }
            //    }

            //    return nearestCourier;
            //}
            #endregion
            //Task 4: Strings,2d Arrays, user defined functions,Hashmap 
            #region Q9 Parcel tracking
            ////Create a program that allows users to input a parcel tracking number.Store the
            ////tracking number and Status in 2d String Array. Initialize the array with values.Then, simulate the
            ////tracking process by displaying messages like "Parcel in transit," "Parcel out for delivery," or "Parcel 
            ////delivered" based on the tracking number's status
            //string[,] parcelData = {
            //{"T123456", "Parcel in transit"},
            //{"T789012", "Parcel out for delivery"},
            //{"T345678", "Parcel delivered"}};
            //Console.Write("Enter parcel tracking number: ");
            //string inputTrackingNumber = Console.ReadLine();
            //bool found = false;
            //string status = "";
            //for (int i = 0; i < parcelData.GetLength(0); i++)
            //{
            //    if (parcelData[i, 0] == inputTrackingNumber)
            //    {
            //        found = true;
            //        status = parcelData[i, 1];
            //        break;
            //    }
            //}
            //if (found)
            //{
            //    Console.WriteLine($"Tracking Number: {inputTrackingNumber}");
            //    Console.WriteLine($"Status: {status}");
            //}
            //else
            //{
            //    Console.WriteLine("Tracking number not found.");
            //}
            #endregion
            #region  Q10  Customer Data Validation
            //static bool ValidateCustData(string custData, string details)
            //{
            //    switch (custData)
            //    {
            //        case ("Name"):
            //            return ValidateName(details);
            //        case ("Address"):
            //            return ValidateAddress(details);
            //        case ("Phone"):
            //            return ValidatePhone(details);
            //        default:
            //            Console.WriteLine("Data provided is invalid");
            //            return false;
            //    }
            //}
            //static bool ValidateName(string Name)
            //{
            //    return Regex.IsMatch(Name, "^[A-Za-z ]+$");
            //}

            //static bool ValidateAddress(string Address)
            //{
            //    return Regex.IsMatch(Address, "^[A-Za-z0-9 ]+$");
            //}

            //static bool ValidatePhone(string Phone)
            //{
            //    return Regex.IsMatch(Phone, @"^\d{3}-\d{3}-\d{4}$");
            //}

            //Console.WriteLine("Enter name of customer:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter address of customer:");
            //string address = Console.ReadLine();

            //Console.WriteLine("Enter phone number of customer:");
            //string phoneNo = Console.ReadLine();

            //if (ValidateCustData("Name", name))
            //{
            //    Console.WriteLine("Name is valid");
            //}
            //else
            //{
            //    Console.WriteLine("Name is not valid");
            //}
            //if (ValidateCustData("Address", address))
            //{
            //    Console.WriteLine("Address is valid");
            //}
            //else
            //{
            //    Console.WriteLine("Address is not valid");
            //}
            //if (ValidateCustData("Phone", phoneNo))
            //{
            //    Console.WriteLine("Phone number is valid");
            //}
            //else
            //{
            //    Console.WriteLine("Phone number is not valid");
            //}
            #endregion
            #region Q12 generating Email
            //Console.Write("Enter customer name: ");
            //string customerName = Console.ReadLine();

            //Console.Write("Enter order number: ");
            //string orderNumber = Console.ReadLine();

            //Console.Write("Enter delivery address: ");
            //string deliveryAddress = Console.ReadLine();

            //Console.Write("Enter expected delivery date (yyyy-MM-dd): ");
            //string expectedDeliveryDateString = Console.ReadLine();

            //string emailBody = "Subject: Order Confirmation\n\n" +
            //                   $"Dear {customerName},\n\n" +
            //                   $"Thank you for your order! Your order with order number {orderNumber} has been confirmed.\n" +
            //                   $"Delivery Address: {deliveryAddress}\n" +
            //                   $"Expected Delivery Date: {expectedDeliveryDateString}\n\n" +
            //                   "We appreciate your business!\n\n" +
            //                   "Sincerely,\n" +
            //                   "Your Company Name";

            //Console.WriteLine("\nOrder Confirmation Email:\n");
            //Console.WriteLine(emailBody);
            #endregion
            #region 13. Calculate Shipping Costs:
            //string[,] locations = {
            //{"Hyderabad", "100"},
            //{"Kolkata", "200"}};
            //Console.WriteLine("Enter the weight of the parcel:");
            //double weight = double.Parse(Console.ReadLine());
            //double shippingCost = CalculateShippingCost(locations, weight);
            //Console.WriteLine($"Shipping cost for a parcel weighing {weight} kg from {locations[0, 0]} to {locations[1, 0]} is: {shippingCost}");
            //static double CalculateShippingCost(string[,] locations, double weight)
            //{
            //    if (locations.GetLength(0) < 2)
            //    {
            //        Console.WriteLine("At least two locations are required to calculate distance.");
            //        return 0.0;
            //    }

            //    // Assuming the second value in each location represents the distance
            //    int distance = Math.Abs(int.Parse(locations[0, 1]) - int.Parse(locations[1, 1]));

            //    double basePrice = 10.0; // Adjust the base price as needed
            //    double distanceCost = distance * 0.1; // Adjust the multiplier as needed
            //    double weightCost = weight * 2.0; // Adjust the multiplier as needed

            //    return basePrice + distanceCost + weightCost;
            //}
            #endregion
            #region Q14 Password Generator
            //Console.Write("Enter a password: ");
            //string userPassword = Console.ReadLine();
            //if (IsStrongPassword(userPassword))
            //{
            //    Console.WriteLine("Strong Password!");
            //}
            //else
            //{
            //    Console.WriteLine("Weak Password. Ensure it includes a mix of uppercase letters, lowercase letters, numbers, and special characters.");
            //}
            //static bool IsStrongPassword(string password)
            //{
            //    // Check if password contains at least one uppercase letter, one lowercase letter, one digit, and one special character
            //    return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Any(IsSpecialCharacter);
            //}

            //static bool IsSpecialCharacter(char c)
            //{
            //    // You can customize the set of special characters as needed
            //    string specialCharacters = "!@#$%^&*()-_=+";
            //    return specialCharacters.Contains(c);
            //}
            #endregion
            #region Q15 Similar Address
            //List<string> addresses = new List<string>{
            //"123 park St",
            //"456 church St",
            //"789 keerthi Ave",
            //"123 park St",
            //"789 reddy Ave",
            //"101 Pine Rd"};
            //string targetAddress = "123 park St";
            //List<string> similarAddresses = FindSimilarAddresses(addresses, targetAddress);
            //Console.WriteLine("Similar addresses to " + targetAddress + ":");
            //foreach (var address in similarAddresses)
            //{
            //    Console.WriteLine(address);
            //}
            //static List<string> FindSimilarAddresses(List<string> addresses, string targetAddress)
            //{
            //    List<string> similarAddresses = new List<string>();

            //    foreach (var address in addresses)
            //    {
            //        // Case-insensitive comparison
            //        if (String.Equals(address, targetAddress, StringComparison.OrdinalIgnoreCase))
            //        {
            //            similarAddresses.Add(address);
            //        }
            //    }
            //    return similarAddresses;
            //}
            #endregion
            //Task 5: Object Oriented Programming --CREATED CLASSES IN MODEL
            //Task 6: Service Provider Interface /Abstract class
            ICourierUserService courierUserService = new CourierUserService();
            //courierUserService.PlaceOrder();
            //courierUserService.GetAllUsers();
            //courierUserService.getOrderStatus();
            //courierUserService.CancelOrder();
            //courierUserService.GetAssignedOrder();
            //ICourierAdminService courierAdminService = new CourierAdminService();
            //ourierAdminService.AddCourierStaff();
            //courierUserService.GetCourierById();
            //courierUserService.AddCourier();
            //courierUserService.UpdateCourier();
        }



    }
    
}
