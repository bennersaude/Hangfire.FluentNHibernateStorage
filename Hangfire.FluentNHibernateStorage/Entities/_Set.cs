namespace Hangfire.FluentNHibernateStorage.Entities
{
    internal class _Set : EntityBase1<string>, IExpireWithKey, IExpireWithId
    {
        public double Score { get; set; }
    }
}