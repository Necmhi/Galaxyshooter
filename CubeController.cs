using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeController : MonoBehaviour
{
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
                transform.position = new Vector3(0, 2, 0);

    }

    // Update is called once per frame
    void Update()
    {
       float vertical = Input.GetAxis("Vertical");    
    float horizontal = Input.GetAxis("Horizontal"); 

    
    Vector3 direction = new Vector3(horizontal, vertical, 0);
    transform.Translate(direction * speed * Time.deltaTime);
    }
}
