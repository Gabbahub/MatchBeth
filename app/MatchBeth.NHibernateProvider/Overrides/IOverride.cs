using NHibernate.Mapping.ByCode;

namespace MatchBeth.NHibernateProvider.Overrides
{
    internal interface IOverride
    {
        void Override(ModelMapper mapper);
    }
}
