﻿namespace DesignPatternsLibrary.Mappings
{
    public interface IMapper<in TSource,out TDestination>
    {
        TDestination Map(TSource source);
    }
}
