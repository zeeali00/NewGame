using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inheritanceFour : bac
{
    // Start is called before the first frame update
    public bac Parent;

    

    inheritanceFour() 
    {
      
    }


    [ContextMenu("Start")]
    void Start()
    {
        bac bac = new bac();
        bac.objecte = this.objecte;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
