using stajproje.Properties.model;
using stajproje.Queries;

namespace stajproje.Handlers
{
    public class GetOgrenciQuerryHandler
    {
        public OgrenciReadModel Handle(GetOgrenciQuery query)
        {
            // Sorgu işlemlerini burada gerçekleştirin
            return ogrenciReadModel;
        }
    }
}
