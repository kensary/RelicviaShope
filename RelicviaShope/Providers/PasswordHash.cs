using System.Text;
using System.Security.Cryptography;

namespace RelicviaShope.Providers;

public static class PasswordHash
{
    public static string CreateSHA256(string password)
    {
        using var sha256 = SHA256.Create();
        byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

        var sb = new StringBuilder();

        for (int i = 0; i < bytes.Length; i++)
        {
            sb.Append(bytes[i].ToString("x2"));
        }

        return sb.ToString();

    }
}
