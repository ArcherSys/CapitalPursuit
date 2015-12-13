using UnityEngine;
using System.Collections;
using System;

namespace ArcherSysOS.DDG.Capitalpursuit.Universal.Mobilization
{
    public class TouchMobilizer : MonoBehaviour
    {
        private bool finali;

        // Use this for initialization
       
        public void getJumpMobile(Action onTouch)
        {
            for (var i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    onTouch();
                }

            }
           
        }
        public bool  getJumpMobile()
        {
            for (var i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    finali =  true;
                }
                else
                {
                    finali =  false;
                }
               
            }

            // Update is called once per frame
            return finali;

        }
    }
}
