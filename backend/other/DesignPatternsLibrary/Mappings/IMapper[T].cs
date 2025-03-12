﻿namespace DesignPatternsLibrary.Mappings
{
    public interface IMapper<TSource,TDestination>
    {
        TDestination Map(TSource source);
    }
}
