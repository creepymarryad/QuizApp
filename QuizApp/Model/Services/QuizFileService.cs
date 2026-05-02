using Model.Entities;
using Model.Interfaces;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Model.Services
{
    public class QuizFileService : IQuizFileService
    {
        public byte[] GetKey(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public void Save(string filePath, string password, QuizData quiz)
        {
            string json = JsonSerializer.Serialize(quiz);
            byte[] plainBytes = Encoding.UTF8.GetBytes(json);
            using (Aes aes = Aes.Create())
            {
                aes.Key = GetKey(password);
                aes.GenerateIV();
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    fs.Write(aes.IV, 0, aes.IV.Length);
                    using (CryptoStream cs = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                    }
                }
            }
        }
        public QuizData Load(string filePath, string password)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = GetKey(password);
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    byte[] iv = new byte[16];
                    fs.ReadExactly(iv, 0, iv.Length);
                    aes.IV = iv;
                    using (CryptoStream cs = new CryptoStream(fs, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    using (MemoryStream ms = new MemoryStream())
                    {
                        cs.CopyTo(ms);
                        string json = Encoding.UTF8.GetString(ms.ToArray());
                        return JsonSerializer.Deserialize<QuizData>(json)!;
                    }
                }
            }
        }
    }
}
