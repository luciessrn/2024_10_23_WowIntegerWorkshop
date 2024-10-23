
public class WowInteger
{

    // DOCUMENTATION: https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
    //0 = All
    //1 = Team 1
    //2 = Team 2
    //3 = Team 3
    //4 = Team 4
    //This is the index of your team.
    int indexOfYourTeam = 1;
    //This is the IPV4 of the computer at who you want to send message.
    string targetComputerIpv4 = "127.0.0.1";
    //This is the open port of the computer at who you want to send message.
    int targetComputerOpenPort = 7073;
    //All you to send message as integer to the target computer on your team window
    UdpSender sender;// new UdpSender(indexOfYourTeam, targetComputerIpv4, targetComputerOpenPort);
                     // I trust you to not use it for bad purpose in the workshop
                     // Don't make me use a password
                     //All you to send message as integer to the target computer on all window
    UdpSender senderToAll;// new UdpSender(0, targetComputerIpv4, targetComputerOpenPort);


    public WowInteger(int yourTeamIndex, string targetComputerIpv4, int targetComputerOpenPort = 7073)
    {
        indexOfYourTeam = yourTeamIndex;
        this.targetComputerIpv4 = targetComputerIpv4;
        this.targetComputerOpenPort = targetComputerOpenPort;
        sender = new UdpSender(indexOfYourTeam, targetComputerIpv4, targetComputerOpenPort);
        senderToAll = new UdpSender(0, targetComputerIpv4, targetComputerOpenPort);
    }

    public void Push(int integer)
    {
        sender.SendInteger(integer);
    }
    public void PushToAll(int integer)
    {
        senderToAll.SendInteger(integer);
    }

    internal void SetIndex(int i)
    {
        throw new NotImplementedException();
    }
}
