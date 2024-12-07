namespace BubberDinner.Application.Common.Interfaces.Authentication
{
    public interface ITokenService
    {
        string GenerateToken(Guid id, string firstName, string lastName);
    }
}
