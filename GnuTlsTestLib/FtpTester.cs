using Android.Util;
using FluentFTP.GnuTLS;
using FluentFTP;
using System.Net;

namespace GnuTlsTestLib
{
    public class FtpTester
    {
        public void RunTest()
        {
            try
            {
                Log.Debug("GnuTlsTest", "Starting");

                FtpClient client = new FtpClient();
                client.Config.CustomStream = typeof(GnuTlsStream);
                client.Config.RetryAttempts = 3;
                client.Config.EncryptionMode = FtpEncryptionMode.Explicit;

                const string username = "demo";
                const string password = "password";
                const string host = "test.rebex.net";


                client.Credentials = new NetworkCredential(username, password);
                client.Host = host;
                Log.Debug("GnuTlsTest", "Connecting");
                client.Connect();
                Log.Debug("GnuTlsTest", "Connected");

                using (var stream = client.OpenWrite("testupdload24g81x8.xyz"))
                {
                    Log.Debug("GnuTlsTest", "File opened");
                    stream.WriteByte(0x01);
                    stream.Close();
                }
                Log.Debug("GnuTlsTest", "File closed");
            }
            catch (Exception e)
            {
                Log.Debug("GnuTlsTest", e.ToString());
            }
        }
    }
}