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
using System.Net.NetworkInformation;

namespace Cyber_353_Project
{
    static class Utils
    {
        public static string SHA256_hash(string password)
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

        public static bool NetworkAnalysis()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())  // if no network is connected, then exit
            {
                return false;
            }
            DateTime scanTime = DateTime.Now;
            string filename = "networkLog" + scanTime.ToString("yyyyMMddhhmmss") + ".txt";

            StreamWriter NetworkLog = File.AppendText(filename);

            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface ni in interfaces)
            {
                NetworkLog.WriteLine(" Bytes Sent: {0}", ni.GetIPv4Statistics().BytesSent); // TODO: Figure out how to log the IP address in the file
                NetworkLog.WriteLine(" Bytes Received: {0}", ni.GetIPv4Statistics().BytesReceived);
            }

            NetworkLog.Close();
            return true;
        }

        public static async Task<bool> Scan_FileAsync(string fileName, string logName)
        {
            ClamClient clam = new ClamClient("localhost", 3310);

            var scanResult = await clam.ScanFileOnServerAsync(fileName);

            DateTime localTime = DateTime.Now;

            switch (scanResult.Result)
            {
                case ClamScanResults.Clean:
                    Console.WriteLine("The file is clean!");
                    WriteToLog(logName, "Scanned: " + fileName + "\nNo Virus Found" + " " + localTime);
                    break;
                case ClamScanResults.VirusDetected:
                    Console.WriteLine("Virus Found!");
                    Console.WriteLine("Virus name: {0}", scanResult.InfectedFiles.First().VirusName);
                    WriteToLog(logName, "Virus found at: " + fileName + "\nVirus name: " + scanResult.InfectedFiles.First().VirusName);
                    NotificationHandler.SendFullNotification("Virus has been detected: \n\n\nVirus name: " + scanResult.InfectedFiles.First().VirusName + "\n\n\nDirectory: " + fileName + " " + localTime);
                    return false;
                case ClamScanResults.Error:
                    Console.WriteLine("Woah an error occured! Error: {0}", scanResult.RawResult);
                    WriteToLog(logName, "Error scanning: " + fileName + "\nError: " + scanResult.RawResult + " " + localTime);
                    break;
            }

            return true;
        }

        public static bool LoginAttemptRecord(string username)
        {
            string hostname = Dns.GetHostName();
            string ip = Dns.GetHostEntry(hostname).AddressList[0].ToString();
            // currently records IPv6, but future plan is to return IPv4

            DateTime logTime = DateTime.Now;
            string filename = "loginattempt" + logTime.ToString("yyyyMMddhhmmss") + ".txt";
            StreamWriter loginAttemptLog = File.AppendText(filename);

            loginAttemptLog.WriteLine("Login by user " + username + " attempted from IP " + ip);
            loginAttemptLog.Close();
            return true;
        }
            
        public static void WriteToLog(string fileName, string message)
        {
            StreamWriter sw = File.AppendText(fileName);
            sw.WriteLine(message);
            sw.Close();
        }

        public static bool RdpAttemptRecord(string username, string destIP)
        {
            string hostname = Dns.GetHostName();
            string sourceIP = Dns.GetHostEntry(hostname).AddressList[0].ToString();
            DateTime logTime = DateTime.Now;

            string filename = "rdpattempt" + logTime.ToString("yyyyMMddhhmmss") + ".txt";

            StreamWriter rdpConnectLog = File.AppendText(filename);

            rdpConnectLog.WriteLine("Connection to user " + username + " at IP " + destIP + " attempted by source IP " + sourceIP);
            return true;
        }
    }
}
