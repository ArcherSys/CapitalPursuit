using UnityEngine;
using System.Collections;
using ArcherSysOS.DDG.CapitalPursuit.Nav;

public class RedClassObstacle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            DestroyObject(coll.gameObject);
            Application.LoadLevel("Game Over");
            
        }
    }
}
