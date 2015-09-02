using Infrastructure.Key;
namespace Infrastructure.Session
{
    public abstract class Session
    {
        public UniqueKey Key { get; set; } 
    }
}