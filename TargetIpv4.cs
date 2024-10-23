[Serializable]
public class TargetIpv4
{
    public string m_targetIP = "127.0.0.1";
    public int m_targetPort = 7073;
    public TargetIpv4() { }
    public TargetIpv4(string targetIP, int targetPort)
    {
        m_targetIP = targetIP;
        m_targetPort = targetPort;
    }
}
