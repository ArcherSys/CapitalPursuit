using UnityEngine;
using System.Collections;

public class RCOGenerator : MonoBehaviour {
    public GameObject prefab;
    public float spacing = 10f;
    public float levelcuttoff;
    private float x;
    private int i;

    void Start()
    {

        if (prefab.CompareTag("RCO"))
        {
            i = 0;
            for (var x = prefab.transform.position.x; x < levelcuttoff; x++)
            {

                if (i < 31)
                {
                    Vector3 pos = prefab.transform.position;
                    pos.x += (spacing * i);
                    pos.y = 8.48f;
                    Instantiate(prefab, pos, Quaternion.identity);
                    i++;
                }
                else
                {
                    break;
                }

            }
            }else{

            }
        
        }
      
    
    void Update()
    {

    }

}
