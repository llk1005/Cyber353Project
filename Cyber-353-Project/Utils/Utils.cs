using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Globalization;
using nClam;
using System.IO;
using System.Globalization;

namespace Cyber_353_Project
{
    static class Utils
    {
        public static string sha256_hash(string password)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(password));

                foreach (Byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }
            }
            return sb.ToString();
        }

        public static async Task<bool> scan_FileAsync(string fileName, string logName)
        {
            ClamClient clam = new ClamClient("localhost", 3310);

            var scanResult = await clam.ScanFileOnServerAsync(fileName);

            DateTime localTime = DateTime.Now;

            switch (scanResult.Result)
            {
                case ClamScanResults.Clean:
                    Console.WriteLine("The file is clean!");
                    writeToLog(logName, "Scanned: " + fileName + "\nNo Virus Found" + " " + localTime);
                    break;
                case ClamScanResults.VirusDetected:
                    Console.WriteLine("Virus Found!");
                    Console.WriteLine("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                    writeToLog(logName, "Virus found at: " + fileName + "\nVirus name: " + scanResult.InfectedFiles.First().VirusName);
                    NotificationHandler.SendFullNotification("Virus has been detected: \n\n\nVirus name: " + scanResult.InfectedFiles.First().VirusName + "\n\n\nDirectory: " + fileName + " " + localTime);
                    return false;
                case ClamScanResults.Error:
                    Console.WriteLine("Woah an error occured! Error: {0}", scanResult.RawResult);
                    writeToLog(logName, "Error scanning: " + fileName + "\nError: " + scanResult.RawResult + " " + localTime);
                    break;
            }

            return true;
        }

<<<<<<< Updated upstream
        public static Boolean LoginAttemptRecord(string username)
        {
            string hostname = Dns.GetHostName();
            string ip = Dns.GetHostEntry(hostname).AddressList[0].ToString();

            DateTime logTime = DateTime.Now;
            StreamWriter loginAttemptLog = File.AppendText("loginattempts.txt");

            loginAttemptLog.WriteLine("Login by user " + username + " attempted from IP " + ip);
            loginAttemptLog.Close();
            return true;
            
=======
        public static void writeToLog(string fileName, string message)
        {
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine(message);
            sw.Close();
>>>>>>> Stashed changes
        }

        public static Boolean RdpAttemptRecord(string username, string destIP)
        {
            string hostname = Dns.GetHostName();
            string sourceIP = Dns.GetHostEntry(hostname).AddressList[0].ToString();


            StreamWriter rdpConnectLog = File.AppendText("rdpattempts.txt");

            rdpConnectLog.WriteLine("Connection to user " + username + " at IP " + destIP + " attempted by source IP " + sourceIP);
            return true;
        }
    }
}
