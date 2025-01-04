

namespace ConsoleApp1.Models;

internal class Passenger
{
    public int Id { get; set; }
    public string PersonalNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public decimal Score { get; set; }
        public string Email { get; set; }

    public Passenger(string personalNumber, string firstName, string lastName, int age, decimal score, string email)
    {
        PersonalNumber = personalNumber;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Score = score;
        Email = email;
    }
}
//personalNumber	firstName	lastName	age	scores	email
