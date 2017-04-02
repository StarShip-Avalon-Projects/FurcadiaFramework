using FurcadiaFramework_Example.Demo;
using System.Collections;

namespace FurcadiaFramework_Example
{
    internal class Program
    {
        #region Private Methods

        private static int Main(string[] args)
        {
            Queue queue = new Queue();
            //queue.Enqueue(new GraphicsDemo());
            //queue.Enqueue(new NetworkDemo());
            queue.Enqueue(new FriendStatusDemo());
            while (queue.Count > 0)
            {
                ((IDemo)queue.Dequeue()).Run();
                queue.TrimToSize();
            }
            return 0;
        }

        #endregion Private Methods
    }
}