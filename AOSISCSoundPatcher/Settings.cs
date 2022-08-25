using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis.Settings;

namespace AOSISCSoundPatcher
{
    public class Settings
    {
        [SynthesisSettingName("AOS esp")]
        [SynthesisTooltip("Select Audio Overhaul Skyrim esp if it is not default")]
        public ModKey AOSesp = "Audio Overhaul Skyrim.esp";

        [SynthesisSettingName("ISC esp")]
        [SynthesisTooltip("Select Immersive Sounds - Compendium esp if it is not default")]
        public ModKey ISCesp = "Immersive Sounds - Compendium.esp";
    }
}
