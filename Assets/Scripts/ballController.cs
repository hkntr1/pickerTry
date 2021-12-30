using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour
{
    public Rigidbody ballRb;
    [SerializeField] public float pushForce = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider insideController)
    {
        if (insideController.CompareTag("insideController"))
        {
            Debug.Log("insideeeeeeeee");
            ballRb.AddForce(0, 20, pushForce);
        }
    }
}
