﻿using PublicApiGeneratorTests.Examples;
using Xunit;

namespace PublicApiGeneratorTests
{
    public class Interface_variance : ApiGeneratorTestsBase
    {
        [Fact]
        public void Should_output_contravariance()
        {
            AssertPublicApi(typeof(IInterfaceWithContravariance<>),
@"namespace PublicApiGeneratorTests.Examples
{
    public interface IInterfaceWithContravariance<in T>
    {
        void Method(T item);
    }
}");
        }

        [Fact]
        public void Should_output_covariance()
        {
            AssertPublicApi(typeof(IInterfaceWithCovariance<>),
@"namespace PublicApiGeneratorTests.Examples
{
    public interface IInterfaceWithCovariance<out T>
    {
        T Method();
    }
}");
        }
    }

    // ReSharper disable UnusedMember.Global
    namespace Examples
    {
        public interface IInterfaceWithContravariance<in T>
        {
            void Method(T item);
        }

        public interface IInterfaceWithCovariance<out T>
        {
            T Method();
        }
    }
    // ReSharper restore UnusedMember.Global
}