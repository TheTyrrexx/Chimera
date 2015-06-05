using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour
{
  private bool alive;
  public int lives;

	// Use this for initialization
	void Start ()
    {
        alive = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
	  if(!alive)
        {
        Destroy(gameObject);
        }
	}

  public void kill()
  {
    alive = false;
    //ADD Points
    Points p = GetComponent<Points>();
    if (p != null)
    {
        Scoring score = GameObject.Find("Leon").GetComponent<Scoring>();
        score.addPoints(p.points);
    }
  }
}
