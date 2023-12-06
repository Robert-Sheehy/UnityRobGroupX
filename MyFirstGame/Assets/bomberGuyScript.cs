using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bomberGuyScript : MonoBehaviour
{

    private float rotSpeed = 360;
    private float currentSpeed = 3;

    public GameObject bombCloneTemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, -rotSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.position += currentSpeed * transform.forward * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(bombCloneTemplate, transform.position, transform.rotation);


    }   
}
