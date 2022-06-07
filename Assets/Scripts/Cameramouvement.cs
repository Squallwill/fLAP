using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramouvement : MonoBehaviour
{
    public Transform birdTransform;
    Vector3 range;
    private void Awake()
    {
        range = transform.position - birdTransform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);
    }
}
