using UnityEngine;

namespace Sprites
{
    public class ChangeSprite : MonoBehaviour
    {
        [SerializeField] private GameObject _victimPrefab;
        
        private Sprite _victimSprite;

        public void HeavenBulletChangeSprite()
        {
            _victimPrefab.gameObject.SetActive(false);
        }
        
        public void MemoryBulletChangeSprite(int memoryUsedCount)
        {
            
        }
        
        public void HellBulletChangeSprite()
        {
            _victimPrefab.gameObject.SetActive(false);
        }
    }
}
