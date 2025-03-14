namespace BuberDinner.Application.Services.Authentication;

using System;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Simulate user registration logic
        var userId = Guid.NewGuid();
        var token = GenerateToken(userId, email);

        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token
        );
    }

    public AuthenticationResult Login(string email, string password)
    {
        // Simulate user login logic
        var userId = Guid.NewGuid(); // Replace with actual user lookup
        var firstName = "Radosław"; // Replace with actual user data
        var lastName = "Grzanka";   // Replace with actual user data
        var token = GenerateToken(userId, email);

        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token
        );
    }

    private string GenerateToken(Guid userId, string email)
    {
        // Simulate token generation
        return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }
}