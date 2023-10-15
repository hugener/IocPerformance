using System;
using DryIocZero;

namespace IocPerformance.Adapters
{
    using IocPerformance.Classes.Complex;
    using IocPerformance.Classes.Dummy;
    using IocPerformance.Classes.Multiple;
    using IocPerformance.Classes.Standard;

    public sealed class DryIocZeroAdapter : ContainerAdapterBase
    {
        private Container container;

        public override string PackageName => "DryIocZero";

        public override string Url => "https://github.com/dadhi/DryIoc";

        public override bool SupportsConditional => true;

        public override bool SupportGeneric => true;

        public override bool SupportsMultiple => true;

        public override bool SupportsPropertyInjection => true;


        public override void Dispose() => container?.Dispose();

        public override void Prepare() => PrepareBasic();
        public override object Resolve(Type type)
        {
            return this.container.Resolve(type);
        }

        public override void PrepareBasic()
        {
            container = new Container();
        }

    }
}