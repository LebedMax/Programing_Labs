using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    //Вариант 13, Задание 1
    public class Auto
    {
        public bool wheelAlignment = false;
        public bool painted = false;
        public bool oil = false;
        public bool techInspection = false;
        public bool wheelReplacement = false;
        public bool bodyRepair = false;
    }
    class Hospital
    {
        public static void MRT(Auto auto)
        {
            auto.wheelAlignment = true;
        }
        public static void Painted(Auto auto)
        {
            auto.painted = true;
        }
        public static void Oil(Auto auto)
        {
            auto.oil = true;
        }
        public static void TechInspection(Auto auto)
        {
            auto.techInspection = true;
        }
        public static void WheelReplacement(Auto auto)
        {
            auto.wheelReplacement = true;
        }
        public static void BodyRepair(Auto auto)
        {
            auto.bodyRepair = true;
        }
        public static void Info(Auto auto)
        {
            Console.WriteLine($"Wheel Alignment - {auto.wheelAlignment}");
            Console.WriteLine($"Painted - {auto.painted}");
            Console.WriteLine($"Oil - {auto.oil}");
            Console.WriteLine($"Technical Inspection - {auto.techInspection}");
            Console.WriteLine($"Wheel Replacement - {auto.wheelReplacement}");
            Console.WriteLine($"Body Repair - {auto.bodyRepair}");
        }
    }
    public delegate void CTODelegate(Auto auto);
    class Program
    {
        static void Main(string[] args)
        {
            Hospital cto = new Hospital();
            Auto auto = new Auto();

            CTODelegate wheelAlignment = new CTODelegate(Hospital.MRT);
            CTODelegate painted = new CTODelegate(Hospital.Painted);
            CTODelegate oil = new CTODelegate(Hospital.Oil);
            CTODelegate techInspection = new CTODelegate(Hospital.TechInspection);
            CTODelegate wheelReplacement = new CTODelegate(Hospital.WheelReplacement);
            CTODelegate bodyRepair = new CTODelegate(Hospital.BodyRepair);
            CTODelegate info = new CTODelegate(Hospital.Info);

            info.Invoke(auto);
            wheelAlignment.Invoke(auto);
            oil.Invoke(auto);
            bodyRepair(auto);
            info(auto);
            Console.ReadKey();
        }
    }
}