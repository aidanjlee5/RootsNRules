using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PebblesScript : MonoBehaviour
{
    public GameObject Pebble1;
    public GameObject Pebble2;
    public GameObject Pebble3;
    public GameObject Pebble4;
    public GameObject Pebble5;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Pebble4, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
