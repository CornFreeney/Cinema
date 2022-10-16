using System;
using System.Text;

class Program {
static void Main(string[] args) {

// Variables
int Loop;
int age;
int choice;
string confirm = "";
string TicketType = "";
bool valid = false;
DateTime WatchDate;

// Movies
string movie1 = "Catch Me If You Can";
string movie2 = "Avengers: Infinity War";
string movie3 = "The Hangover Part III";
string movie4 = "The Shawshank Redemption";
string movie5 = "The Wolf of Wall Street";

// Age Rating
int movie1_age = 12;
int movie2_age = 12;
int movie3_age = 15;
int movie4_age = 15;
int movie5_age = 18;

// Tickets Sold
int movie2_tickets_sold = 0;
int movie3_tickets_sold = 0;
int movie4_tickets_sold = 0;
int movie5_tickets_sold = 0;
int movie1_tickets_sold = 0;


// Infinite Loop
do
{
  Loop = 1;
  choice = 0;
    do // Asks for a movie number until a valid number is entered.
    {
        try
        {
            Console.Clear();
            White();
            Console.WriteLine("Welcome to The Aquinas Cinema");
            Console.WriteLine();
            Console.WriteLine("Movies being shown currently:");
            Blue();
            Console.Write("1. ");
            Green();
            Console.Write("{0} ", movie1);
            White();
            Console.WriteLine("({0}) - Tickets Sold: {1}", movie1_age, movie1_tickets_sold);
            Blue();
            Console.Write("2. ");
            Green();
            Console.Write("{0} ", movie2);
            White();
            Console.WriteLine("({0}) - Tickets Sold: {1}", movie2_age, movie2_tickets_sold);
            Blue();
            Console.Write("3. ");
            Green();
            Console.Write("{0} ", movie3);
            White();
            Console.WriteLine("({0}) - Tickets Sold: {1}", movie3_age, movie3_tickets_sold);
            Blue();
            Console.Write("4. ");
            Green();
            Console.Write("{0} ", movie4);
            White();
            Console.WriteLine("({0}) - Tickets Sold: {1}", movie4_age, movie4_tickets_sold);
            Blue();
            Console.Write("5. ");
            Green();
            Console.Write("{0} ", movie5);
            White();
            Console.WriteLine("({0}) - Tickets Sold: {1}", movie5_age, movie5_tickets_sold);
            Console.WriteLine();
            Console.WriteLine("Other options:");
            Blue();
            Console.Write("6. ");
            Green();
            Console.WriteLine("Ticket Prices");
            Blue();
            Console.Write("????. ");
            Yellow();
            Console.WriteLine("Easter Egg");
            Console.WriteLine();
            Yellow();
            Console.WriteLine("(Hint: Try entering the year C# was developed)");
            Console.WriteLine();
            White();
            Console.Write("Please enter your number choice: ");
            choice = int.Parse(Console.ReadLine());
            valid = true;
        }
        catch
        {
            Console.Clear();
            Red();
            Console.WriteLine("Invalid Entry");
            White();
            Console.WriteLine("Only numbers can be entered.");
            Console.WriteLine();
            Blue();
            Console.Write("Press any key to go back to the homepage: ");
            Console.ReadKey();
            valid = false;
        }

    } while (valid == false);

  
    // Movie 1
    if (choice == 1)
    {
        age = 0;
        AgeCheck(ref age, valid, movie1, movie1_age); // Calls the AgeCheck method.
      
        if ((age < movie1_age) || (age > 122)) // If an age below the age rating or ridiculously high is entered.
        {
            InvalidAge(); // Calls the InvalidAge method.
        }
        else
        {         
            WatchDate = DateTime.Now;
            DateCheck(ref WatchDate, age, ref TicketType, valid); // Calls the DateCheck method.

            if ((WatchDate < DateTime.Now.AddDays(-1)) || (WatchDate > DateTime.Now.AddDays(7))) // If input is within a week.
            {
                InvalidDate(); // Calls the InvalidDate method.
            }
            else
            {
                Confirm(confirm, movie1, TicketType, WatchDate); // Calls the Confirm method.
                movie1_tickets_sold++; // Adds 1 to the tickets sold variable for that certain movie.
            }
        }
    }

  
    // Movie 2
    if (choice == 2)
    {
        age = 0;
        AgeCheck(ref age, valid, movie2, movie2_age);

        if ((age < movie2_age) || (age > 122))
        {
            InvalidAge();
        }
        else
        {
            WatchDate = DateTime.Now;
            DateCheck(ref WatchDate, age, ref TicketType, valid);

            if ((WatchDate < DateTime.Now.AddDays(-1)) || (WatchDate > DateTime.Now.AddDays(7)))
            {
                InvalidDate();
            }
            else
            {
                Confirm(confirm, movie2, TicketType, WatchDate);
                movie2_tickets_sold++;
            }
        }
    }

  
    // Movie 3
    if (choice == 3)
    {
        age = 0;
        AgeCheck(ref age, valid, movie3, movie3_age);

        if ((age < movie3_age) || (age > 122))
        {
            InvalidAge();
        }
        else
        {
            WatchDate = DateTime.Now;
            DateCheck(ref WatchDate, age, ref TicketType, valid);

            if ((WatchDate < DateTime.Now.AddDays(-1)) || (WatchDate > DateTime.Now.AddDays(7)))
            {
                InvalidDate();
            }
            else
            {
                Confirm(confirm, movie3, TicketType, WatchDate);
                movie3_tickets_sold++;
            }
        }
    }

  
    // Movie 4
    if (choice == 4)
    {
        age = 0;
        AgeCheck(ref age, valid, movie4, movie4_age);

        if ((age < movie4_age) || (age > 122))
        {
            InvalidAge();
        }
        else
        {
            WatchDate = DateTime.Now;
            DateCheck(ref WatchDate, age, ref TicketType, valid);

            if ((WatchDate < DateTime.Now.AddDays(-1)) || (WatchDate > DateTime.Now.AddDays(7)))
            {
                InvalidDate();
            }
            else
            {
                Confirm(confirm, movie4, TicketType, WatchDate);
                movie4_tickets_sold++;
            }
        }
    }

  
    // Movie 5
    if (choice == 5)
    {
        age = 0;
        AgeCheck(ref age, valid, movie5, movie5_age);

        if ((age < movie5_age) || (age > 122))
        {
            InvalidAge();
        }
        else
        {
            WatchDate = DateTime.Now;
            DateCheck(ref WatchDate, age, ref TicketType, valid);

            if ((WatchDate < DateTime.Now.AddDays(-1)) || (WatchDate > DateTime.Now.AddDays(7)))
            {
                InvalidDate();
            }
            else
            {
                Confirm(confirm, movie5, TicketType, WatchDate);
                movie5_tickets_sold++;
            }
        }
    }

  
    // Ticket Prices
    if (choice == 6)
    {
        Console.Clear();
        Green();
        Console.WriteLine("TICKET PRICES:");
        Console.WriteLine();
        White();
        Console.WriteLine("Standard = £9.50");
        Console.WriteLine("Child (Age 0-15) = £5.50");
        Console.WriteLine("Student (Age 16-18) = £7.50");
        Console.WriteLine("Senior (Age 65+) = £7.50");
        Console.WriteLine();
        Blue();
        Console.Write("Press any key to go back to the homepage: ");
        Console.ReadKey();
    }


    // Easter Egg
    if (choice == 2000)
    {
      Console.Clear();
      Yellow();
      Console.WriteLine("Congratulations, you found an easter egg!");
      Console.WriteLine();
      White();
      Console.WriteLine("C# was created in the year 2000 by Anders Hejlsberg, a Danish software engineer.");
      Console.WriteLine();
      Console.WriteLine("Click the Youtube link below to recieve your prize:");
      DarkBlue();
      Console.WriteLine("https://youtu.be/a3Z7zEc7AXQ");
      Console.WriteLine();
      Blue();
      Console.Write("Press any key to go back to the homepage: ");
      Console.ReadKey();
    }
  
  
    // No Existing Movie
    if ((choice != 6) && (choice != 2000) && ((choice > 5) || (choice < 1)))
    {
        Console.Clear();
        Red();
        Console.WriteLine("No Existing Movie");
        White();
        Console.WriteLine("Please enter a valid number.");
        Console.WriteLine();
        Blue();
        Console.Write("Press any key: ");
        Console.ReadKey();
    }
  
} while (Loop >= 0);


// Age Check
static void AgeCheck(ref int age, bool valid, string movie, int movie_age)
{
do // Asks for an age until a valid age is entered.
{
    try
    {
        Console.Clear();
        Green();
        Console.Write("{0} ", movie);
        White();
        Console.Write("is rated ");
        Green();
        Console.WriteLine("{0}", movie_age);
        Console.WriteLine();
        White();
        Console.Write("Please enter your age: ");
        age = int.Parse(Console.ReadLine());
        valid = true;
    }
    catch
    {
        Console.Clear();
        Red();
        Console.WriteLine("Invalid Entry");
        White();
        Console.WriteLine("Please enter a valid age.");
        Console.WriteLine();
        Blue();
        Console.Write("Press any key: ");
        Console.ReadKey();
        valid = false;
    }

} while (valid == false);
}


// Date Check
static void DateCheck(ref DateTime WatchDate, int age, ref string TicketType, bool valid)
{
do // Asks for a date until a valid date is entered.
{
    try
    {
        Console.Clear();
        TicketPricing(age, ref TicketType);
        Console.WriteLine();
        Console.Write("Please enter the date you would like to watch the movie: (");
        Green();
        Console.Write("MM/DD/YYYY");
        White();
        Console.WriteLine(")");
        WatchDate = DateTime.Parse(Console.ReadLine());
        valid = true;
    }
    catch
    {
        Console.Clear();
        Red();
        Console.WriteLine("Invalid Entry");
        White();
        Console.WriteLine("Please enter a valid date.");
        Console.WriteLine();
        Blue();
        Console.Write("Press any key: ");
        Console.ReadKey();
        valid = false;
    }

} while (valid == false);
}

  
// Ticket Pricing Method
static void TicketPricing(int age, ref string TicketType)
{
  if (age < 16)
  {
      Console.Clear();
      TicketType = "Child";
      Console.WriteLine("You qualify for a child discount: Ticket Price = £5.50");
  }
  else if ((age >= 16) && (age <= 18))
  {
      Console.Clear();
      TicketType = "Student";
      Console.WriteLine("You qualify for a student discount: Ticket Price = £7.50");
  }
  else if (age >= 65)
  {
      Console.Clear();
      TicketType = "Senior";
      Console.WriteLine("You qualify for a senior discount: Ticket Price = £7.50");
  }
  else
  {
      Console.Clear();
      TicketType = "Standard";
      Console.WriteLine("Ticket Price = £9.50");
  }
}


// Confirm Choice Method
static void Confirm(string confirm, string movie, string TicketType, DateTime WatchDate)
{
  do // Asks for Yes or No until the user enters it.
  {
    Console.Clear();
    Console.Write("Confirm that you like to book a ticket to watch ");
    Green();
    Console.Write("{0} ", movie);
    White();
    Console.Write("on ");
    Green();
    Console.Write("{0}/{1}/{2} ", WatchDate.Month, WatchDate.Day, WatchDate.Year);
    White();
    Console.Write("by entering ");
    Blue();
    Console.Write("Yes ");
    White();
    Console.Write("or ");
    Blue();
    Console.Write("No");
    White();
    Console.Write(": ");
    confirm = Console.ReadLine();
    confirm = confirm.ToUpper();
    
      if (confirm == "NO")
      {
          Console.Clear();
          Console.WriteLine("No worries at all :)");
          Console.WriteLine("We hope you come and watch our movies soon!");
          Console.WriteLine();
          Blue();
          Console.Write("Press any key to go back to the homepage: ");
          Console.ReadKey();
      }
      if (confirm == "YES")
      {
          Console.Clear();
          Console.WriteLine("Thank you for booking with us!");
          Console.WriteLine("Here is your ticket:");
          Console.WriteLine();
          Blue();
          Console.WriteLine("--------------------------------");
          White();
          Console.WriteLine("The Aquinas Cinema");
          Console.WriteLine();
          Console.Write("Movie: ");
          Green();
          Console.WriteLine(movie);
          White();
          Console.Write("Ticket: ");
          Green();
          Console.WriteLine(TicketType);
          White();
          Console.Write("Date: ");
          Green();
          Console.WriteLine("{0}/{1}/{2}", WatchDate.Month, WatchDate.Day, WatchDate.Year);
          Console.WriteLine();
          White();
          Console.WriteLine("We hope you enjoy the film!");
          Blue();
          Console.WriteLine("--------------------------------");
          Console.WriteLine();
          Console.Write("Press any key to go back to the homepage: ");
          Console.ReadKey();
      }
      if ((confirm != "YES") && (confirm != "NO"))
      {
          Console.Clear();
          Red();
          Console.WriteLine("Invalid Entry");
          White();
          Console.WriteLine("Please enter Yes or No.");
          Console.WriteLine();
          Blue();
          Console.Write("Press any key: ");
          Console.ReadKey();
      }
    
  } while ((confirm != "YES") && (confirm != "NO"));
}

  
// Invalid Age Method
static void InvalidAge()
{
    Console.Clear();
    Red();
    Console.WriteLine("Invalid Age");
    White();
    Console.WriteLine("You are either too young or have entered an invalid age.");
    Console.WriteLine();
    Blue();
    Console.Write("Press any key to go back to the homepage: ");
    Console.ReadKey();
}

  
// Invalid Date Method
static void InvalidDate()
{
    Console.Clear();
    Red();
    Console.WriteLine("Invalid Date");
    White();
    Console.WriteLine("You can only book tickets within a week from now.");
    Console.WriteLine();
    Blue();
    Console.Write("Press any key to go back to the homepage: ");
    Console.ReadKey();
}


// Sets Text Colour to White
static void White()
{
    Console.ForegroundColor = ConsoleColor.White;
}

// Sets Text Colour to Yellow
static void Yellow()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
}

// Sets Text Colour to Cyan
static void Blue()
{
    Console.ForegroundColor = ConsoleColor.Blue;
}

// Sets Text Colour to Dark Blue
static void DarkBlue()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
}

// Sets Text Colour to Red
static void Red()
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
}


// Sets Text Colour to Green
static void Green()
{
    Console.ForegroundColor = ConsoleColor.Green;
}
}
}