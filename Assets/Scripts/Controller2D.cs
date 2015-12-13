using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class Controller2D : MonoBehaviour {
    // Use this for initialization
    const float skinWidth = .015f;
    public BoxCollider2D Collider;
    private RaycastOrigins raycastOrigins;
    public int horizontalRayCount = 4;
    public int HorizontalRayCount = 4;

    float horizontalRaySpacing;
    float verticalRaySpacing;

    public LayerMask collisionMask;
    public void Move(Vector3 velocity)
    {
        UpdateRayCastOrigins();
        if(velocity.x != 0) {
            HorizontalCollisions(ref velocity);
        }
        if(velocity.y != 0)
        {
            VerticalCollisions(ref velocity);
        }
        
        transform.Translate(velocity);
    }
    public RaycastOrigins rayCastOrigins
    {
        get
        {
            return raycastOrigins;
        }

        set
        {
            raycastOrigins = value;
        }
    }

    void Start () {
        Collider = GetComponent<BoxCollider2D>();
        CalculateRaySpacing();
    }
	void VerticalCollisions(ref Vector3 velocity)
    {

        float directionY = Mathf.Sign(velocity.y);
        float rayLength = Mathf.Abs(velocity.y) + skinWidth;
        for (int i = 0; i < HorizontalRayCount; i++)
        {
            Vector2 rayOrigin = (directionY == -1)?rayCastOrigins.bottomLeft:raycastOrigins.topLeft;
            rayOrigin += Vector2.right * (verticalRaySpacing *  i + velocity.x);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up * directionY, rayLength,collisionMask);
            Debug.DrawRay(rayOrigin, Vector2.up * directionY  * rayLength, Color.red);

            if (hit)
            {
                velocity.y = (hit.distance - skinWidth) * directionY;
                rayLength = hit.distance;
            }
        }
    }

    void HorizontalCollisions(ref Vector3 velocity)
    {

        float directionX = Mathf.Sign(velocity.x);
        float rayLength = Mathf.Abs(velocity.x) + skinWidth;
        for (int i = 0; i < horizontalRayCount; i++)
        {
            Vector2 rayOrigin = (directionX == -1) ? rayCastOrigins.bottomLeft : raycastOrigins.bottomRight;
            rayOrigin += Vector2.up * (horizontalRaySpacing * i);
            RaycastHit2D hit = Physics2D.Raycast(rayOrigin, Vector2.up * directionX, rayLength, collisionMask);

            if (hit)
            {
                velocity.x = (hit.distance - skinWidth) * directionX;
                rayLength = hit.distance;
            }
        }
    }
    // Update is called once per frame
    void Update () {
      
       
      
	}
    void CalculateRaySpacing()
    {
        Bounds bounds = Collider.bounds;
        bounds.Expand(skinWidth * -2);
        horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);

        HorizontalRayCount = Mathf.Clamp(HorizontalRayCount, 2, int.MaxValue);
        horizontalRaySpacing = bounds.size.y / (horizontalRayCount - 1);

        verticalRaySpacing = bounds.size.y / (HorizontalRayCount - 1);
    }
    void UpdateRayCastOrigins()
    {
        Bounds bounds = Collider.bounds;
        bounds.Expand(skinWidth * -2);

        raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
        raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.min.y);
        raycastOrigins.topLeft  = new Vector2(bounds.min.x, bounds.max.y);
        raycastOrigins.topRight = new Vector2(bounds.min.x, bounds.min.y);
    }
   public struct RaycastOrigins
    {
        public Vector2 topLeft, topRight;
        public Vector2 bottomLeft, bottomRight;
    }
}
