using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace FinalProject_Programming2_V1
{
    class DroneClass
    {
        //Fields for Drone Class.
        private string model, engineConfig, accessories, date, serialNumber, range, price;
        private int droneNullPointer;
        // Drone Array initiated.

        public DroneClass()
        {

        }
       

        // Getters and setters for DroneClass
        public string gsSerialNumber { get => serialNumber; set => serialNumber = value; }
        public string gsRange { get => range; set => range = value; }
        public string gsModel { get => model; set => model = value; }
        public string gsEngineConfig { get => engineConfig; set => engineConfig = value; }
        public string gsAccessories { get => accessories; set => accessories = value; }
        public string gsDate { get => date; set => date = value; }
        public string gsPrice { get => price; set => price = value; }
        public int DroneNullPointer { get => droneNullPointer; set => droneNullPointer = value; }
    }
}
