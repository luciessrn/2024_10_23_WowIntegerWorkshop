using System;
using System.Text;
using System.Threading;

partial class Program
{
    static void Main(params string[] parameters)
    {
        string ipv4 = "192.168.137.50";
        int port = 7073;
        int teamIndex = 3;

        if (parameters.Length >= 1) ipv4 = parameters[0];
        if (parameters.Length >= 2) port = int.Parse(parameters[1]);
        if (parameters.Length >= 3) teamIndex = int.Parse(parameters[2]);

        // Add the IP of the teacher's local computer.
        // Documentation:
        // https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
        WowInteger wow = new WowInteger(teamIndex, ipv4, port);
        WowCommander commander = new WowCommander();

        while (true)
        {
            Console.WriteLine("Next ?");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.Spacebar)
                commander.Jump(wow);
            else if (keyInfo.Key == ConsoleKey.Z)
                commander.MoveForward(wow);
            else if (keyInfo.Key == ConsoleKey.S)
                commander.BackWard(wow);
            else if (keyInfo.Key == ConsoleKey.Q)
                commander.MoveLeft(wow);
            else if (keyInfo.Key == ConsoleKey.D)
                commander.MoveRight(wow);
            else if (keyInfo.Key == ConsoleKey.A)
                commander.TurnLeft(wow);
            else if (keyInfo.Key == ConsoleKey.E)
                commander.TurnRight(wow);
            else if (keyInfo.Key == ConsoleKey.C)
                commander.Sit(wow);
            else if (keyInfo.Key == ConsoleKey.Tab)
                commander.ChangeTarget(wow);
            else if (keyInfo.Key == ConsoleKey.V)
                commander.AutoRun(wow);
            else if (keyInfo.Key == ConsoleKey.F)
                commander.InteractStart(wow);
            else if (keyInfo.Key == ConsoleKey.NumPad1)
                commander.ThrowSpell(wow);
            Thread.Sleep(10);
            Console.WriteLine($"Key {keyInfo.Key} ");

        }
    }
}

public class WowCommander
{
    public void Press(WowInteger wow, int key)
    {
        wow.Push(key);
    }

    public void Release(WowInteger wow, int key)
    {
        wow.Push(key);
    }

    public void PressAndRelease(WowInteger wow, int keyDown, int keyUp, float waitingTime)
    {
        Press(wow, keyDown);
        Thread.Sleep((int)(waitingTime * 1000f));
        Release(wow, keyUp);
    }

    public void Jump(WowInteger wow)
    {
        PressAndRelease(wow, spaceStart, spaceStop, 0.1f);
    }

    public int spaceStart = 1032;
    public int spaceStop = 2032;
    public void MoveForward(WowInteger wow)
    {
        PressAndRelease(wow, moveForwardStart, moveForwardStop, 1f);
    }

    public int moveForwardStart = 1090;
    public int moveForwardStop = 2090;
    public void BackWard(WowInteger wow)
    {
        PressAndRelease(wow, backWardStart, backWardStop, 1f);
    }

    public int backWardStart = 1083;
    public int backWardStop = 2083;
    public void MoveLeft(WowInteger wow)
    {
        PressAndRelease(wow, moveLeftStart, moveLeftStop, 1f);
    }

    public int moveLeftStart = 1087;
    public int moveLeftStop = 2087;
    public void MoveRight(WowInteger wow)
    {
        PressAndRelease(wow, moveRightStart, moveRightStop, 1f);
    }

    public int moveRightStart = 1088;
    public int moveRightStop = 2088;
    public void TurnLeft(WowInteger wow)
    {
        PressAndRelease(wow, turnLeftStart, turnLeftStop, 1f);
    }

    public int turnLeftStart = 1082;
    public int turnLeftStop = 2082;
    public void TurnRight(WowInteger wow)
    {
        PressAndRelease(wow, turnRightStart, turnRightStop, 1f);
    }

    public int turnRightStart = 1068;
    public int turnRightStop = 2068;
    public void Sit(WowInteger wow)
    {
        PressAndRelease(wow, sitStart, sitStop, 0.1f);
    }

    public int sitStart = 1067;
    public int sitStop = 2067;
    public void ChangeTarget(WowInteger wow)
    {
        PressAndRelease(wow, changeTargetStart, changeTargetStop, 0.1f);
    }

    public int changeTargetStart = 1009;
    public int changeTargetStop = 2009;
    public void AutoRun(WowInteger wow)
    {
        PressAndRelease(wow, autoRunStart, autoRunStop, 0.1f);
    }

    public int autoRunStart = 1086;
    public int autoRunStop = 2086;
    public void InteractStart(WowInteger wow)
    {
        PressAndRelease(wow, interactStart, interactStop, 0.1f);
    }

    public int interactStart = 1049;
    public int interactStop = 2049;
    public void ThrowSpell(WowInteger wow)
    {
        PressAndRelease(wow, throwSpellStart, throwSpellStop, 0.1f);
    }

    public int throwSpellStart = 1049;
    public int throwSpellStop = 2049;
}
