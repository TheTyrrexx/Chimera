using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeText : MonoBehaviour 
{
    Text timeText;
    string staticText;
    float timePlayed;

	// Use this for initialization
	void Start () 
    {
        timePlayed = 0.0f;
        timeText = GetComponent<Text>();
        staticText = "Time: ";
	}
	
	// Update is called once per frame
	void Update () 
    {
        timePlayed += Time.deltaTime;
        timeText.text = staticText + (int)timePlayed;
	}
}
