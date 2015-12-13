using UnityEngine;
using System.Collections;

public class Banana : MonoBehaviour {

	// Use this for initialization
	void Start () {
	 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void onCollisionEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Application.LoadLevel("Game Over");
        }
        
    }
}
