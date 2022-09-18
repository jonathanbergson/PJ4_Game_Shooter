using UnityEngine;

namespace Shot
{
    public class SingleShot : IShot
    {
        public void Shoot()
        {
            Debug.Log("Tiro simples");
        }
    }
}
