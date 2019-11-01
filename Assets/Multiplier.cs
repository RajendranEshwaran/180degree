using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour
{
    public GameObject player;
    public GameObject[] objPrefab;
    private GameObject tempObject;
    public float spawnTime = 1.0f;
    private Vector2 screenBounds;
    private int randMultipier;
   
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //StartCoroutine(startMultipier());
    }

    private void spawnMultipier()
    {
        randMultipier = Random.Range(0, 1);
        tempObject = Instantiate(objPrefab[randMultipier]) as GameObject;
        tempObject.transform.position = new Vector2(Random.Range(screenBounds.x - 0.8f, -screenBounds.x + 0.8f), Random.Range(screenBounds.y - 0.8f, -screenBounds.y + 0.8f));
        
    }
    IEnumerator startMultipier()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnMultipier();
           
        }
    }

    
    void endMultipier()
    {
        while (true)
        {
            Debug.Log("end mUl");
           // Destroy(this.tempObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision With Trigger Player and 1X");
    }

}
