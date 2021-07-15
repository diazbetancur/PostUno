using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace PostUno.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new PostUno.App(), args);
            host.Run();
        }
    }
}
