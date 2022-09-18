using UnityEngine;

namespace Player.Shot
{
    public class SingleShot : IShot
    {
        public void Shoot()
        {
            Debug.Log("Single Shot");
        }
    }
}
