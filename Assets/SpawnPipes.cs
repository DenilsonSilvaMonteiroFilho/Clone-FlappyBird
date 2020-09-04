using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{

    public GameObject pipe;
    public float height;
    public float maxTime = 1.5f;

    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {   
        //Timer for geration pipes
        //Pipes spawn when be timer > maxtime
        if(timer > maxTime){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            //Destroy piper when passing the player and reach time
            Destroy(newPipe, 20f);
            timer = 0;
        }

        //Reset variable time
        timer += Time.deltaTime;
    }
}
