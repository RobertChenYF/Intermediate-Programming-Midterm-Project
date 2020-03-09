using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnnedSquareScript : MonoBehaviour
{
    [SerializeField] private float speed;
    public float length;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1,length*8.5f,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        if (transform.position.x < -11 )
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("hit enemy");
        }
    }
}
