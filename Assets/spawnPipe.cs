using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipe : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float spawnCountTimer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnCountTimer > 1)
        {
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(3, -3), transform.position.z), transform.rotation) ;
            spawnCountTimer = 0;
        }
        else
        {
            spawnCountTimer += Time.deltaTime;
        }
       
    }
}
