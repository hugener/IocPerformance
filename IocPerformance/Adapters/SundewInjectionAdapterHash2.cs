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

    public class SundewInjectionAdapterHash2 : IContainerAdapter
    {
        private SundewFactory sundewFactory;
        private readonly Proxy2<SundewFactory> SundewFactoryProxy = new Proxy2<SundewFactory>();
        public string Version { get; } = typeof(IInjectionDeclaration).Assembly.Version();

        public string Name { get; } = "Sundew.Injection.Hash2";

        public string PackageName { get; } = "Sundew.Injection.Hash2";

        public string Url { get; } = "Sundew.Injection.Hash2";

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
            this.Register();
        }

        public void Prepare()
        {
            this.sundewFactory = new SundewFactory();
            this.Register();
            this.SundewFactoryProxy.Add(typeof(ImportMultiple1), f => f.CreateImportMultiple1());
            this.SundewFactoryProxy.Add(typeof(ImportMultiple2), f => f.CreateImportMultiple2());
            this.SundewFactoryProxy.Add(typeof(ImportMultiple3), f => f.CreateImportMultiple3());
        }

        private unsafe void Register()
        {
            unsafe
            {
                this.SundewFactoryProxy.Add(typeof(ISingleton1), f =>f.CreateSingleton1());
                this.SundewFactoryProxy.Add(typeof(ISingleton2), f => f.CreateSingleton2());
                this.SundewFactoryProxy.Add(typeof(ISingleton3), f =>f.CreateSingleton3());
                this.SundewFactoryProxy.Add(typeof(ITransient1), f =>f.CreateTransient1());
                this.SundewFactoryProxy.Add(typeof(ITransient2), f =>f.CreateTransient2());
                this.SundewFactoryProxy.Add(typeof(ITransient3), f =>f.CreateTransient3());
                this.SundewFactoryProxy.Add(typeof(ICombined1), f =>f.CreateCombined1());
                this.SundewFactoryProxy.Add(typeof(ICombined2), f =>f.CreateCombined2());
                this.SundewFactoryProxy.Add(typeof(ICombined3), f => f.CreateCombined3());
                this.SundewFactoryProxy.Add(typeof(IComplex1), f =>f.CreateComplex1());
                this.SundewFactoryProxy.Add(typeof(IComplex2), f =>f.CreateComplex2());
                this.SundewFactoryProxy.Add(typeof(IComplex3), f => f.CreateComplex3());
                this.SundewFactoryProxy.Add(typeof(ICalculator1), f =>f.CreateCalculator1());
                this.SundewFactoryProxy.Add(typeof(ICalculator2), f =>f.CreateCalculator2());
                this.SundewFactoryProxy.Add(typeof(ICalculator3), f => f.CreateCalculator3());
                this.SundewFactoryProxy.Add(typeof(IDummyOne), f => f.CreateDummyOne());
                this.SundewFactoryProxy.Add(typeof(IDummyTwo), f => f.CreateDummyTwo());
                this.SundewFactoryProxy.Add(typeof(IDummyThree), f => f.CreateDummyThree());
                this.SundewFactoryProxy.Add(typeof(IDummyFour), f => f.CreateDummyFour());
                this.SundewFactoryProxy.Add(typeof(IDummyFive), f => f.CreateDummyFive());
                this.SundewFactoryProxy.Add(typeof(IDummySix), f => f.CreateDummySix());
                this.SundewFactoryProxy.Add(typeof(IDummySeven), f => f.CreateDummySeven());
                this.SundewFactoryProxy.Add(typeof(IDummyEight), f => f.CreateDummyEight());
                this.SundewFactoryProxy.Add(typeof(IDummyNine), f => f.CreateDummyNine());
                this.SundewFactoryProxy.Add(typeof(IDummyTen), f => f.CreateDummyTen());
            }
        }

        public object Resolve(Type type)
        {
            var r = this.SundewFactoryProxy.Create(this.sundewFactory, type);
            return r;
        }

        public IChildContainerAdapter CreateChildContainerAdapter()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
        }
    }

    public class Proxy2<TFactory>
    {
        private const int I = 7829;
        public Func<TFactory, object>[] map = new Func<TFactory, object>[I];
        public Proxy2()
        {

        }

        public object Create(TFactory factory, Type type)
        {
            var d = this.map[RuntimeHelpers.GetHashCode(type) % I];
            if (d != null)
            {
                return d.Invoke(factory);
            }

            return null;
        }

        public void Add(Type type, Func<TFactory, object> stackDelegate)
        {
            this.map[RuntimeHelpers.GetHashCode(type) % I] = stackDelegate;
        }
    }
}