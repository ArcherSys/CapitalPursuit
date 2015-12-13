using UnityEngine;
using System.Collections;

public class BossSpawner : MonoBehaviour {
    public GameObject Boss;
    private Transform player;

    public Object BossLiteral { get; private set; }

    // Use this for initialization
    void Start () {
        if(player.transform.position.x > transform.position.x && (player.transform.position.x - transform.position.x >= 10))
        BossLiteral = (GameObject) Instantiate(Boss, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
