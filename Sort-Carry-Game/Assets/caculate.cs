using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class caculate : MonoBehaviour
{
    // Start is called before the first frame update
    public int point;
    public int current_point;
    public Text te;
    private Transform[] son;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name== "Health_0")
        {
            son = collision.gameObject.GetComponentsInChildren<Transform>();
            current_point = (int)((1 + 0.2 * son.Length) * son.Length);
            if (son.Length > 1)
            {
                point += current_point;
                te.text = point.ToString();
                foreach (Transform child in son)
                {
                    if (child.name != "Health_0")
                    {
                        Destroy(child.gameObject);
                    }
                }
            }
        }
    }
}
