using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PersonalCashFlow.Localization
{
    public static class PersonalCashFlowLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PersonalCashFlowConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PersonalCashFlowLocalizationConfigurer).GetAssembly(),
                        "PersonalCashFlow.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
