using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Web;

namespace CloudApi.ToolHelper
{
    public class EncryptionHelp
    {
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="str"></param>
        /// <param name="iszip"></param>
        /// <returns></returns>
        public static string Encryption(string str, bool iszip)
        {
            if (iszip)
            {
                var compressBeforeByte = Encoding.GetEncoding("UTF-8").GetBytes(str);
                var compressAfterByte = Compress(compressBeforeByte);
                string compressString = Convert.ToBase64String(compressAfterByte);
                return compressString;
            }
            else
            {
                byte[] plaindata = Encoding.UTF8.GetBytes(str);//将要加密的字符串转换为字节数组
                return Convert.ToBase64String(plaindata);//将加密后的字节数组转换为字符串
            }

        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="str"></param>
        /// <param name="iszip"></param>
        /// <returns></returns>
        public static string Decrypt(string str, bool iszip)
        {
            if (iszip)
            {
                var compressBeforeByte = Convert.FromBase64String(str);
                var compressAfterByte = Decompress(compressBeforeByte);
                string compressString = Encoding.GetEncoding("UTF-8").GetString(compressAfterByte);
                return compressString;
            }
            else
            {
                byte[] encryptdata = Convert.FromBase64String(str);
                return Encoding.UTF8.GetString(encryptdata);
            }
        }

        /// <summary>
        /// Compress
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static byte[] Compress(byte[] data)
        {
            try
            {
                var ms = new MemoryStream();
                var zip = new GZipStream(ms, CompressionMode.Compress, true);
                zip.Write(data, 0, data.Length);
                zip.Close();
                var buffer = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(buffer, 0, buffer.Length);
                ms.Close();
                return buffer;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Decompress
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static byte[] Decompress(byte[] data)
        {
            try
            {
                var ms = new MemoryStream(data);
                var zip = new GZipStream(ms, CompressionMode.Decompress, true);
                var msreader = new MemoryStream();
                var buffer = new byte[0x1000];
                while (true)
                {
                    var reader = zip.Read(buffer, 0, buffer.Length);
                    if (reader <= 0)
                    {
                        break;
                    }
                    msreader.Write(buffer, 0, reader);
                }
                zip.Close();
                ms.Close();
                msreader.Position = 0;
                buffer = msreader.ToArray();
                msreader.Close();
                return buffer;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }





        ////加密
        //public static string Encryption(string express)
        //{
        //    byte[] plaindata = Encoding.UTF8.GetBytes(express);//将要加密的字符串转换为字节数组
        //    return Convert.ToBase64String(plaindata);//将加密后的字节数组转换为字符串
        //    //CspParameters param = new CspParameters();
        //    //param.KeyContainerName = "yicheng";//密匙容器的名称，保持加密解密一致才能解密成功
        //    //using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
        //    //{
        //    //    byte[] plaindata = Encoding.Default.GetBytes(express);//将要加密的字符串转换为字节数组
        //    //    byte[] encryptdata = rsa.Encrypt(plaindata, false);//将加密后的字节数据转换为新的加密字节数组
        //    //    return Convert.ToBase64String(encryptdata);//将加密后的字节数组转换为字符串
        //    //}
        //}

        ////解密
        //public static string Decrypt(string ciphertext)
        //{
        //    byte[] encryptdata = Convert.FromBase64String(ciphertext);
        //    return Encoding.UTF8.GetString(encryptdata);
        //    //CspParameters param = new CspParameters();
        //    //param.KeyContainerName = "yicheng";
        //    //using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
        //    //{
        //    //    byte[] encryptdata = Convert.FromBase64String(ciphertext);
        //    //    byte[] decryptdata = rsa.Decrypt(encryptdata, false);
        //    //    return Encoding.Default.GetString(decryptdata);
        //    //}
        //}

    }
}