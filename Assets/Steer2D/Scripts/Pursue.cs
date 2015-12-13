using System;
using UnityEngine;
using UnityStandardAssets._2D;
namespace Steer2D
{
    public class Pursue : SteeringBehaviour
    {
        public SteeringAgent TargetAgent;
        UnityStandardAssets._2D.PlatformerCharacter2D player;

        public override Vector2 GetVelocity()
        {

            if (TargetAgent)
            {
                float t = Vector3.Distance(transform.position, TargetAgent.transform.position) / TargetAgent.MaxVelocity;
                Vector2 targetPoint = (Vector2)TargetAgent.transform.position + TargetAgent.CurrentVelocity * t;

                return ((targetPoint - (Vector2)transform.position).normalized * agent.MaxVelocity) - agent.CurrentVelocity;
                if (TargetAgent.transform.position.x < transform.position.x)
                {
                    player.Flip();

                }
            }
            else
            {
                Debug.Log("Idle");
                DestroyObject(gameObject);
                return Vector2.zero;
            }
        }
            
    }
}
