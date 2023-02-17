using System.Security.Cryptography;
using System.Text;

namespace INF36207.TP2.Hashing.Strategies;

/*
 * Tout le crédit de l'algorithme utilisé pour la génération du Hash MD5 doit être porté
 * au compte de l'utilisateur turgay, 13 juillet 2021,
 * Repéré à https://csharpexamples.com/c-create-md5-hash-string/
 */

public class Md5Hasher : IHasher
{
    public string ComputeHash(string input)
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        byte[] hashBytes = ComputeHashBytesFrom(input);
        return ToString(hashBytes);
    }

    private static byte[] ComputeHashBytesFrom(string input)
    {
        MD5 md5 = MD5.Create();
        byte[] inputBytes = Encoding.UTF8.GetBytes(input.Normalize(NormalizationForm.FormKC));
        return md5.ComputeHash(inputBytes);
    }

    private static string ToString(byte[] hashBytes)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in hashBytes)
        {
            sb.Append(b.ToString("X2"));
        }
        return sb.ToString();
    }
}