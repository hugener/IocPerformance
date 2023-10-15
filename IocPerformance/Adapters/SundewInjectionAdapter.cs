namespace IocPerformance.Adapters
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using Catel.Reflection;
    using global::Sundew.Injection;
    using IocPerformance.Adapters.Sundew.Injection;
    using IocPerformance.Classes.Complex;
    using IocPerformance.Classes.Dummy;
    using IocPerformance.Classes.Multiple;
    using IocPerformance.Classes.Standard;

    public class SundewInjectionAdapter : IContainerAdapter
    {
        private SundewFactory sundewFactory;
        public string Version { get; } = typeof(IInjectionDeclaration).Assembly.Version();

        public string Name { get; } = "Sundew.Injection";

        public string PackageName { get; } = "Sundew.Injection";

        public string Url { get; } = "Sundew.Injection";

        public bool SupportsConditional { get; } = false;

        public bool SupportGeneric { get; } = false;

        public bool SupportsMultiple { get; } = true;

        public bool SupportsInterception { get; } = false;

        public bool SupportsPropertyInjection { get; } = false;

        public bool SupportsChildContainer { get; } = false;

        public bool SupportAspNetCore { get; } = false;

        public bool SupportsTransient { get; } = true;

        public bool SupportsCombined { get; } = true;

        public bool SupportsBasic { get; } = true;

        public bool SupportsPrepareAndRegister { get; } = true;

        public void PrepareBasic()
        {
            this.sundewFactory = new SundewFactory();
        }

        public void Prepare()
        {
            this.sundewFactory = new SundewFactory();
        }

        public object Resolve(Type type)
        {
            var result = this.sundewFactory.Resolve(type);
            return result;
        }

        public IChildContainerAdapter CreateChildContainerAdapter()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
        }
    }
}