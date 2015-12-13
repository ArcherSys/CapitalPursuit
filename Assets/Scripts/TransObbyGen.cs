using UnityEngine;
using System.Collections;

public class TransObbyGen : MonoBehaviour {
    public Transit prefab;
    public float startingPoint;
    public float increment;
	// Use this for initialization
	void Start () {
        Instantiate(prefab, new Vector3(startingPoint, 15, 0),Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
