using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followmouse : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform[] son;
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        son = GetComponentsInChildren<Transform>();
        if (son.Length > 1)
        {
            for(int i = 0; i < son.Length-1; i++)
            {
                if (son[i].name != son[i + 1].name&& son[i].name != "Health_0"&& son[i+1].name != "Health_0")
                {
                    foreach (Transform child in son)
                    {
                        if(child.name!= "Health_0")
                        {
                            Destroy(child.gameObject);
                        }
                    }

                }
            }
        }
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(0,0,100*Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(0, 0, -100 * Time.deltaTime);
        }
        Vector3 dis = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
        dis.z = this.transform.position.z; 
        this.transform.position = dis; 
        print(dis); 
        this.transform.position = Vector3.Lerp(this.transform.position, dis, Time.deltaTime);
        this.transform.position = Vector3.MoveTowards(this.transform.position, dis, Time.deltaTime);
        Vector3 speed = Vector3.zero;
        this.transform.position = Vector3.SmoothDamp(this.transform.position, dis, ref speed, 0.1f);
        Debug.Log(speed);
    }
}
