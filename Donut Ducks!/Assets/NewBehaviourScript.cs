using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Vector3 coordinates;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 relativeCoordinates = coordinates - transform.parent.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
