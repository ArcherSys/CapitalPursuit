using UnityEngine;
using System.Collections;

public class DropbGO : MonoBehaviour {
    public Transform Enemy;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   if(transform.position.x -  Enemy.transform.position.x <= 2.0f)
        {
            Application.LoadLevel("Game Over");
        }
	}
}
