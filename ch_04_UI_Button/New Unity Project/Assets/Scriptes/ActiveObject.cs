using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveObject : MonoBehaviour {

    public GameObject cube;
    
    public void on()
    {
        cube.SetActive(true);
    }

    public void off()
    {
      cube.SetActive(false);
    }

}
