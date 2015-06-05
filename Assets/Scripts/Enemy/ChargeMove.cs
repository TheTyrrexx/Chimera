using UnityEngine;
using System.Collections;

public class ChargeMove : MonoBehaviour
{
  public bool charging = false;

  public Vector2 chargeDir;
  public float movementVelocity = 0.15f;

  private float timeLastCharge;
  public float chargeDelay;

	// Use this for initialization
	void Start ()
  {
    GetComponent<Rigidbody2D>().fixedAngle = true;
	}
	
	// Update is called once per frame
	void Update ()
  {
    if(!charging)
    {
      if (timeLastCharge >= chargeDelay)
      {
        charge();
      }
      timeLastCharge += Time.deltaTime;
    }

    if(charging)
    {
      GetComponent<Rigidbody2D>().velocity = chargeDir.normalized * movementVelocity;
    }
	}

  void charge()
  {
    charging = true;
    chargeDir = GetComponent<TrackPlayer>().getPlayerDirection();
    GetComponent<TrackPlayer>().lookAtPlayer();
    timeLastCharge = 0f;
  }

  void OnCollisionEnter2D(Collision2D c)
  {
    var layerName = LayerMask.LayerToName(c.gameObject.layer);

    if(layerName == "ArenaWall")
    {
      charging = false;
      GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
  }
}
