using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    private Transform cubeTransform;
    private float zPos = 0;

    void Start()
    {
        cubeTransform = cube.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeTransform.position = new Vector3(0, 0, zPos);
        zPos = zPos + 0.0001f;
    }
}
