using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inheritanceOne : bac
{
    // Start is called before the first frame update
    [ContextMenu("Start")]
    void Start()
    {
        objecte = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
