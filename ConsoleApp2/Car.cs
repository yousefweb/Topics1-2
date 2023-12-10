using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car : Vehicle
    {

        private string type;
        private string model;
        private string palletNo;
        private string color;
        private bool isEngineRunning;


        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string PalletNo
        {
            get { return palletNo; }
            set { palletNo = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool IsEngineRunning
        {
            get { return isEngineRunning; }
            set { isEngineRunning = value; }
        }
        public Car(string make, int year, string type, decimal price, string model, string palletNo, string color)
            : base(make, year, price)
        {
            Type = type;
            Model = model;
            PalletNo = palletNo;
            Color = color;

            IsEngineRunning = false;
        }
        public void StartEngine()
        {
            if (!IsEngineRunning)
            {
                Console.WriteLine("Engine is starting...");
                IsEngineRunning = true;
            }
            else
            {
                Console.WriteLine("Engine is already running.");
            }
        }

        public void StopEngine()
        {
            if (IsEngineRunning)
            {
                Console.WriteLine("Engine is stopping...");
                IsEngineRunning = false;
            }
            else
            {
                Console.WriteLine("Engine is already stopped.");
            }
        }

        public string GetCarInformation()
        {
            return $"Make: {Make}\nYear: {Year}\nType: {Type}\nPrice: {Price:C}\nModel: {Model}\nPallet No: {PalletNo}\nColor: {Color}\nEngine Running: {(IsEngineRunning ? "Yes" : "No")}";
        }
    }

}
