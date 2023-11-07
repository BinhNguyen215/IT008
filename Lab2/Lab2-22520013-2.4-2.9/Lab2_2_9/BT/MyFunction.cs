using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    internal class MyFunction
    {
        public static string key = "MySecretKey12345";
        public static  string iv = "InitializationVe";
        //mở tệp 
        public static string Encrypt(string plainText, string key, string iv)
        {
            try
            {

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(key);
                    aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi");
            }
            return null;
        }

    /*    public static string Decrypt(string cipherText, string key, string iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = Encoding.UTF8.GetBytes(iv);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }*/

        public static void SaveAccountInfo(string encryptedUsername, string encryptedPassword, string fileName)
        {
            // Tạo một chuỗi dạng "username:encryptedPassword"
            string accountInfo = $"{encryptedUsername}:{encryptedPassword}\n";
            try
            {
                // Lưu thông tin vào tệp user.txt
                File.AppendAllText(fileName, accountInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi ghi tep" + ex.ToString());
            }
        }

        public static bool check_login(string username,string password, string fileName)
        {
            // Đọc toàn bộ nội dung từ tệp user.txt
            string fileContent = File.ReadAllText(fileName);
            string[] accountLines = fileContent.Split('\n');
            // Tách thông tin tài khoản dựa trên dấu hai chấm (:)

            // Tìm tên người dùng và trả về mật khẩu đã mã hóa
            foreach (string accountLine in accountLines)
            {
                 string[] accountData = accountLine.Split(':');
                if (accountData.Length == 2 && accountData[0] == Encrypt(username,key,iv))
                {
                    if (accountData[1] == Encrypt(password, key, iv)) return true;
                }

            }
            return false; // Trả về 0 nếu không tìm thấy thông tin tài khoản
        }
        public static void CreFile(string filepath,string content)
        {
            try
            {
                using (FileStream fs=File.Create(filepath)) {
                    byte[] contentBytes = System.Text.Encoding.UTF8.GetBytes(content);
                    fs.Write(contentBytes, 0, contentBytes.Length);
                }
                MessageBox.Show("Tạo tệp thành công!");

            }
            catch (Exception ex){
                MessageBox.Show("Tạo tệp thất bại!");

            }
        }
    }
}

