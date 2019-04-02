using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addson : MonoBehaviour
{
    // Start is called before the first frame update
    public int flag;
    private int num;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        if (transform.position.magnitude >= 50)
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "attached")
        {
            this.GetComponent<FixedJoint2D>().enabled = true;
            collision.transform.GetComponent<FixedJoint2D>().enabled = true;
            this.transform.parent = collision.transform;
            this.gameObject.tag = "attached";
            flag = 1;
        }
    }
}
