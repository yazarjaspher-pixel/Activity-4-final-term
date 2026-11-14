using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_YAZAR
{
    internal class PasswordHelper
    {
        public static string HashPassword(string yazarPassword)
        {
            byte[] yazarSalt = new byte[16];
            using (RNGCryptoServiceProvider yazarRng = new RNGCryptoServiceProvider())
            {
                yazarRng.GetBytes(yazarSalt);
            }

            using (Rfc2898DeriveBytes yazarPbkdf2 = new Rfc2898DeriveBytes(yazarPassword, yazarSalt, 100000, HashAlgorithmName.SHA256))
            {
                byte[] yazarHash = yazarPbkdf2.GetBytes(32);
                return "PBKDF2$100000$" + Convert.ToBase64String(yazarSalt) + "$" + Convert.ToBase64String(yazarHash);
            }
        }

        public static bool VerifyPassword(string yazarPassword, string yazarStoredHash)
        {
            string[] yazarParts = yazarStoredHash.Split('$');
            if (yazarParts.Length != 4)
            {
                return false;
            }

            int yazarIterations = Convert.ToInt32(yazarParts[1]);
            byte[] yazarSalt = Convert.FromBase64String(yazarParts[2]);
            byte[] yazarSavedHash = Convert.FromBase64String(yazarParts[3]);

            using (Rfc2898DeriveBytes yazarPbkdf2 = new Rfc2898DeriveBytes(yazarPassword, yazarSalt, yazarIterations, HashAlgorithmName.SHA256))
            {
                byte[] yazarNewHash = yazarPbkdf2.GetBytes(yazarSavedHash.Length);

                for (int yazarI = 0; yazarI < yazarSavedHash.Length; yazarI++)
                {
                    if (yazarNewHash[yazarI] != yazarSavedHash[yazarI])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
