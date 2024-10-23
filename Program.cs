using System;
using System.Text;
using System;

partial class Program
{
    static void Main(params string[] parameters)
    {
        string ipv4 = "127.0.0.1";
        int port = 7073;
        int teamIndex = 7;
        if(parameters.Length >= 1) ipv4 = parameters[0];
        if(parameters.Length >= 2) port = int.Parse(parameters[1]);
        if(parameters.Length >= 3) teamIndex = int.Parse(parameters[2]);
        
        //Add the ip of the teacher local computer.
        //Documentation:
        //https://github.com/EloiStree/2024_08_29_ScratchToWarcraft

        WowInteger wow = new WowInteger(teamIndex, ipv4, port);
        int spaceStart = 1032;
        int spaceStop = 2032;
        int waitingTime = 30000;

        while (true)
        {
            wow.Push(spaceStart);
            Console.WriteLine("Jump");
            Thread.Sleep(waitingTime);
            wow.Push(spaceStop);
            Thread.Sleep(waitingTime);
        }
    }
}
