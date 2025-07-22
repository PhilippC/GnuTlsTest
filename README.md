# This project demonstrates issues with using GnuTLS on Android

If you build and run the application, tap the text on the main activity.

On LogCat, you will see something like

```
[monodroid-assembly] open_from_bundles: failed to load assembly System.Net.NameResolution.dll
Loaded assembly: /data/data/keepass2android.gnutlstest/files/.__override__/System.Net.NameResolution.dll [External]
[monodroid-assembly] open_from_bundles: failed to load assembly System.Diagnostics.DiagnosticSource.dll
Loaded assembly: /data/data/keepass2android.gnutlstest/files/.__override__/System.Diagnostics.DiagnosticSource.dll [External]
[monodroid-assembly] open_from_bundles: failed to load assembly System.Security.Cryptography.X509Certificates.dll
Loaded assembly: /data/data/keepass2android.gnutlstest/files/.__override__/System.Security.Cryptography.X509Certificates.dll [External]
[monodroid-assembly] Shared library 'libdl.so.2' not loaded, p/invoke 'dlerror' may fail
[monodroid-assembly] Shared library 'libdl.so.2' not loaded, p/invoke 'dlopen' may fail
[monodroid-assembly] Shared library 'Kernel32.dll' not loaded, p/invoke 'SetErrorMode' may fail
[monodroid-assembly] Shared library 'Kernel32.dll' not loaded, p/invoke 'GetLastError' may fail
[monodroid-assembly] Shared library 'Kernel32.dll' not loaded, p/invoke 'LoadLibrary' may fail
[monodroid-assembly] Shared library 'Kernel32.dll' not loaded, p/invoke 'FormatMessage' may fail
[monodroid-assembly] Shared library 'libdl.so.2' not loaded, p/invoke 'dlerror' may fail
[GnuTlsTest] FluentFTP.GnuTLS.GnuTlsException: GnuTLS .dll load/call validation error
[GnuTlsTest]  ---> System.DllNotFoundException: libdl.so.2
[GnuTlsTest]    at FluentFTP.GnuTLS.Core.GnuTls.FunctionLoader.Load(String dllPath, Boolean storePointer)
[GnuTlsTest]    at FluentFTP.GnuTLS.Core.GnuTls.LoadAllFunctions()
[GnuTlsTest]    at FluentFTP.GnuTLS.Core.GnuTls.GnuTlsCheckVersion(String reqVersion)
[GnuTlsTest]    at FluentFTP.GnuTLS.GnuTlsInternalStream.Validate(Boolean log)
[GnuTlsTest]    --- End of inner exception stack trace ---
[GnuTlsTest]    at FluentFTP.GnuTLS.GnuTlsInternalStream.Validate(Boolean log)
[GnuTlsTest]    at FluentFTP.GnuTLS.GnuTlsInternalStream..ctor(String targetHostString, Socket socketDescriptor, CustomRemoteCertificateValidationCallback customRemoteCertificateValidation, X509CertificateCollection clientCertificates, String alpnString, GnuTlsInternalStream streamToResumeFrom, String priorityString, String loadLibraryDllNamePrefix, Int32 handshakeTimeout, Int32 commTimeout, Int32 pollTimeout, GnuStreamLogCBFunc elog, Int32 logMaxLevel, GnuMessage logDebugInformationMessages, Int32 logQueueMaxSize)
[GnuTlsTest]    at FluentFTP.GnuTLS.GnuTlsStream.Init(BaseFtpClient client, String targetHost, Socket socket, CustomRemoteCertificateValidationCallback customRemoteCertificateValidation, Boolean isControl, IFtpStream controlConnStream, IFtpStreamConfig untypedConfig)
[GnuTlsTest]    at FluentFTP.FtpSocketStream.CreateCustomStream(String targetHost)
[GnuTlsTest]    at FluentFTP.FtpSocketStream.ActivateEncryption(String targetHost, X509CertificateCollection clientCerts, SslProtocols sslProtocols)
[GnuTlsTest]    at FluentFTP.FtpClient.Connect(Boolean reConnect)
[GnuTlsTest]    at FluentFTP.FtpClient.Connect()
[GnuTlsTest]    at GnuTlsTestLib.FtpTester.RunTest() in C:\Users\phili\source\repos\GnuTlsTest\GnuTlsTestLib\FtpTester.cs:line 29 
```
