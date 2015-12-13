using UnityEngine;
using System.Collections;

public class CanvasInstantiator : MonoBehaviour {
    public GameObject canvasPrefab;
    private GameObject canvas_main;

    // Use this for initialization
    void Start () {
        canvas_main = Instantiate(canvasPrefab);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
