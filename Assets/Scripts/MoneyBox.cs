using UnityEngine.UI;
using UnityEngine;
using ArcherSysOS.DDG.CapitalPursuit.Accounting;

public class MoneyBox : MonoBehaviour {
    public Text moneyText;
    public GameObject Speed;
    public MonyStandalone prefab;
  

    // Use this for initialization
    void Start () {
        moneyText = gameObject.GetComponent<Text>();
       
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        moneyText.text = "Bank: " + ((Application.isMobilePlatform || (Application.isEditor || prefab.simulateIAPSystem == true  ))? Wallet.getBalance() : PlayerPrefs.GetInt("Coins"));

    }

    public void Save()
    {
        PlayerPrefs.Save();
    }
}
