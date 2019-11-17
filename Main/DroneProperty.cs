using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone_Flight_Time_Calculator
{
    public class DroneProperty
    {
        private string motor_front;
        private string motor_rear;
        private string frame;
        private string rc_reciever;

        public String  MotorRear
        {
            get  { return motor_rear; }
            set
            {
                motor_rear = value;
            }
        }
        public String Frame
        {
            get { return frame; }
            set
            {
                frame = value;
            }
        }
        public String RCReciever
        {
            get { return rc_reciever; }
            set
            {
                rc_reciever = value;
            }
        }

        public String MotorFront
        {
            get { return motor_front; }
            set
            {
                motor_front = value;
            }
        }
        private void GetProperty()
        {
            DataSet ds = new DataSet();
            Dictionary<string, Type> dicProperty = new Dictionary<string, Type>();
            Type t = typeof(DroneProperty);
            //Console.WriteLine("The {0} type has the following properties: ",t.Name);
            foreach (var prop in t.GetProperties())
            {
                //Console.WriteLine("   {0} ({1})", prop.Name,    prop.PropertyType.Name);
            }
        }
    }
}

