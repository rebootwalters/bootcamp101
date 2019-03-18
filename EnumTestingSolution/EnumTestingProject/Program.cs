using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTestingProject
{
  [Flags] public enum AlarmCodes
    {
        AllClear = 0,

        WindowFront = 1,
        WindowRear = 2,
        WindowRight = 4,
        WindowLeft = 8,
        AllWindows = WindowFront | WindowRear | WindowRight | WindowLeft,
        SideWindows = WindowLeft | WindowRight,

        DoorFront = 16,
        DoorSide = 32,
        DoorRear = 64,
        AllDoors = DoorFront |DoorSide| DoorRear,

        RoomDining = 128,
        RoomLiving = 256,
        RoomKitchen = 512,
        AllRooms = RoomDining | RoomLiving | RoomKitchen,

        All = AllDoors | AllRooms | AllWindows,

    }
    public class Program
    {
        static void Main(string[] args)
        {

            AlarmCodes c = AlarmCodes.WindowRear | AlarmCodes.DoorFront ;

            CheckAlarm(c);
         
           

        }

        static void CheckAlarm(AlarmCodes c)
        {
            // check for any window triggered 
            if (!(AlarmCodes.AllClear == (c & AlarmCodes.AllWindows)))
            {
                Console.WriteLine("A window is triggered");
            }
            else
            {
                Console.WriteLine("No Windows are triggered");
            }
            // check for any door code triggered
            if (!(AlarmCodes.AllClear == (c & AlarmCodes.AllDoors)))
            {
                Console.WriteLine("A door is triggered");
            }
            else
            {
                Console.WriteLine("No doors are triggered");
            }
            // check for any room code triggered

            // check for front door triggered
            // check to see if rear door or rear window triggered
        }
    }
}
