using UnityEngine;
using System.Collections;

public class SnipeShot : MonoBehaviour
{
  public GameObject bullet;

  public float bulletSpeed;
  public Vector2 bulletDirection;

  private float timeLastBullet;
  public float bulletDelay;

  // Use this for initialization
  void Start ()
  {
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
    //Need to remove track player from here
    Vector2 playerPos = GetComponent<TrackPlayer>().playerPosition;
    bulletDirection = playerPos - (Vector2)transform.position;
    timeLastBullet = 0.0f;
    GameObject b = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
    b.GetComponent<BulletPhysics>().init(bulletDirection.normalized, bulletSpeed);
  }
}
