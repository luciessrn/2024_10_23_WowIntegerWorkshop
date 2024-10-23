using System.Net;
using System.Net.Sockets;

public class UdpSender
{

    int m_index;
    TargetIpv4 m_target;
    public UdpSender(int index, string ip, int port)
    {
        m_index = index;
        m_target = new TargetIpv4(ip, port);
    }

    public void SendInteger(int integer)
    {
        SendInteger(m_index, integer);
    }

    void SendInteger(int index, int integer)
    {
        byte[] message;
        IndexIntegerDateConverter.ParseToByte(index, integer, out message);
        SendByte(message, m_target);
    }

    void SendByte(byte[] message)
    {
        SendByte(message, m_target);
    }

    void SendByte(byte[] message, TargetIpv4 target)
    {
        using (UdpClient client = new UdpClient())
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(target.m_targetIP), target.m_targetPort);
            client.Send(message, message.Length, endPoint);
        }
    }
}
