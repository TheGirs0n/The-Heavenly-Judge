using System;
using UnityEngine;

namespace BulletAction
{
    public class MemoryBullet : MonoBehaviour, IBulletHandler
    {
        public static event Action OnMemoryBulletUsed;
        public void HandleBullet()
        {
            OnMemoryBulletUsed?.Invoke();
        }
    }
}
