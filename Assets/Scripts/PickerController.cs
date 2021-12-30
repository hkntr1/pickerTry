using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickerController : MonoBehaviour
{
    public float Speed = 5f;
    [SerializeField] public Rigidbody pickerRb;
   
    
    void FixedUpdate()
    {
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"),0,1);
        pickerRb.MovePosition(transform.position + m_Input * Time.deltaTime * Speed);
    }
    
}