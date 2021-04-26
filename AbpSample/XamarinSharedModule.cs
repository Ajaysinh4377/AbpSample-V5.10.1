using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AbpSample
{
	public class XamarinSharedModule : AbpModule
	{
		public override void PreInitialize()
		{
			Configuration.Localization.IsEnabled = false;
			Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
		}

		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(typeof(XamarinSharedModule).GetAssembly());
		}
	}
}