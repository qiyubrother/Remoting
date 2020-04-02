using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Model;

namespace Manager
{
    public class PersonManager:MarshalByRefObject
    {
        //在服务器端获取虚拟数据
        public List<Person> GetList()
        {
            List<Person> personList = new List<Person>();
            FileStream stream = new FileStream("DataSource.sour", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            personList=(List<Person>)formatter.Deserialize(stream);
            return personList;
        }
    }
}
