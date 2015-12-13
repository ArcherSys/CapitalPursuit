using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets._2D;
using System.Collections;

public class LevelIndicator : MonoBehaviour
{
    public Text xt;
    public TextMesh[] LeveLLabels;
    public UnityStandardAssets._2D.PlatformerCharacter2D player;
    private int i = 0;
    void Start()
    {
        player = GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>();
        LeveLLabels = GetComponents<TextMesh>();

    }
    void Update()
    {
        while (i < LeveLLabels.Length)
        {
            if (player.transform.position.x == LeveLLabels[i + 1].transform.position.x)
            {
                Debug.Log("Level " + i + 2);
                xt.text = "Level " + (i + 2).ToString();
                i++;
            }
        }
    }
}