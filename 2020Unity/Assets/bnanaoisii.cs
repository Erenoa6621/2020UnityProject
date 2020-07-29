using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bnanaoisii : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject banan;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            Instantiate(banan,this.gameObject.transform.position, Quaternion.identity);
        }
    }
}
