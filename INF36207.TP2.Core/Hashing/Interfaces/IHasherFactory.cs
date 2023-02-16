using INF36207.TP2.Enums;

namespace INF36207.TP2.Hashing;

public interface IHasherFactory
{
    IHasher GetHasher(HashingStrategies strategy);
}