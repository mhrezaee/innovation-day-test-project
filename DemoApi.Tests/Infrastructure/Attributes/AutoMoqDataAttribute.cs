﻿using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace DemoApi.Tests.Infrastructure.Attributes;


[AttributeUsage(AttributeTargets.Method)]
public sealed class AutoMoqDataAttribute : AutoDataAttribute
{
    public AutoMoqDataAttribute() : base(()=>new Fixture().Customize(new AutoMoqCustomization()))
    {
        
    }
}