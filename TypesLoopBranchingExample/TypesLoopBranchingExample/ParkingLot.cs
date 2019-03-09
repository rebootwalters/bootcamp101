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
            this.LotMaxCarLimit = 100;
        }

        // constructor passing in the Location of the lot
        public ParkingLot(string _location) {
            Location = _location;
            // create list of car object
            ListOfCars = new List<Car>();
            this.LotMaxCarLimit = 100;
        }

        // add car
        public void EnteringLot(Car c) {

            // code here
            this.ListOfCars.Add(c);
        }

        // remove car
        public void ExitingLot(Car c) {

            // code here
            this.ListOfCars.Remove(c);

        }


        public Boolean IsLotFull() {

            // how many cars are currently in the lot
            if (this.ListOfCars.Count >= LotMaxCarLimit)
            {
                return true;
            }
            else {

                return false;
            }


         
        }


    }  // class closing bracket
}  // namespacing closing bracket
