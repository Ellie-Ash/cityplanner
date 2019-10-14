using System;

namespace Planner
{
    // Define class here
    public class Building {
        private string _designer = "Ellie Ash";
        private DateTime _dateConstructed = new DateTime();
        private string _address = "123 Oak Street";
        private string _owner = "Someone";
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get {
            return Width * Depth * (3 * Stories);
            }
        }
        public Building(string address)
        {
            _address = address;
        }
        public void _Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void _Purchase(string buyerName)
        {
            _owner = buyerName;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"{_address}");
            Console.WriteLine("------------");
            Console.WriteLine($"Designed By {_designer}");
            Console.WriteLine($"Constructed On {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters");
        }
    }
}