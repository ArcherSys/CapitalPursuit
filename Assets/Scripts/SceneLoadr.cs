using UnityEngine;
using System.Collections;
namespace ArcherSysOS.DDG.CapitalPursuit.Nav
{
    [AddComponentMenu("Capital Pursuit/Navigation/SceneLoadr")]
    public class SceneLoadr : MonoBehaviour
    {
        public enum QuitStatus
        {
            EDITOR = 0,
            RUNTIME = 1,
        }
        private int scene;
        // Use this for initialization
        void Start()
        {
            scene = 1;
            Profiler.maxNumberOfSamplesPerFrame = 8000000 ;
        }

        // Update is called once per frame
        void Update()
        {

        }
        void loadGame()
        {
            Application.LoadLevel("Round 1");
        }
        public void loadSingleplayerGame()
        {
            gameObject.SetActive(false);
            loadScenery(3);
        }
       public void loadScenery(string scene)
        {
            Application.LoadLevel(scene);
          
        }
        public void restartGame()
        {
            Application.LoadLevel(Application.loadedLevelName);
        }
        public void loadScenery(int index)
        {
            Application.LoadLevel(index);

        }
        public void loadSceneryWhileRiddingUI(string scene,StartOptions menu)
        {
            DestroyObject(menu);
            loadScenery(scene);
           
        }
        public void Quit()
        {
#if UNITY_STANDALONE 
            Application.Quit();
#endif
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif


        }

    }
}