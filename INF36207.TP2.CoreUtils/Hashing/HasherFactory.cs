using INF36207.TP2.Enums;
using INF36207.TP2.Exceptions;
using INF36207.TP2.Hashing.Strategies;

namespace INF36207.TP2.Hashing
{
    public class HasherFactory : IHasherFactory
    {
        private IHasher _hasher;

        public IHasher GetHasher(HashingStrategies strategy)
        {
            switch (strategy)
            {
                case HashingStrategies.Md5:
                    _hasher = new Md5Hasher();
                    break;
                default:
                    throw new HashingStrategyNotFoundException($"Hashing strategy: {strategy} does not exist.");
            }

            return _hasher;
        }
    }
}