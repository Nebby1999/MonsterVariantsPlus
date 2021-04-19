using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterVariantsPlus.SubClasses
{
    public static class ClayManCompat
    {
        private static bool? _enabled;

        public static bool enabled
        {
            get
            {
                if (_enabled == null)
                {
                    _enabled = BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey("Moffein - Clay_Men - 1.3.5");
                }
                return (bool)_enabled;
            }
        }
    }
}
