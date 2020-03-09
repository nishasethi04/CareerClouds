using System;

public class Program
{
    public static void Main()
    {
        Client client = new Client(new Service());
        client.Start();

        NewService newService = new NewService();
        Client clientNewFunction = new Client(newService);
        clientNewFunction.Start();

    }
}

public interface IService
{
    void Serve();
}

public class NewService : IService
{
    public void Serve()
    {
        Console.WriteLine("I'm doing something NEW!!!!!!");
    }
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
    private readonly IService _service;
    public Client(IService service)
    {
        _service = service;
    }
    public void Start()
    {
        Console.WriteLine("Service Started");
        this._service.Serve();
        //To Do: Some Stuff
    }
}

public class OldClient
{
    public OldClient()
    {
    }

    public void Start()
    {
        //Service WriteToDB = new Service();
        Service WriteToCloud = new Service();
        Console.WriteLine("Service Started");
        //WriteToDB.Serve();
        WriteToCloud.Serve();
    }

}

