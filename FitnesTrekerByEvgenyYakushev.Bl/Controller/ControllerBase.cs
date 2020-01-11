using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnesTrekerByEvgenyYakushev.Bl.Controller
{
    abstract class ControllerBase
    {
        protected void Save()
        {
            var formatter = new BinaryFormatter();


            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Users);
            }
        }


    }
    }
}
