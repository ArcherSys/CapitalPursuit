using UnityEngine;
using System.Collections;
using ArcherSysOS.DDG.CapitalPursuit.Nav;
/// <summary>
/// A component for adding very fragile collision detection code to a sprite posing as Metro(WMATA) Transit Police 
/// </summary>
public class Transit : MonoBehaviour {
    public Animator Anim;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        

	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            Destroy(coll.gameObject);
            Application.LoadLevel("Game Over");
        }
       
    }
}
