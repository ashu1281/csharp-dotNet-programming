namespace charp_programming
{
    internal class Program
    {
        public static void Main()
        {
            WriteErrorLogToBinaryFile();
            ReadErrorLogFromBinaryFile();
        }
        static void WriteErrorLogToBinaryFile()
        {
            using(BinaryWriter writer =new BinaryWriter(File.Open("errlog.bin", FileMode.Create)))
            {
                writer.Write(0x80000003);
                writer.Write("one or more arguments are invalids");
            }
        }

        static void ReadErrorLogFromBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("errlog.bin", FileMode.Open)))
            {
                Console.WriteLine("Errro code: " + string.Format("0x{0:x}", reader.ReadInt32()));
                Console.WriteLine("Message: " + reader.ReadString());
            }
        }
    }
}