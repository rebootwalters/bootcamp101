namespace TypesLoopBranchingExample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// AUTHOR: Giancarlo Rhodes
    /// COMPANY: Onshore Outsourcing
    /// DESCRIPTION: 
    /// </summary>
    public class ParkingLot
    {
        public List<Car> ListOfCars { get; set; }

        public string Location { get; set; }

        public int LotMaxCarLimit { get; set; }

        public bool IsOpen { get; set; }

        public DateTime OperationOpen { get; set; }
        public DateTime OperationClose { get; set; }

        // empty constructor
        public ParkingLot() {
            ListOfCars = new List<Car>();
        }

        // constructor passing in the Location of the lot
        public ParkingLot(string _location) {
            Location = _location;
            // create list of car object
            ListOfCars = new List<Car>();
        }

    }
}
