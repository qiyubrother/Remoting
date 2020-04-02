using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Model;
using Manager;

namespace Client
{
    class ClientProgram
    {
        static void Main(string[] args)
        {
            //确立通道传送方式
            ChannelServices.RegisterChannel(new TcpClientChannel(),false);
            //使用Activator.GetObject（）或者Activator.CreateInstance（）方法建立透明代理，控制远程对象
            PersonManager personManager = (PersonManager)Activator.GetObject(typeof(PersonManager), "tcp://localhost:8089/PersonUri");
            //获取远程数据
            List<Person> personList = personManager.GetList();
            if (personList.Count != 0)
                foreach (Person person in personList)
                    Console.WriteLine("ID:" + person.ID.ToString() + " Age:" + person.Age.ToString() + " Name:" + person.Name);
            Console.ReadKey();
        }
    }
}
