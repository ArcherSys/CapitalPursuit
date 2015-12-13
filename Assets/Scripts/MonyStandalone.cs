using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Soomla.Store;
using ArcherSysOS.DDG.CapitalPursuit.Accounting;


public class MonyStandalone: MonoBehaviour
{

    public bool simulateIAPSystem;
    
    // Use this for initialization
    void Start()
    {
     
       
    }

    // Update is called once per frame
    void Update()
    {

    }
 void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            
                PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);
            
        }
    }
            
         
        
    
}
