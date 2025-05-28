using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace KriptoFinalOdevi.Controllers
{
    public class DecryptController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string encryptedBase64, string privateKeyBase64)
        {
            if (string.IsNullOrWhiteSpace(encryptedBase64) || string.IsNullOrWhiteSpace(privateKeyBase64))
            {
                ViewBag.DecryptedText = "⚠️ Şifreli metin ve private key boş olamaz.";
                return View();
            }

            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedBase64);
                byte[] privateKeyBytes = Convert.FromBase64String(privateKeyBase64);

                using var rsa = RSA.Create();
                rsa.ImportPkcs8PrivateKey(privateKeyBytes, out _);

                byte[] decryptedBytes = rsa.Decrypt(encryptedBytes, RSAEncryptionPadding.Pkcs1);
                string decryptedText = Encoding.UTF8.GetString(decryptedBytes);

                ViewBag.DecryptedText = decryptedText;
            }
            catch (Exception ex)
            {
                ViewBag.DecryptedText = "❌ Şifre çözme başarısız: " + ex.Message;
            }

            return View();
        }
    }
}
