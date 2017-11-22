using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class TapController : MonoBehaviour {

    public float tapForce = 10f;
    public float tiltSmooth = 100f;
    public Vector3 startPos;

    private int score;
    public Text scoreText;

    Rigidbody2D rigidBody;
   // Quaternion downRoatation;
    Quaternion forwardRotation;
    public Transform target;

    float randx;
    Vector2 whereToSpawn;

    private void Start()
    {
        scoreText.text = "0";
        rigidBody = GetComponent<Rigidbody2D>();
       // downRoatation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

              transform.rotation = forwardRotation;
              rigidBody.velocity = Vector2.zero;
              rigidBody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
            
        }
        //transform.rotation = Quaternion.Lerp(transform.rotation, downRoatation, tiltSmooth * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target.position, tiltSmooth * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "ScoreZone")
            {
               // Destroy(collision.gameObject);
                score += 1;
                scoreText.text = score.ToString();

                randx = Random.Range(-54f, 380f);
                // whereToSpawn = new Vector2(randx, transform.position.y);
                target.localPosition = new Vector3(677f,randx, 0);

        }

           // Destroy(GameObject.FindGameObjectWithTag("Board"));
    }



}
