using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float rotateSpeed;
    private float currentRotateSpeed;
    private Collider2D colliderOfPlayerBody;
    // Start is called before the first frame update
    void Start()
    {
        currentRotateSpeed = rotateSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,currentRotateSpeed*Time.deltaTime,Space.Self);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentRotateSpeed = -currentRotateSpeed;
        }
       
    }
   
}
