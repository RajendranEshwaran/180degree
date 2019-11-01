using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeployObjects : MonoBehaviour
{
	public GameObject[] objPrefab;
	private GameObject tempObject;
    public Text scoreText;
	public float respawnTime = 2.0f;
	private Vector2 screenBounds;
	private int randEnemy;
	bool spawn = false;
    public int values;
    // Use this for initialization
    void Start()
	{
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
		StartCoroutine(asteroidWave());
	}
	private void spawnEnemy()
	{
		spawn = true;
		randEnemy = Random.Range(0, 14);
		tempObject = Instantiate(objPrefab[randEnemy]) as GameObject;
		tempObject.transform.position = new Vector2(Random.Range( screenBounds.x - 0.8f ,-screenBounds.x + 0.8f), screenBounds.y);
	}
	IEnumerator asteroidWave()
	{
		while (true)
		{
			yield return new WaitForSeconds(respawnTime);
			spawnEnemy();
		}
	}


}
