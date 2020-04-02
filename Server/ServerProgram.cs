using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels.Http;
using Model;
using Manager;

namespace Server
{
    class ServerProgram
    {
        static void Main(string[] args)
        {
            //建立服务传输方式，可选择TCP或者HTTP，前者更能发挥高效性
            TcpServerChannel channel = new TcpServerChannel(8089);
            // HttpChannel channel2 = new HttpChannel(8090);
            //注册通道
            ChannelServices.RegisterChannel(channel, false);
            //添加可调用的远程对象，WellKonwnObjectMode可选择为SingleTon或者SingleCall
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(PersonManager), "PersonUri", WellKnownObjectMode.Singleton);
            Console.ReadKey();
        }
    }
}
