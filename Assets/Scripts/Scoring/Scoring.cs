using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour 
{
    private float score;
    private float multi;

	// Use this for initialization
	void Start () 
    {
        score = 0;
        multi = 1;
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.Log("Score: " + score);
	}

    public void addPoints(float tempPoints)
    {
        score += tempPoints * multi;
    }

    void checkMultiplier()
    {

    }

    public float getScore()
    {
        return score;
    }

    public float getMulti()
    {
        return multi;
    }
}
