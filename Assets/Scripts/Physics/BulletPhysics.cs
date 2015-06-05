using UnityEngine;
using System.Collections;

public class BulletPhysics : MonoBehaviour
{
  private float speed;
  private Vector2 dir;
  public float lifeTime;
  public bool isAlive = true;

	// Use this for initialization
	public void init(Vector2 nDir, float nSpd)
  {
    dir = nDir;
    speed = nSpd;
    Destroy(gameObject, lifeTime);
  }

  void Start ()
  {

	}
	
	// Update is called once per frame
	void Update ()
  {
    if(!isAlive)
    {
      Destroy(gameObject);
    }
	}

  public float getSpeed()
  {
    return speed;
  }

  public Vector2 getDir()
  {
    return dir;
  }

//  void OnCollisionEnter2D(Collision2D c)
//  {
//    var layerName = LayerMask.LayerToName(c.gameObject.layer);
//
//    //Will want to separate
//    if(layerName == "Enemy" && gameObject.name == "Leon")
//    {
//      c.gameObject.GetComponent<BulletPhysics>().isAlive = false;
//      GetComponent<Health>().kill();
//    }
//  }
}
