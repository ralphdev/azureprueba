using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace cursoazuredevops.Localization
{
    public static class cursoazuredevopsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(cursoazuredevopsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(cursoazuredevopsLocalizationConfigurer).GetAssembly(),
                        "cursoazuredevops.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
