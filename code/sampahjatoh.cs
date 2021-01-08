using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampahjatoh : MonoBehaviour
{
    public float interval;
    public GameObject objectToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating ("SpawnObject", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObject(){
        float randomX =Random.Range (0f,1150f);
        Vector2 posisiRandom = new Vector2 (randomX, 918f);
        Instantiate (objectToSpawn, posisiRandom, transform.rotation);
    }

}
