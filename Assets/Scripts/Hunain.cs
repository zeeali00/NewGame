using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.up);
    }
}
