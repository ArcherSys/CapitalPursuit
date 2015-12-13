using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Kilometers : MonoBehaviour {
    public Text meter;
    public float m;
	// Use this for initialization
	void Start () {
        meter = GetComponent<Text>();
        m = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        m += 1.0f;
        meter.text = m.ToString() + "M";
	}
}
