using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SlotMachine : MonoBehaviour {
    public Sprite[] SlotSprites;
    public Image[] slots;
	// Use this for initialization
	void Start () {
        slots = GetComponents<Image>();
        while (true)
        {
           
            
            for (var i = 0; i < slots.Length; i++)
            {
                slots[i].sprite = SlotSprites[(int)Random.Range(0.0f, slots.Length)];
            }
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
