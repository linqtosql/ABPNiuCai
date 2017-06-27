using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpNiucaiCore.Localization
{
    public static class AbpNiucaiCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpNiucaiCoreConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpNiucaiCoreLocalizationConfigurer).GetAssembly(),
                        "AbpNiucaiCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}