namespace Uspeak.Persistence
{
    public interface IContextFactory
    {
        IUspeakDbContext Create();
    }
}
