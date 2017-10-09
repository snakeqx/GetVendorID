using System.Management;
using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;
namespace GetVendorID
{
    class ID
    {
        public string Nothing = "没有找到HWID，确定插入了么？";
        public string NotOK = "找到了设备，但是里面的数据似乎有问题！";
        public string getVendorId()
        {
            var usbDevices = GetUSBDevices();
            string result = Nothing;
            foreach (var usbDevice in usbDevices)
            {
                string id = getID(usbDevice.DeviceID);
                if (id == Nothing) continue;
                else if (id == NotOK) continue;
                else result = id;
            }
            return result;
        }

        public string getID(string usbDeviceID)
        {
            String pattern = @"^(USB\\)(VID_05E3&PID_0749)\\([0-9]*)";
        if (!Regex.IsMatch(usbDeviceID, pattern)) return Nothing;
            foreach (Match m in Regex.Matches(usbDeviceID, pattern))
            {
                string VidPid = m.Groups[2].Value;
                string Id = m.Groups[3].Value;
                return Id;
            }
            return NotOK;
        }

        public List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();
            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Name")
                ));
            }
            collection.Dispose();
            return devices;
        }
    }
}