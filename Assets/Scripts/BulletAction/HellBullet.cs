using System;
using UnityEngine;

namespace BulletAction
{
    public class HellBullet : MonoBehaviour, IBulletHandler
    {
        public static event Action OnHellBulletUsed;
        public void HandleBullet()
        {
            OnHellBulletUsed?.Invoke();
        }
    }
}
