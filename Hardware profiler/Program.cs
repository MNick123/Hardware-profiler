using System;
using System.Management;




namespace Hardware_profiler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System Hardware Profiler");

            Console.WriteLine("\n\n");

            Parts("Win32_Processor", "Name");
            Parts("Win32_VideoController", "Name");
            Parts("Win32_DiskDrive", "Model");
            Parts("Win32_PhysicalMedia", "SerialNumber");

            Parts("Win32_BIOS", "Manufacturer");
            Parts("Win32_OperatingSystem", "Caption");

            Console.WriteLine("\n\n");
            Console.WriteLine("GPU");
            Parts("Win32_VideoController", "CurrentRefreshRate");
            Parts("Win32_VideoController", "DriverVersion");
            Parts("Win32_VideoController", "Name");
            Parts("Win32_VideoController", "VideoArchitecture");
            Parts("Win32_VideoController", "VideoMemoryType");


            Console.WriteLine("\n\n");
            Console.WriteLine("CPU");


            Parts("Win32_Processor", "Family");
            Parts("Win32_Processor", "Manufacturer");
            Parts("Win32_Processor", "MaxClockSpeed");
            Parts("Win32_Processor", "NumberOfCores");
            Parts("Win32_Processor", "NumberOfLogicalProcessors");
            Parts("Win32_Processor", "ProcessorId");
            Parts("Win32_Processor", "ProcessorType");
            Parts("Win32_Processor", "Version");
            Console.WriteLine("Current Voltage");
            Parts("Win32_Processor", "CurrentVoltage");

            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();
            

        }
        
        private static void Parts(string hwclass, string syntax)
        {
            ManagementObjectSearcher Var1 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject Counter in Var1.Get())
            {
                Console.WriteLine(Convert.ToString(Counter[ syntax ]));
            }


        }

        


    }
    


  




    

}
