using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kodsampah : MonoBehaviour
{
    private Rigidbody2D myBody;
    public float speed, xBound;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        if(Input.GetButtonDown("d"))
        {
             transform.position += Vector3.right * speed * Time.deltaTime;
        }

        else if(Input.GetButtonDown("a"))
        {
             transform.position += Vector3.left * speed * Time.deltaTime;
        }

        /*else if(Input.GetButtonDown("s")) {
             transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else if (Input.GetButtonDown("w"))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }*/
        /*if(Input.GetButtonDown("d"))
        {
            Vector2.transform.Translate(1, 0);
        }

        else if(Input.GetButtonDown("a"))
        {
            Vector2.transform.Translate(-1, 0);
        }
        else{
            Vector2.transform.Translate(0, 0);
        }*/
        /*float h = Input.GetAxisRaw("Horizontal");

        if (h > 0) 
            myBody.velocity = Vector2.right * speed;

        else if (h < 0)
            myBody.velocity = Vector2.left * speed;
        else
            myBody.velocity = Vector2.zero;
         transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound),transform.position.y);

        print(h);*/
    }

}
