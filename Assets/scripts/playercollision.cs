using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//rigid body + collider
//GameObject.FindGameObjectsWithTag("Respawn"); //find object by tag
//punem tag florilor
public class playercollision : MonoBehaviour
{
    public Character_Animations_Human movement;
    //public float points;
    public int Score = 0;
    public TextMeshProUGUI scoretext;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        scoretext.text = Score.ToString();
    }
    void OnTriggerEnter (Collider collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "1")
        {
            Destroy(collisionInfo.gameObject);
            Score+=5;
            //ScoreText.text = Score.ToString();
        }
        if (collisionInfo.gameObject.tag == "2")
        {
            Destroy(collisionInfo.gameObject);
            Score += 2;
           // ScoreText.text = Score.ToString();
        }
        if (collisionInfo.gameObject.tag == "3")
        {
            Destroy(collisionInfo.gameObject);
            Score += 1;
           //ScoreText.text = Score.ToString();
        }
        if (collisionInfo.gameObject.tag == "5")
        {
            Destroy(collisionInfo.gameObject);
            Score -= 5;
            //ScoreText.text = Score.ToString();
        }
        if (collisionInfo.gameObject.tag == "6")
        {
            Destroy(collisionInfo.gameObject);
            Score -= 2;
            //ScoreText.text = Score.ToString();
        }
        
    }

    
}
