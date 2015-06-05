using UnityEngine;
using System.Collections;
using System;

public class RandomShot : MonoBehaviour
{
  public GameObject bullet;

  public float bulletSpeed;
  public Vector2 bulletDirection;

  private float timeLastBullet;
  public float bulletDelay;

  System.Random rand;

  // Use this for initialization
  void Start ()
  {
    rand = new System.Random(Guid.NewGuid().GetHashCode());
  }

  // Update is called once per frame
  void Update ()
  {
    if (timeLastBullet >= bulletDelay)
    {
      shoot(transform);
    }
    timeLastBullet += Time.deltaTime;
  }

  public void shoot(Transform origin)
  {
    //Vector2 playerPos = GetComponent<TrackPlayer>().playerPosition;
    //bulletDirection = playerPos - (Vector2)transform.position;

    timeLastBullet = 0.0f;

    var startSignX = rand.Next(2);
    var startSignY = rand.Next(2);
    var startDirX = rand.NextDouble();
    var startDirY = rand.NextDouble();

    if(startSignX == 1)
    {
      startDirX = -startDirX;
    }

    if(startSignY == 1)
    {
      startDirY = -startDirY;
    }

    for(int i = 0; i < 4; i++)
    {
      bulletDirection = new Vector2((float)startDirX, (float)startDirY);
      GameObject b1 = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
      b1.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);
    }
  }
}
