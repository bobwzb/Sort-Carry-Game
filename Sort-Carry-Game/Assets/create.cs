using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject current_ball;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;
    private int flag;
    public float curtime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curtime == 0)
        {
            curtime = Time.time;
        }
        if (Time.time - curtime > 0.8f && curtime != 0)
        {
            flag = Random.Range(0, 3);
            if (flag == 0)
            {
                current_ball = ball1;
            }
            else if (flag == 1)
            {
                current_ball = ball2;
            }
            else if (flag == 2)
            {
                current_ball = ball3;
            }
            if (this.name == "Line1")
            {
                current_ball = Instantiate(current_ball, this.transform.position, new Quaternion(0, 0, 0, 0));
                current_ball.GetComponent<Rigidbody2D>().velocity = new Vector2(-3, 0);
            }
            if (this.name == "Line2")
            {
                current_ball = Instantiate(current_ball, this.transform.position, new Quaternion(0, 0, 0, 0));
                current_ball.GetComponent<Rigidbody2D>().velocity = new Vector2(3, 0);
            }
            curtime = 0;
        }
    }
}
