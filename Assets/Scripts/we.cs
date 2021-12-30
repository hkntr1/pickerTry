using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class we : MonoBehaviour
{
    public GameObject[] detectedBalls;
    float radius = 0f;
    private void Start()
    {
        
    }
    void Update()
    {
        RaycastHit[] hits = Physics.SphereCastAll(transform.position, radius, Vector3.zero);
        if (hits.Length > 0)
        {
            detectedBalls = new GameObject[hits.Length];
            for (int i = 0; i < hits.Length; i++)
            {
                detectedBalls[i] = hits[i].collider.gameObject;
            }
            Debug.Log(detectedBalls.ToString());
        }
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].collider.CompareTag("Ball"))
            {
                detectedBalls[i] = hits[i].collider.gameObject;
            }
        }
        

    }
      
    }
