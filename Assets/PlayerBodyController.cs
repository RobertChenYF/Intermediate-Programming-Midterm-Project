using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("asdadsfsdf ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("hit enemy");
        }
        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("hit enemy");
        }
    }
}
