using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject player;
    public static int score;
    public int points;
    public int a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<GameObject>();
            points += 1;
            LevelManager.AddPoints(a);
            LevelManager.score += 1;
            Destroy(gameObject);
        }
    }

}
