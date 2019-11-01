using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour {
	public float speed = 2.0f;
	private Rigidbody2D rb;
	private Vector2 screenBounds;
     protected int score;
    private bool spawn = false;
        // Use this for initialization
    void Start()
	{
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0, -speed);
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

	// Update is called once per frame
	void Update()
	{
        transform.Rotate(Vector3.forward * 50.0f * Time.deltaTime);

        if (transform.position.y < -7)
		{

			if (this.gameObject != null)
			{


                ScoreUpdate.scoreValues += 1;
                Destroy(this.gameObject);
              
			}

		}
	}

}

