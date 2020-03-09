using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject whiteSquare;
    [SerializeField] private float spawnTimer;
    private float timer;
   
    // Start is called before the first frame update
    void Start()
    {
        //timer = spawnTimer;
        //transform.position = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0 )
        {
            float a = Random.Range(0.2f,0.9f);
            GameObject temp1 = Instantiate(whiteSquare,new Vector3(10,5),Quaternion.identity);
            temp1.GetComponent<SpawnnedSquareScript>().length = a;
            GameObject temp2 = Instantiate(whiteSquare, new Vector3(10, -5), Quaternion.Euler(0,0,180));
            temp2.GetComponent<SpawnnedSquareScript>().length = 1 - a;
            timer = spawnTimer;
        }
        timer -= Time.deltaTime;
    }
    
}
