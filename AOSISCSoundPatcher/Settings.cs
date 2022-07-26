using Mutagen.Bethesda.WPF.Reflection.Attributes;

namespace AOSISCSoundPatcher
{
    public class Settings
    {
        [SettingName("Name of Audio Overhaul Skyrim esp if it is not default")]
        public string AOSespName = "Audio Overhaul Skyrim.esp";

        [SettingName("Name of Immersive Sounds - Compendium esp if it is not default")]
        public string ISCespName = "Immersive Sounds - Compendium.esp";
    }
}
