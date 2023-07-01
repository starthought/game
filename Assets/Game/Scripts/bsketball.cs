using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bsketball : MonoBehaviour
{
    public GameObject righthand;
    float timer = 1.16f;
    Vector3 dir = new Vector3(0, 0.03f, -0.02f);
    public GameObject camera1;
    public Animator animator;
    public bool isdrib = false;
    public bool isshoot = false;
    Vector3 down = new Vector3(0, 1f, 0);
    public ShootBasketball _shootbasketball;
    float speed = 1f;
    float move_speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        if(isdrib)
        {
            gameObject.transform.position = righthand.transform.position - dir;
        }
        if (_shootbasketball.isShoot)
        {
            gameObject.transform.position = righthand.transform.position - dir;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isdrib)
        {
            timer += Time.deltaTime;
            if (timer >= 0.3f)
            {
                gameObject.transform.position = righthand.transform.position - dir;
                timer = 0;
            }
            if (timer >= 0.15f && timer <= 0.3f)
            {
                //gameObject.transform.LookAt(righthand.transform.position);
                gameObject.transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
            if (timer <= 0.15f)
            {
                gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                speed = 5f;
            }
            else if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.LeftShift))
            {
                speed = 0.5f;
            }
            else
            {
                speed = 3f;
            }
        }
    }
}
