using UnityEngine;
using System.Collections;

public class TrainLevelGenerator : MonoBehaviour {
    public GameObject trainset;
	// Use this for initialization
	void Start () {
	  for(var x = trainset.transform.position.x; x < trainset.transform.position.x + 2001; x++)
        {
            Vector3 pos = transform.position;
            pos.x += 481f;
            Instantiate(trainset, pos, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
