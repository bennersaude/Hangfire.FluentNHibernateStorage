﻿using FluentNHibernate.Mapping;
using Hangfire.FluentNHibernateStorage.Entities;

namespace Hangfire.FluentNHibernateStorage.Maps
{
    public abstract class IntIdMap<T> : ClassMap<T> where T : IInt64Id
    {
        protected IntIdMap()
        {
            LazyLoad();
            Id(i => i.Id).Column(Constants.Id).GeneratedBy.Identity();
        }
    }
}