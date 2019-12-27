namespace SoftwareTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();

            var ownersAndRepos = worker.GetOwnersAndRepos();
            
        }
    }
}
