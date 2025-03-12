using System.Collections.Generic;
using BulletAction;
using UnityEngine;

namespace UI
{
    public class MemoryCountControll : MonoBehaviour
    {
        [SerializeField] private GameObject _memoryBulletPrefab;
        [SerializeField] private GameObject _memoryBulletStash;
        [SerializeField] private List<GameObject> _memoryBullets;
    
        private const int _maxMemoryBulletCount = 3;
        private int _currentMemoryBulletCount;
        
        public int MaxMemoryBulletCount => _maxMemoryBulletCount;
        public int CurrentMemoryBulletCount => _currentMemoryBulletCount;
        
        private void Awake()
        {
            _currentMemoryBulletCount = _maxMemoryBulletCount;
            MemoryBullet.OnMemoryBulletUsed += NewGiveMemory;

            for (int i = 0; i < _maxMemoryBulletCount; i++)
            {
                var bullet = Instantiate(_memoryBulletPrefab, _memoryBulletStash.transform);
                _memoryBullets.Add(bullet);
            }
        }

        private void NewGiveMemory()
        {
            _memoryBullets[--_currentMemoryBulletCount].SetActive(false);

            if (_currentMemoryBulletCount <= 0)
            {
                MemoryBullet.OnMemoryBulletUsed -= NewGiveMemory;
                this.gameObject.SetActive(false);
            }
        }
    }
}
