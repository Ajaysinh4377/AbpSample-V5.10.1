using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AbpSample.iOS
{
    
	[DependsOn(typeof(XamarinSharedModule))]
	public class XamarinIosModule : AbpModule
	{
		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(typeof(XamarinIosModule).GetAssembly());
		}
	}
}