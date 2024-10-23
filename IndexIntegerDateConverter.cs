public class IndexIntegerDateConverter
{

    public static void ParseToByte(in int index, in int integer, out byte[] bytes)
    {

        byte[] message = new byte[16];
        BitConverter.GetBytes(index).CopyTo(message, 0);       // First 4 bytes
        BitConverter.GetBytes(integer).CopyTo(message, 4);       // Next 4 bytes
        if (!BitConverter.IsLittleEndian)
        {
            Array.Reverse(message, 0, 4);  // Reverse for intIndex
            Array.Reverse(message, 4, 4);  // Reverse for intValue
        }

        DateTime date = DateTime.Now;
        long longData = date.Ticks / 10000;
        BitConverter.GetBytes(longData).CopyTo(message, 8);      // Next 8 bytes (long)
        if (!BitConverter.IsLittleEndian)
        {
            Array.Reverse(message, 8, 8);  // Reverse for longData
        }
        bytes = message;


    }
}
