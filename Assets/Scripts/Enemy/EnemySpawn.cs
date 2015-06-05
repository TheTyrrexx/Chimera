using UnityEngine;
using System.Collections;
using System;

public class EnemySpawn : MonoBehaviour
{
  private float timeLastEnemy;
  public float enemyDelay;

  public GameObject harpy;
  public GameObject centaur;
  public GameObject gemini;
  public GameObject gorgon;
  public GameObject hydra;
  public GameObject minotaur;
  public GameObject pegasus;
  public GameObject pheonix;
  public GameObject siren;

  System.Random rand;

	// Use this for initialization
	void Start ()
  {
    rand = new System.Random(Guid.NewGuid().GetHashCode());
	}
	
	// Update is called once per frame
	void Update ()
  {
    if(timeLastEnemy >= enemyDelay)
    {
      timeLastEnemy = 0.0f;
      spawnEnemy();
    }
    timeLastEnemy += Time.deltaTime;
	}

  void spawnEnemy()
  {
    var type = rand.Next(1, 9);

    if(type == 1)
    {
      spawnHarpy();
    }
    else if(type == 2)
    {
      spawnCentaur();
    }
    else if(type == 3)
    {
      spawnPegasus();
    }
    else if(type == 4)
    {
      spawnGemini();
    }
    else if(type == 5)
    {
      spawnSiren();
    }
    else if(type == 6)
    {
      spawnHydra();
    }
    else if(type == 7)
    {
      spawnMinotaur();
    }
    else if(type == 8)
    {
      spawnPheonix();
    }
  }

  void spawnCentaur()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newCentaur = (GameObject)Instantiate(centaur, spawnPos, Quaternion.identity);
    newCentaur.name = "Centaur";
  }

  void spawnGemini()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newGemini = (GameObject)Instantiate(gemini, spawnPos, Quaternion.identity);
    newGemini.name = "Gemini";
  }

  void spawnGorgon()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newGorgon = (GameObject)Instantiate(gorgon, spawnPos, Quaternion.identity);
    newGorgon.name = "Gorgon";
  }

  void spawnHarpy()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newHarpy = (GameObject)Instantiate(harpy, spawnPos, Quaternion.identity);
    newHarpy.name = "Harpy";
  }

  void spawnHydra()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newHydra = (GameObject)Instantiate(hydra, spawnPos, Quaternion.identity);
    newHydra.name = "Hydra";
  }

  void spawnMinotaur()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newMinotaur = (GameObject)Instantiate(minotaur, spawnPos, Quaternion.identity);
    newMinotaur.name = "Minotaur";
  }

  void spawnPegasus()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newPegasus = (GameObject)Instantiate(pegasus, spawnPos, Quaternion.identity);
    newPegasus.name = "Pegasus";
  }

  void spawnPheonix()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newPheonix = (GameObject)Instantiate(pheonix, spawnPos, Quaternion.identity);
    newPheonix.name = "Pheonix";
  }

  void spawnSiren()
  {
    //var xPos = rand.Next(-10, 10);
    //var spawnPos = new Vector3(xPos, -15.0f, 0.0f);
    var spawnPos = transform.position;
    GameObject newSiren = (GameObject)Instantiate(siren, spawnPos, Quaternion.identity);
    newSiren.name = "Siren";
  }
}
