using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AbpSample.Droid
{
	[DependsOn(typeof(XamarinSharedModule))]
	public class XamarinAndroidModule : AbpModule
	{
		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(typeof(XamarinAndroidModule).GetAssembly());
		}
	}
}