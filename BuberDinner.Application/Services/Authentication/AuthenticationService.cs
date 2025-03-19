namespace BuberDinner.Application.Services.Authentication;

using System;
using BuberDinner.Application.Common.Interfaces.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Simulate user registration logic
        var userId = Guid.NewGuid();
        var token = GenerateToken(userId, firstName, lastName);

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
        string token = null; // TODO(radekg): Implement token generation

        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token
        );
    }

    private string GenerateToken(Guid userId, string firstName, string lastName)
    {
        // Simulate token generation
        return _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
    }
}