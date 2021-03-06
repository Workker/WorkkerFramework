﻿
namespace Workker.Framework.Domain
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T t);

        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> Or(ISpecification<T> specification);
        ISpecification<T> Not(ISpecification<T> specification);
    }
}