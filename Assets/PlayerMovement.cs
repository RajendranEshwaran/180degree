using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField]
	float moveSpeed = 5f;

    public AudioSource source;
	Rigidbody2D rb;
    public ParticleSystem par;
	Touch touch;
	Vector3 touchPosition, whereToMove;
	bool isMoving = false;
	bool isStarted = false;
	float previousDistanceToTouchPos, currentDistanceToTouchPos;
	private Vector2 screenBounds;
	public Text text;
	//public Text text1;

    float minX;
    float maxX;
    float minY;
    float maxY;
    Renderer m_Renderer;
    public Vector2 widthThresold;
    public Vector2 heightThresold;
    bool isCoroutineReady;
    bool checkIfPSPlaying = false;
    void Start()
	{
       
        rb = GetComponent<Rigidbody2D>();
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,Camera.main.transform.position.z));
        Debug.Log(Screen.width + "==" + Screen.height );

        minX = screenBounds.x; //left
        maxX = -screenBounds.x; // right
        minY = screenBounds.y; // up
        maxY = -screenBounds.y; // down
        Debug.Log(minY);
        Debug.Log(maxY);
        Debug.Log(minX);
        Debug.Log(maxX);
        m_Renderer = GetComponent<Renderer>();
        isCoroutineReady = false;

    }

	void Update()
	{

        if (!isCoroutineReady)
        {

            //if (isMoving)
            //	currentDistanceToTouchPos = (touchPosition - transform.position).magnitude;

            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    previousDistanceToTouchPos = 0;
                    currentDistanceToTouchPos = 0;
                    isMoving = true;
                    touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    touchPosition.z = 0;
                    whereToMove = (touchPosition - transform.position).normalized;
                    rb.velocity = new Vector2(whereToMove.x * moveSpeed, whereToMove.y * moveSpeed);

                }
            }
            else
            {
                if (!isStarted)
                {
                    isStarted = true;

                    int rand = Random.Range(0, 2);
                    if (rand == 0)
                        rb.velocity = new Vector2(-0.9f * 2.0f, 0.9f * 2.0f);
                    else
                        rb.velocity = new Vector2(1.5f * 2.0f, 1.1f * 2.0f);
                }
            }


            if (transform.position.y < maxY)
            {
                gameOver();
                isCoroutineReady = true;
            }
            if (transform.position.y > minY)
            { 
                gameOver();
                isCoroutineReady = true;
            }
            if (transform.position.x > minX)
            {
                
                gameOver();
                isCoroutineReady = true;

            }
            if (transform.position.x < maxX)
            {
                gameOver();
                isCoroutineReady = true;


            }
        }
    }

    void gameOver()
    {
        par.transform.position = transform.position;
        par.Play();
        Explode();
        Invoke("gameexit", 1.0f);
      
    }

    void gameexit()
    {
        Destroy(this.gameObject);
        SceneManager.LoadScene("GameStart");

    }
    void Explode()
    {

        source.Play();
    }
}
