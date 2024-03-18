using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Software Development Environments");
            Console.WriteLine("b. Virtualization Technologies");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "a")
            {
                goto SoftwareDevelopmentEnvironments;
            }
            else if (userChoice == "b")
            {
                goto VirtualizationTechnologies;
            }
            else if (userChoice == "c")
            {
                exit = true;
                goto End;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }

            Console.WriteLine();
        }

    SoftwareDevelopmentEnvironments:
        Console.WriteLine("Software Development Environments");
        Console.WriteLine("a. Integrated Development Environments (IDEs)");
        Console.WriteLine("b. Text Editors");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto IntegratedDevelopmentEnvironments;
        }
        else if (userChoice == "b")
        {
            goto TextEditors;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto SoftwareDevelopmentEnvironments;
        }

    IntegratedDevelopmentEnvironments:
        Console.WriteLine("Integrated Development Environments (IDEs)");
        Console.WriteLine("a. Visual Studio");
        Console.WriteLine("b. IntelliJ IDEA");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Visual Studio");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("IntelliJ IDEA");
        }
        else if (userChoice == "c")
        {
            goto SoftwareDevelopmentEnvironments;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto IntegratedDevelopmentEnvironments;
        }
        Console.WriteLine();
        goto IntegratedDevelopmentEnvironments;

    TextEditors:
        Console.WriteLine("Text Editors");
        Console.WriteLine("a. Sublime Text");
        Console.WriteLine("b. VS Code");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Sublime Text");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("VS Code");
        }
        else if (userChoice == "c")
        {
            goto SoftwareDevelopmentEnvironments;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto TextEditors;
        }
        Console.WriteLine();
        goto TextEditors;

    VirtualizationTechnologies:
        Console.WriteLine("Virtualization Technologies");
        Console.WriteLine("a. Hypervisor Types");
        Console.WriteLine("b. Containerization");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            goto HypervisorTypes;
        }
        else if (userChoice == "b")
        {
            goto Containerization;
        }
        else if (userChoice == "c")
        {
            goto Home;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto VirtualizationTechnologies;
        }

    HypervisorTypes:
        Console.WriteLine("Hypervisor Types");
        Console.WriteLine("a. Type 1 (Bare Metal)");
        Console.WriteLine("b. Type 2 (Hosted)");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Type 1 (Bare Metal)");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Type 2 (Hosted)");
        }
        else if (userChoice == "c")
        {
            goto VirtualizationTechnologies;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto HypervisorTypes;
        }
        Console.WriteLine();
        goto HypervisorTypes;

    Containerization:
        Console.WriteLine("Containerization");
        Console.WriteLine("a. Docker");
        Console.WriteLine("b. Kubernetes");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
        {
            Console.WriteLine("Docker");
        }
        else if (userChoice == "b")
        {
            Console.WriteLine("Kubernetes");
        }
        else if (userChoice == "c")
        {
            goto VirtualizationTechnologies;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Containerization;
        }
        Console.WriteLine();
        goto Containerization;

    End:
        Console.WriteLine("Closing the program...");
    }
}