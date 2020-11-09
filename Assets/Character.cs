using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public GameObject GameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            //transform.position += new Vector3(0, 0, Time.deltaTime * speed);
            transform.position += transform.forward * speed * Time.deltaTime;

        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, Time.deltaTime * -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * rotateSpeed , 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            // transform.position += new Vector3(0, Time.deltaTime * rotateSpeed, 0);
            transform.Rotate(new Vector3(0, Time.deltaTime * -rotateSpeed, 0));
        }
        GameText.GetComponent<Text>().text = "position: " + transform.position;
    }
}
