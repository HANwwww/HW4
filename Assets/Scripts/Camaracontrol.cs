using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaracontrol : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject target;
    private Vector3 offset;
    void Start()
    {

        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position + offset;
    }
}
