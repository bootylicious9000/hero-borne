using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowRotation : MonoBehaviour
{

    public int CrowRotationSpeed = 100;
    private Transform CrowTransform;

    // Start is called before the first frame update
    void Start()
    {
        CrowTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        CrowTransform.Rotate(CrowRotationSpeed * Time.deltaTime, 0, 0);
    }
}
