using System;

public class Program
{
    public static void Main()
    {
        Client client = new Client();
        client.Service = new Service();
        client.Start();
    }
}

public interface IService
{
    void Serve();
}

public class Service : IService
{
    public void Serve()
    {
        Console.WriteLine("Service Called");
        //To Do: Some Stuff
    }
}

public class Client
{
    private IService _service;

    public IService Service
    {
        set
        {
            _service = value;
        }
    }

    public void Start()
    {
        Console.WriteLine("Service Started");
        _service.Serve();
        //To Do: Some Stuff
    }
}

