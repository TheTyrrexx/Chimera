using UnityEngine;
using System.Collections;

public class TrackPlayer : MonoBehaviour
{
  public Vector2 playerPosition;
  public Vector2 playerDirection;
  public bool willRotate = true;
  GameObject player;

	// Use this for initialization
	void Start ()
  {
    player = GameObject.Find("Leon");
	}
	
	// Update is called once per frame
	void Update ()
  {

    getPlayerPosition();
    getPlayerDirection();
    if(willRotate)
    {
      lookAtPlayer();
    }
	}

  public Vector2 getPlayerPosition()
  {
    playerPosition = player.transform.position;
    return playerPosition;
  }

  public Vector2 getPlayerDirection()
  {
    playerDirection = playerPosition - (Vector2)transform.position;
    return playerDirection;
  }

  public void lookAtPlayer()
  {
    float angle = Mathf.Atan2(playerDirection.y, playerDirection.x) * Mathf.Rad2Deg;
    transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
  }
}
