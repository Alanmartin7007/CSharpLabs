
namespace FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "D:\\Labs\\CSharpLabs1\\Demos\\txt.txt";
            /* FileStream stream = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);

            *//* StreamWriter writer = new StreamWriter(stream);
             writer.WriteLine("Heloo");
             writer.WriteLine("Welcome to Speridian");
             writer.Close();
             stream.Close();*/
            //using will automatically close the writer
            try
            {
                using (FIleS stream1 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream1))
                    {

                        writer.WriteLine("Heloo");
                        // writer.Flush();
                        writer.WriteLine("Welcome to Alan");
                        //writer.Close(); 
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);

            }
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    StreamReader read
                        = new StreamReader(stream);
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        Console.WriteLine(line);

                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}