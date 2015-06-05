using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour 
{
    string staticText;
    Text scoreText;

    // Use this for initialization
    void Start()
    {
        staticText = "Score: ";
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = staticText + GameObject.Find("Leon").GetComponent<Scoring>().getScore();
    }
}
