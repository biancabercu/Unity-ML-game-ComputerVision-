using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LevelManager : MonoBehaviour
{
    public static int score;
    GameObject player;
    public TextMeshProUGUI pointstext;
    // Start is called before the first frame update
    void Awake()
    {
        if (Application.loadedLevelName == "Level1")
        {
            PlayerPrefs.SetInt("CurrentPlayerScore1", 0);
        }
        else
            PlayerPrefs.SetInt("CurrentPlayerScore1", LevelManager.score);
        // Do the other stuff you already do
    }
    void Start()
    {
        player = FindObjectOfType<GameObject>();
        score = PlayerPrefs.GetInt("CurrentPlayerScore1", LevelManager.score);
        
    }

    // Update is called once per frame
    void Update()
    {
        //pointstext.text = ("Scor: " + player.points);
       pointstext.text = "Scor: " + score;
    }
    public static void AddPoints(int a)
    {
        score += a;
        PlayerPrefs.SetInt("CurrentPlayerScore1", LevelManager.score);
    }
    public static void Reset()
    {
        LevelManager.score = 0;
        
    }
}
