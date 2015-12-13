using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using Soomla.Store;

namespace ArcherSysOS.DDG.CapitalPursuit.Accounting
{
    [AddComponentMenu("Capital Pursuit/Accounts/Wallet")]

    public class Wallet : MonoBehaviour
    {
       
      public  void DonateAllFunds()
        {
            PlayerPrefs.SetInt("Coins", 0);
        }
     

        ~Wallet()
        {
            Debug.Log("Wallet lost!");
        }
        // Use this for initialization
        void Start()
        {

       
         
        }
        public static int getBalance()
        {
            return PlayerPrefs.GetInt("Coins");
        }
        public static void deposit(int amount)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + 1);

        }
      
        // Update is called once per frame
        void Update()
        {
        
        }
        
    }
}