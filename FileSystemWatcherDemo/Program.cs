namespace FileSystemWatcherDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher("D:\\Labs\\CSharpLabs1\\Demos");
            watcher.EnableRaisingEvents = true;
            watcher.Created += Watcher_Change; 
            watcher.Deleted += Watcher_Change;
            watcher.Changed += Watcher_Change;
            Console.ReadLine();
        }

        private static void Watcher_Change(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Name :{e.Name}, Change :{e.ChangeType}");
        }
    }
}