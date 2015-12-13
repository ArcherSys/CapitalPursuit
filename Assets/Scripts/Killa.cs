using UnityEngine;
using System.Collections;

public class Killa : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = new RaycastHit2D();
        if (hit.collider.CompareTag("Player"))
        {
            DestroyObject(hit.collider.gameObject);
        }
    }
}
    
