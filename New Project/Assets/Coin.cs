using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Coin : MonoBehaviour
{

    float time = 0;

    void Update()
    {
        float startYPos = 1f;
        float yPos = startYPos + (float)Math.Sin(time);
        Vector3 position = transform.position;
        position.y = yPos;
        transform.position = position;

        time += Time.deltaTime;
    }

    // Start is called before the first frame update
     void OnTriggerEnter(Collider other) {
        if (other.tag == "Player"){
            other.GetComponent<Player>().AddPoints(10);
            Destroy(gameObject);
        }
        

    }

}
