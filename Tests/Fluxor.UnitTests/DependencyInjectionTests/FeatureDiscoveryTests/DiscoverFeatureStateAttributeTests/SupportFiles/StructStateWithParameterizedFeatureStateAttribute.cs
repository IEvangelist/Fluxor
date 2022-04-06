﻿namespace Fluxor.UnitTests.DependencyInjectionTests.FeatureDiscoveryTests.DiscoverFeatureStateAttributeTests.SupportFiles
{
    [FeatureState(Name = "ParameterizedName", MaximumStateChangedNotificationsPerSecond = 42)]
    public readonly record struct StructStateWithParameterizedFeatureStateAttribute(
        string Name,
        int MaximumStateChangedNotificationsPerSecond);
}
