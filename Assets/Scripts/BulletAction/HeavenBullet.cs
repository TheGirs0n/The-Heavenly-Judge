using System;
using UnityEngine;

namespace BulletAction
{
    public class HeavenBulet : MonoBehaviour, IBulletHandler
    {
        public static event Action OnHeavenBulletUsed;
        public void HandleBullet()
        {
            OnHeavenBulletUsed?.Invoke();
        }
    }
}
