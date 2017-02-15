using System;
using Furcadia.Net;

public class Class1
{
    public Class1()
    {
    }
    NetProxy proxy = new NetProxy();

    proxy.ServerData += delegate(string data) {
    Console.WriteLine("SERVER: "+data);
	return data;
};

proxy.ClientExited += delegate {
	Console.WriteLine("Client exited.");
	proxy.Kill();
};
proxy.Error += delegate(Exception e) {
	Console.WriteLine(e.Message);
};
proxy.Connect();
}