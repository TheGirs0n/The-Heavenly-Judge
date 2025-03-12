using UnityEngine;
using UnityEngine.UI;

namespace HumanObjectDataFolder
{
    [CreateAssetMenu(menuName = "HumanObjectDataData")]
    public class HumanObjectData : ScriptableObject
    {
        public Image HumanObjectPhoto;
        public string HumanObjectFullName;
        public string HumanObjectJob;
        public int HumanObjectAge;
        public string HumanObjectFamily;
        public string HumanObjectCauseOfDeath;
    }
}
