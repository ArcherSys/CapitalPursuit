using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mixtape : MonoBehaviour {
    public AudioSource[] audios;
  
    private int songIndex = 0;
    public Slider musicMixer;

    // Use this for initialization
    void Start () {
	
	}
	public void SetSongdex()
    {
        audios[songIndex].Stop();
        songIndex = (int) musicMixer.value;
      
    }
    public void Play()
    {
        audios[songIndex].Play();
    }
	// Update is called once per frame
	void Update () {
        
	}
}
