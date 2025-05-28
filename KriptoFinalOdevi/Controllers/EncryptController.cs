using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace KriptoFinalOdevi.Controllers
{
    public class EncryptController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string publicKeyBase64, string inputText)
        {
            if (string.IsNullOrWhiteSpace(publicKeyBase64))
            {
                ViewBag.EncryptedText = "⚠️ Lütfen geçerli bir public key girin.";
                return View();
            }

            if (string.IsNullOrWhiteSpace(inputText))
            {
                ViewBag.EncryptedText = "⚠️ Şifrelenecek metin boş olamaz.";
                return View();
            }

            try
            {
                // Public anahtarı Base64'ten byte dizisine çevir
                byte[] publicKeyBytes = Convert.FromBase64String(publicKeyBase64);

                using var rsa = RSA.Create();
                rsa.ImportSubjectPublicKeyInfo(publicKeyBytes, out _);

                byte[] plainBytes = Encoding.UTF8.GetBytes(inputText);
                byte[] encryptedBytes = rsa.Encrypt(plainBytes, RSAEncryptionPadding.Pkcs1);
                string encryptedBase64 = Convert.ToBase64String(encryptedBytes);

                ViewBag.EncryptedText = encryptedBase64;
            }
            catch (Exception ex)
            {
                ViewBag.EncryptedText = "❌ Şifreleme başarısız: " + ex.Message;
            }

            return View();
        }
    }
}
