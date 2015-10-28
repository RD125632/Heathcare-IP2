using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare_IP2.JsonObjects
{
    public class Test
    {
        public string userName { get; private set; }
        public int userAge { get; private set; }
        public int userWeight { get; private set; }
        public List<Measurement> testSession { get; set; }

        public Test(string id, int age, int weight)
        {
            this.userName = id;
            this.userAge = age;
            this.userWeight = weight;
            this.testSession = new List<Measurement>();
        }

        public void AddMeasurement(Measurement measurement)
        {
            testSession.Add(measurement);
        }
    }
}
