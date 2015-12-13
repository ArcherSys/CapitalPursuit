using UnityEngine;
using System.Collections;

public class CoinGC : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	public bool usedUp()
    {
       return transform.childCount == 0;
    }
	// Update is called once per frame
	void Update () {
	if(usedUp())
        {
            DestroyObject(gameObject);
        }
	}
}
 