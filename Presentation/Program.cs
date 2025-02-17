﻿using Application.Services.Abstract;
using Application.Services.Concrete;
using Core.Constants;
using Core.Constants.Operations;
using Data;
using Data.UnitOfWork.Concrete;

public static class Program
{
    private static readonly AdminService _adminService;
    private static readonly SellerService _sellerService;
    private static readonly CustomerService _customerService;

    static Program()
    {
        _adminService = new AdminService();
        _sellerService = new SellerService();
        _customerService = new CustomerService();


    }
    public static void Main()
    {
        DbInitializer.SeedData();
        MainMenu();



    }
    public static void MainMenu()
    {
    menuSection:
        Console.WriteLine(" ");
        Console.WriteLine("Choose account type");
        Console.WriteLine(" ");
        Console.WriteLine("1.Admin");
        Console.WriteLine("2.Seller");
        Console.WriteLine("3.Customer");
        Console.WriteLine("0.Exit");
        string userInput = Console.ReadLine();
        int choice;
        bool isSucceeded = int.TryParse(userInput, out choice);
        if (!isSucceeded)
        {
            Messages.InvalidInputMessage("Choice");
            goto menuSection;
        }
        switch (choice)
        {
            case 1:
                ShowAdminMenu();
                break;
            case 2:
                ShowSellerMenu();
                break;
            case 3:
                ShowCustomerMenu();
                break;
            case 0:
                return;
            default:
                Messages.InvalidInputMessage("Choice");
                goto menuSection;

        }
    }
    public static void ShowAdminMenu()
    {
        if (_adminService.AdminLogin())
        {

            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("---Menu---");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Seller Operations:");
                Console.ResetColor();
                Console.WriteLine("1.Create Seller");
                Console.WriteLine("2.Get All Sellers");
                Console.WriteLine("3.Delete Seller ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Customer Operations:");
                Console.ResetColor();
                Console.WriteLine("4.Create Customer");
                Console.WriteLine("5.Get All Customers");
                Console.WriteLine("6.Delete Customer");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Category Operations:");
                Console.ResetColor();
                Console.WriteLine("7.Add Category");
                Console.WriteLine("8.See All Categories");
                Console.WriteLine("9.Delete Category");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Order Operations:");
                Console.ResetColor();
                Console.WriteLine("10.See All Orders ");
                Console.WriteLine("11.See Order Of Seller");
                Console.WriteLine("12.See Order Of Customer");
                Console.WriteLine("13.See Order Date ");
                Console.WriteLine(" ");
                Console.WriteLine("0.Exit");
                Console.WriteLine("Choose from Menu:");

            UserInputSection:
                string userInput = Console.ReadLine();
                int choice;
                bool isSucceeded = int.TryParse(userInput, out choice);
                if (!isSucceeded)
                {
                    Messages.InvalidInputMessage("Choice");
                    goto UserInputSection;
                }
                switch ((AdminOperations)choice)
                {
                    case AdminOperations.CreateSeller:
                        _adminService.CreateSeller();
                        break;
                    case AdminOperations.GetAllSellers:
                        _adminService.GetSellers();
                        break;
                    case AdminOperations.DeleteSeller:
                        _adminService.DeleteSeller();
                        break;
                    case AdminOperations.CreateCustomer:
                        _adminService.CreateCustomer();
                        break;
                    case AdminOperations.GetAllCustomers:
                        _adminService.GetCustomers();
                        break;
                    case AdminOperations.DeleteCustomer:
                        _adminService.DeleteCustomer();
                        break;
                    case AdminOperations.AddCategory:
                        _adminService.AddCategory();
                        break;
                    case AdminOperations.SeeAllCategories:
                        _adminService.SeeAllCategories();
                        break;
                    case AdminOperations.DeleteCategory:
                        _adminService.DeleteCategory();
                        break;
                    case AdminOperations.SeeAllOrders:
                        _adminService.SeeOrders();
                        break;
                    case AdminOperations.SeeOrderOfSeller:
                        _adminService.SeeOrderBySeller();
                        break;
                    case AdminOperations.SeeOrderOfCustomer:
                        _adminService.SeeOrderByCustomer();
                        break;
                    case AdminOperations.SeeOrderOfDate:
                        _adminService.SeeOrderByDate();
                        break;
                    case AdminOperations.Exit:
                        MainMenu();
                        break;
                    default:
                        Messages.InvalidInputMessage("Choice");
                        break;

                }
            }
        }
        else
        {
            MainMenu();
        }
    }
    public static void ShowSellerMenu()
    {

        if (_sellerService.SellerLogin())
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("--Menu--");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Change Product Quantity");
                Console.WriteLine("3.Delete Product");
                Console.WriteLine("4.See Who Purchased Products");
                Console.WriteLine("5.See Purchased Product For Date");
                Console.WriteLine("6.sort Product For Name");
                Console.WriteLine("7.See Total Income");
                Console.WriteLine("8.Get All Products");
                Console.WriteLine("0.Exit");
                Console.WriteLine(" ");
                Console.WriteLine("Choose From Menu");

                string input = Console.ReadLine();
                int choice;
                bool isSucceeded = int.TryParse(input, out choice);
                if (isSucceeded)
                {
                    switch ((SellerOperations)choice)
                    {
                        case SellerOperations.Add:
                            _sellerService.AddProduct();
                            break;
                        case SellerOperations.ChangeProductQuantity:
                            _sellerService.ChangeProductQuantity();
                            break;
                        case SellerOperations.Delete:
                            _sellerService.DeleteProduct();
                            break;
                        case SellerOperations.SeeWhoPurchased:
                            _sellerService.SeeWhoPurchasedProduct();
                            break;
                        case SellerOperations.SeeProductForDate:
                            _sellerService.SeePurchasedProductForDate();
                            break;
                        case SellerOperations.Filter:
                            _sellerService.FilterForName();
                            break;
                        case SellerOperations.SeeIncome:
                            _sellerService.SeeTotalIncome();
                            break;
                        case SellerOperations.GetAllProducts:
                            _sellerService.GetProducts();
                            break;
                        case SellerOperations.Exit:
                            MainMenu();
                            break;
                        default:
                            Messages.InvalidInputMessage("choice");
                            break;
                    }

                }


            }

        }
        else
        {
            MainMenu();
        }


    }
    public static void ShowCustomerMenu()
    {
        if (_customerService.CustomerLogin())
        {
            while (true)
            {
                Console.WriteLine(" ");
                Console.WriteLine("--Menu--");
                Console.WriteLine("1.Buy Product");
                Console.WriteLine("2.See Purchased Products");
                Console.WriteLine("3.See Purchased Products By Date");
                Console.WriteLine("4.Filter");
                Console.WriteLine("0.Exit");
                Console.WriteLine(" ");
                Console.WriteLine("Choose From Menu");

                string input = Console.ReadLine();
                int choice;
                bool isSucceeded = int.TryParse(input, out choice);
                if (isSucceeded)
                {
                    switch ((CustomerOperations)choice)
                    {
                        case CustomerOperations.Buy:
                            _customerService.BuyProduct();
                            break;
                        case CustomerOperations.SeePurchasedProducts:
                            _customerService.SeePurchasedProducts();
                            break;
                        case CustomerOperations.SeePurchasedProductsByDate:
                            _customerService.SeePurchasedProductsByDate();
                            break;
                        case CustomerOperations.Filter:
                            _customerService.Filter();
                            break;
                        case CustomerOperations.Exit:
                            MainMenu();
                            break;
                        default:
                            Messages.InvalidInputMessage("choice");
                            break;
                    }

                }


            }

        }
        else
        {
            MainMenu();
        }


    }
}