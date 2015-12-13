using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    [AddComponentMenu("Capital Pursuit/Misc/Restarter")]
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                Application.LoadLevel(Application.loadedLevelName);
            }
        }
    }
}
