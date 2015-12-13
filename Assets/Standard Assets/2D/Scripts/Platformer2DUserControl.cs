using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [AddComponentMenu("Capital Pursuit/Characters/User Input/User Control")]
    [RequireComponent(typeof (Sprite))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;
    
        

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
            PlayerPrefs.SetFloat("PSpeed",1.0f);
        }


        private void Update()
        {
            if (!m_Jump)
            {

                // Read the jump input in Update so button presses aren't missed.
                m_Jump = Input.GetKey(KeyCode.Space) || CrossPlatformInputManager.GetButton("Jump");
            }
          
        }
    

        void FixedUpdate()
        {

            // Read the inputs.
            bool crouch = Input.GetKey(KeyCode.LeftControl);


            if (PlayerPrefs.GetString("ControlMode") != "Autopilot")
            {
                float h = CrossPlatformInputManager.GetAxis("Horizontal");
                m_Character.Move(h, crouch, m_Jump);
            }
            else
            {
                crouch = Input.GetKey(KeyCode.LeftControl);
                float h = 1.0f;
                m_Character.Move(h, crouch, m_Jump);
            }

            // Pass all parameters to the character control script.

            m_Jump = false;
        }
       
    }

}
