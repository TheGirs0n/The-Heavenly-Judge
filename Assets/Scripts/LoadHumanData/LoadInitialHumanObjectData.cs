using HumanObjectDataFolder;
using UnityEngine;
using UnityEngine.UI;

namespace LoadHumanData
{
    public class LoadInitialHumanObjectData : MonoBehaviour
    {
        [Header("Human object Data")]
        [SerializeField] private HumanObjectData _humanObjectData;
        
        [Header("Human Object Data Load")]
        [SerializeField] private Image _humanObjectPhoto;
        [SerializeField] private string _humanObjectFullName;
        [SerializeField] private string _humanObjectJob;
        [SerializeField] private int _humanObjectAge;
        [SerializeField] private string _humanObjectFamily;
        [SerializeField] private string _humanObjectCauseOfDeath;

        private void Awake()
        {
            _humanObjectPhoto.GetComponent<Image>().sprite = _humanObjectData.HumanObjectPhoto.sprite;
            _humanObjectFullName = _humanObjectData.HumanObjectFullName;
            _humanObjectJob = _humanObjectData.HumanObjectJob;
            _humanObjectAge = _humanObjectData.HumanObjectAge;
            _humanObjectFamily = _humanObjectData.HumanObjectFamily;
            _humanObjectCauseOfDeath = _humanObjectData.HumanObjectCauseOfDeath;
        }
    }
}