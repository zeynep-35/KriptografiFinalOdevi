using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace KriptoFinalOdevi.Controllers
{
    public class GenerateKeyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string action)
        {
            using var rsa = RSA.Create(2048); // 2048-bit RSA anahtar üretimi
            var privateKey = Convert.ToBase64String(rsa.ExportPkcs8PrivateKey());
            var publicKey = Convert.ToBase64String(rsa.ExportSubjectPublicKeyInfo());

            ViewBag.PublicKey = publicKey;
            ViewBag.PrivateKey = privateKey;

            return View();
        }
    }
}
