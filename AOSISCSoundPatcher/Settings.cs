using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace AOSISCSoundPatcher
{
    public class Settings
    {
        [SettingName("Name of Audio Overhaul Skyrim esp if it is not default")]
        public ModKey AOSesp = "Audio Overhaul Skyrim.esp";

        [SettingName("Name of Immersive Sounds - Compendium esp if it is not default")]
        public ModKey ISCespName = "Immersive Sounds - Compendium.esp";
    }
}
