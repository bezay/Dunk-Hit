using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class TapController : MonoBehaviour {

    public float tapForce = 10;
    public float tiltSmooth = 5;
    public Vector3 startPos;
  
    //public Text score;

    Rigidbody2D rigidBody;
    Quaternion downRoatation;
    Quaternion forwardRotation;
    public Transform target;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        downRoatation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

              transform.rotation = forwardRotation;
              rigidBody.velocity = Vector2.zero;
              rigidBody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
              rigidBody.AddForce(Vector2.right * tapForce, ForceMode2D.Force);
            /*  Vector3 targetDir = target.position - transform.position;
              float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
              Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
              transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);

              transform.Translate(Vector3.up * Time.deltaTime * 2);*/
        }
        // transform.rotation = Quaternion.Lerp(transform.rotation, downRoatation, tiltSmooth * Time.deltaTime);
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ScoreZone")
        {
           
        }
      
    }
}
