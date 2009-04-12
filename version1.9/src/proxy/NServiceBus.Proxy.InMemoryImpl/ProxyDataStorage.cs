using System.Collections.Generic;

namespace NServiceBus.Proxy.InMemoryImpl
{
    public class ProxyDataStorage : IProxyDataStorage
    {
        public void Save(ProxyData data)
        {
            storage[data.Id] = data;
        }

        public ProxyData GetAndRemove(string id)
        {
            ProxyData result;
            storage.TryGetValue(id, out result);

            storage.Remove(id);

            return result;
        }

        private IDictionary<string, ProxyData> storage = new Dictionary<string, ProxyData>();
    }
}
