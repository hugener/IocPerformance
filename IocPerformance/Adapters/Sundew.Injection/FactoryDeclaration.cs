namespace IocPerformance.Adapters.Sundew.Injection
{
    using global::Sundew.Injection;
    using IocPerformance.Classes.Complex;
    using IocPerformance.Classes.Dummy;
    using IocPerformance.Classes.Generics;
    using IocPerformance.Classes.Multiple;
    using IocPerformance.Classes.Properties;
    using IocPerformance.Classes.Standard;
    using Scope = global::Sundew.Injection.Scope;

    public class FactoryDeclaration : IInjectionDeclaration
    {
        public void Configure(IInjectionBuilder injectionBuilder)
        {
            injectionBuilder.Bind<ISingleton1, Singleton1>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<ISingleton2, Singleton2>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<ISingleton3, Singleton3>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<ITransient1, Transient1>();
            injectionBuilder.Bind<ITransient2, Transient2>();
            injectionBuilder.Bind<ITransient3, Transient3>();
            injectionBuilder.Bind<ICombined1, Combined1>();
            injectionBuilder.Bind<ICombined2, Combined2>();
            injectionBuilder.Bind<ICombined3, Combined3>();
            injectionBuilder.Bind<ICalculator1, Calculator1>();
            injectionBuilder.Bind<ICalculator2, Calculator2>();
            injectionBuilder.Bind<ICalculator3, Calculator3>();

            injectionBuilder.Bind<ISubObjectOne, SubObjectOne>();
            injectionBuilder.Bind<ISubObjectTwo, SubObjectTwo>();
            injectionBuilder.Bind<ISubObjectThree, SubObjectThree>();
            injectionBuilder.Bind<IFirstService, FirstService>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<ISecondService, SecondService>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<IThirdService, ThirdService>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<IComplex1, Complex1>();
            injectionBuilder.Bind<IComplex2, Complex2>();
            injectionBuilder.Bind<IComplex3, Complex3>();

            injectionBuilder.Bind<IServiceA, ServiceA>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<IServiceB, ServiceB>(Scope.SingleInstancePerFactory);
            injectionBuilder.Bind<IServiceC, ServiceC>(Scope.SingleInstancePerFactory);

            /*injectionBuilder.BindGeneric<IGenericInterface<object>, GenericExport<object>>();
            injectionBuilder.BindGeneric<ImportGeneric<object>, ImportGeneric<object>>();*/

            injectionBuilder.Bind<ISimpleAdapter, SimpleAdapterOne>();
            injectionBuilder.Bind<ISimpleAdapter, SimpleAdapterTwo>();
            injectionBuilder.Bind<ISimpleAdapter, SimpleAdapterThree>();
            injectionBuilder.Bind<ISimpleAdapter, SimpleAdapterFour>();
            injectionBuilder.Bind<ISimpleAdapter, SimpleAdapterFive>();



            injectionBuilder.CreateFactory(selector => selector
                .Add<IDummyOne, DummyOne>()
                .Add<IDummyTwo, DummyTwo>()
                .Add<IDummyThree, DummyThree>()
                .Add<IDummyFour, DummyFour>()
                .Add<IDummyFive, DummyFive>()
                .Add<IDummySix, DummySix>()
                .Add<IDummySeven, DummySeven>()
                .Add<IDummyEight, DummyEight>()
                .Add<IDummyNine, DummyNine>()
                .Add<IDummyTen, DummyTen>()
                    .Add<ISingleton1>()
                    .Add<ISingleton2>()
                    .Add<ISingleton3>()
                    .Add<ITransient1>()
                    .Add<ITransient2>()
                    .Add<ITransient3>()
                    .Add<ICombined1>()
                    .Add<ICombined2>()
                    .Add<ICombined3>()
                    .Add<ICalculator1>()
                    .Add<ICalculator2>()
                    .Add<ICalculator3>()
                    .Add<IComplex1>()
                    .Add<IComplex2>()
                    .Add<IComplex3>()
                    .Add<ImportMultiple1>()
                    .Add<ImportMultiple2>()
                    .Add<ImportMultiple3>(),
                "SundewFactory", generateTypeResolver: true);

            /*injectionBuilder.BindGeneric<IGenericInterface<object>, GenericExport<object>>();
            injectionBuilder.BindGeneric<ImportGeneric<object>, ImportGeneric<object>>();*/
        }
    }
}