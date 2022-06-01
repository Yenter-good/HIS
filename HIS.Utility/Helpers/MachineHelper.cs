using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace HIS.Utility
{
    /// <summary>
    /// MachineInfo
    /// 获取硬件信息的部分
    /// 
    /// 修改记录

    /// </summary>
    public class MachineHelper
    {
        /// <summary>
        /// 机器名
        /// </summary>
        public static string HostName
        {
            get { return Dns.GetHostName(); }
        }
        /// <summary>
        /// 获取当前使用的IPV4地址
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddress()
        {
            string ipAddress = string.Empty;
            try
            {
                //System.Net.IPHostEntry ipHostEntrys = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
                List<string> ipList = GetIPAddressList();
                foreach (string ip in ipList)
                {
                    ipAddress = ip.ToString();
                    break;

                }
            }
            catch { }
            return ipAddress;
        }

        /// <summary>
        /// 获取IPv4地址列表
        /// </summary>
        /// <returns></returns>
        public static List<string> GetIPAddressList()
        {
            List<string> ipAddressList = new List<string>();
            try
            {
                IPHostEntry ipHostEntrys = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
                foreach (IPAddress ip in ipHostEntrys.AddressList)
                {
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        ipAddressList.Add(ip.ToString());
                    }
                }
            }
            catch { }
            return ipAddressList;
        }

        /// <summary>
        /// GetWirelessIPList 获得无线网络接口的IpV4 地址列表
        /// </summary>
        /// <returns></returns>
        public static List<string> GetWirelessIPAddressList()
        {
            List<string> ipAddressList = new List<string>();
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in networkInterfaces)
            {
                if (ni.Description.Contains("Wireless"))
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            ipAddressList.Add(ip.Address.ToString());

                        }
                    }
                }
            }
            return ipAddressList;
        }

        /// <summary>
        /// 获取地址
        /// </summary>
        /// <returns>地址</returns>
        public static string GetMacAddress()
        {
            string macAddress = string.Empty;
            List<string> macAddressList = GetMacAddressList();

            foreach (string mac in macAddressList)
            {
                if (!string.IsNullOrEmpty(mac))
                {
                    macAddress = mac.ToString();
                    //格式化
                    macAddress = string.Format("{0}-{1}-{2}-{3}-{4}-{5}",
                        macAddress.Substring(0, 2),
                        macAddress.Substring(2, 2),
                        macAddress.Substring(4, 2),
                        macAddress.Substring(6, 2),
                        macAddress.Substring(8, 2),
                        macAddress.Substring(10, 2));
                    break;
                }
            }
            return macAddress;
        }

        /// <summary>
        /// 获取MAC地址列表，注意优先级高的放在了后面
        /// </summary>
        /// <returns></returns>
        public static List<string> GetMacAddressList()
        {
            List<string> macAddressList = new List<string>();
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in networkInterfaces)
            {
                //网卡描述中有wireless，则判断是无限网卡,过滤掉虚拟网卡和移动网卡

                if (!ni.Description.Contains("WiFi") && !ni.Description.Contains("Loopback") && !ni.Description.Contains("VMware") && ni.OperationalStatus == OperationalStatus.Up)
                {
                    macAddressList.Add(ni.GetPhysicalAddress().ToString());
                }
            }
            return macAddressList;
        }

        /// <summary>
        /// GetWirelessMacList 获得无线网络接口的MAC地址列表
        /// </summary>
        /// <returns></returns>
        public static List<string> GetWirelessMacAddressList()
        {
            List<string> macAddressList = new List<string>();
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in networkInterfaces)
            {
                //网卡描述中有wireless，则判断是无限 网卡

                if (ni.Description.Contains("Wireless") && ni.OperationalStatus == OperationalStatus.Up)
                {
                    macAddressList.Add(ni.GetPhysicalAddress().ToString());
                }
            }
            return macAddressList;
        }

        public static string GetCPUSerialNo()
        {
            string cpuSerialNo = string.Empty;
            ManagementClass managementClass = new ManagementClass("Win32_Processor");
            ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                // 可能是有多个
                cpuSerialNo = managementObject.Properties["ProcessorId"].Value.ToString();
                break;
            }
            return cpuSerialNo;
        }

        public static string GetHardDiskInfo()
        {
            string hardDisk = string.Empty;
            ManagementClass managementClass = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection managementObjectCollection = managementClass.GetInstances();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                // 可能是有多个
                hardDisk = (string)managementObject.Properties["Model"].Value;
                break;
            }
            return hardDisk;
        }
        /// <summary>  
        // 获取指定驱动器的空间总大小(单位为GB)  
        /// </summary>  
        /// <param name="str_HardDiskName">只需输入代表驱动器的字母即可 </param>  
        /// <returns> </returns>  
        public static long GetHardDiskSpace(string str_HardDiskName)
        {
            long totalSize = new long();
            str_HardDiskName = str_HardDiskName + ":\\";
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    totalSize = drive.TotalSize / (1024 * 1024 * 1024);
                }
            }
            return totalSize;
        }

        /// <summary>  
        /// 获取指定驱动器的剩余空间总大小
        /// </summary>  
        /// <param name="str_HardDiskName">只需输入代表驱动器的字母即可 </param>  
        /// <param name="unit">容量单位 </param>  
        /// <returns> </returns>  
        public static long GetHardDiskFreeSpace(string str_HardDiskName, VolumeUnit unit)
        {
            long freeSpace = new long();
            str_HardDiskName = str_HardDiskName + ":\\";
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            long baseCount = 1024 * 1024 * 1024;
            switch (unit)
            {
                case VolumeUnit.KB:
                    baseCount = 1024;
                    break;
                case VolumeUnit.MB:
                    baseCount = 1024 * 1024;
                    break;
                case VolumeUnit.GB:
                    baseCount = 1024 * 1024 * 1024;
                    break;
                default:
                    break;
            }
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == str_HardDiskName)
                {
                    freeSpace = drive.TotalFreeSpace / baseCount;
                }
            }
            return freeSpace;
        }
    }
    /// <summary>
    /// 容量单位
    /// </summary>
    public enum VolumeUnit
    {
        KB
            ,
        MB
            ,
        GB
    }
}
