using System.Collections.Generic;

namespace INF36207.TP2.PassGen
{
    public class PasswordDictionaryGenerator
    {
        public IEnumerable<string> Generate(string characterList, int min, int max)
        {
            for (int length = min; length <= max; length++)
            {
                foreach (string password in GeneratePasswords(characterList, length))
                {
                    yield return password;
                }
            }
        }

        private IEnumerable<string> GeneratePasswords(string characterList, int length)
        {
            if (length == 0)
            {
                yield return "";
            }
            else
            {
                foreach (char c in characterList)
                {
                    foreach (string suffix in GeneratePasswords(characterList, length - 1))
                    {
                        yield return c + suffix;
                    }
                }
            }
        }
    }

}