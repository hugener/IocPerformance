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

    public class SundewInjectionAdapterHash : IContainerAdapter
    {
        private SundewFactory sundewFactory;
        private readonly Proxy proxy = new Proxy();
        public string Version { get; } = typeof(IInjectionDeclaration).Assembly.Version();

        public string Name { get; } = "Sundew.Injection.Hash";

        public string PackageName { get; } = "Sundew.Injection.Hash";

        public string Url { get; } = "Sundew.Injection.Hash";

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
            this.proxy.Add(typeof(ImportMultiple1), this.sundewFactory.CreateImportMultiple1);
            this.proxy.Add(typeof(ImportMultiple2), this.sundewFactory.CreateImportMultiple2);
            this.proxy.Add(typeof(ImportMultiple3), this.sundewFactory.CreateImportMultiple3);
        }

        private unsafe void Register()
        {
            unsafe
            {
                this.proxy.Add(typeof(ISingleton1), this.sundewFactory.CreateSingleton1);
                this.proxy.Add(typeof(ISingleton2), this.sundewFactory.CreateSingleton2);
                this.proxy.Add(typeof(ISingleton3), this.sundewFactory.CreateSingleton3);
                this.proxy.Add(typeof(ITransient1), this.sundewFactory.CreateTransient1);
                this.proxy.Add(typeof(ITransient2), this.sundewFactory.CreateTransient2);
                this.proxy.Add(typeof(ITransient3), this.sundewFactory.CreateTransient3);
                this.proxy.Add(typeof(ICombined1), this.sundewFactory.CreateCombined1);
                this.proxy.Add(typeof(ICombined2), this.sundewFactory.CreateCombined2);
                this.proxy.Add(typeof(ICombined3), this.sundewFactory.CreateCombined3);

                this.proxy.Add(typeof(IComplex1), this.sundewFactory.CreateComplex1);
                this.proxy.Add(typeof(IComplex2), this.sundewFactory.CreateComplex2);
                this.proxy.Add(typeof(IComplex3), this.sundewFactory.CreateComplex3);
                this.proxy.Add(typeof(ICalculator1), this.sundewFactory.CreateCalculator1);
                this.proxy.Add(typeof(ICalculator2), this.sundewFactory.CreateCalculator2);
                this.proxy.Add(typeof(ICalculator3), this.sundewFactory.CreateCalculator3);
                this.proxy.Add(typeof(IDummyOne), this.sundewFactory.CreateDummyOne);
                this.proxy.Add(typeof(IDummyTwo), this.sundewFactory.CreateDummyTwo);
                this.proxy.Add(typeof(IDummyThree), this.sundewFactory.CreateDummyThree);
                this.proxy.Add(typeof(IDummyFour), this.sundewFactory.CreateDummyFour);
                this.proxy.Add(typeof(IDummyFive), this.sundewFactory.CreateDummyFive);
                this.proxy.Add(typeof(IDummySix), this.sundewFactory.CreateDummySix);
                this.proxy.Add(typeof(IDummySeven), this.sundewFactory.CreateDummySeven);
                this.proxy.Add(typeof(IDummyEight), this.sundewFactory.CreateDummyEight);
                this.proxy.Add(typeof(IDummyNine), this.sundewFactory.CreateDummyNine);
                this.proxy.Add(typeof(IDummyTen), this.sundewFactory.CreateDummyTen);
            }
        }

        public object Resolve(Type type)
        {
            return this.proxy.Create(type);
        }

        public IChildContainerAdapter CreateChildContainerAdapter()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
        }
    }

    public class Proxy
    {
        private const int I = 7805;
        public Func<object>[] map = new Func<object>[I];
        public Proxy()
        {

        }

        public object Create(Type type)
        {
            return this.map[RuntimeHelpers.GetHashCode(type) % I].Invoke();
        }

        public void Add(Type type, Func<object> stackDelegate)
        {
            this.map[RuntimeHelpers.GetHashCode(type) % I] = stackDelegate;
        }

        public readonly unsafe struct StackDelegate
        {
            public readonly delegate*<object> function;

            public StackDelegate(delegate*<object> f)
            {
                this.function = f;
            }

            public object Invoke()
            {
                return this.function();
            }
        }
    }
}