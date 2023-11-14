using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float _rotationSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,_rotationSpeed * Time.deltaTime, 0);
    }
}
