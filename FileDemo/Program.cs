namespace FileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives=DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Drive :{0}", drive.Name);
                    Console.WriteLine("type : {0}",drive.DriveType);
                Console.WriteLine($"Free Space :{drive.TotalFreeSpace/(1024*1024*1024)} GB");
            }
          /*  // FileInfo fileInfo = new FileInfo(@"D:\Labs\CSharpLabs1\file1.txt");
            DirectoryInfo directory1 = new DirectoryInfo(@"D:\Labs\CSharpLabs1\Demos");
            //var directoryDemos=directory1.CreateSubdirectory("Demos");

            if (directory1.Exists)
            {
                directory1.Create();
            }
            foreach (var directory in directory1.GetFiles())
            {
                Console.WriteLine($"Name:{directory.Name}");
                Console.WriteLine($"Name:{directory.Length/1024} KB");
                Console.WriteLine($"Name:{directory.LastWriteTime}");
            }*/
        }

      
    }
}