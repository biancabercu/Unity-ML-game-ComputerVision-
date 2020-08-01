using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public TextMeshProUGUI scoretext;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position.z);
        scoretext.text = player.position.z.ToString("0");
    }
}
