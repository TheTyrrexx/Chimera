using UnityEngine;
using System.Collections;

public class ShootingInput : MonoBehaviour
{
  public GameObject bullet;

  public float bulletSpeed;

  private float timeLastBullet;
  public float bulletDelay;

	// Use this for initialization
	void Start ()
  {
	
	}
	
	// Update is called once per frame
	void Update ()
  {
	
	}

  public void shoot(Transform origin, Vector3 dir)
  {
    if (timeLastBullet >= bulletDelay)
    {
      timeLastBullet = 0.0f;
      GameObject b = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
      b.GetComponent<BulletPhysics>().init(dir, bulletSpeed);
    }
    timeLastBullet += Time.deltaTime;
  }
}
