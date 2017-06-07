using Furcadia.Net.Proxy;
using Furcadia.Net.Options;

namespace BeekinProxy.Net
{
    public class BeekinProxySession : ProxySession
    {
        private BeekinProxyOptions ProxyOptions;
        public BeekinProxySession(BeekinProxyOptions Options): base(Options)
        {
            ProxyOptions = Options;
        }
    }
}
