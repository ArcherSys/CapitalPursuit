using UnityEngine;
using System.Collections;

public class CoinGenerator : MonoBehaviour {


    public GameObject prefab;
    public GameObject Player;
    public float spacing = 10f;
    public float levelcuttoff;
    private float x;
    private int i;

    void Start()
    {
      
        i = 0;
        for (var x = prefab.transform.position.x; x < levelcuttoff; x++)
        {
            
            if (i < 21)
            {
                Vector3 pos = Player.transform.position + new Vector3(10.0f, 0.0f, 0.0f);
                pos.x += (spacing* i);
                
                Instantiate(prefab, pos, Quaternion.identity);
                i++;
            }
            else
            {
                break;
            }
        }
    }
    void Update()
    {

    }


    // Update is called once per frame

}

