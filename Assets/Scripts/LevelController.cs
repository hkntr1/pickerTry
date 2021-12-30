using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{  
    [SerializeField] public float pushForce=5;
    [SerializeField] private Animator elevator;
    public List<GameObject> balls = new List<GameObject>();
    we deneme;
    Coroutine levelEndCoroutine;
    PickerController picker;
    public Rigidbody rb;
    BoxCollider insideControllerCollider;
    private void Awake()
    {
        foreach (GameObject ball in GameObject.FindGameObjectsWithTag("Ball"))
        {

            balls.Add(ball);
        }
        GameObject insideController = GameObject.FindWithTag("insideController");
        insideControllerCollider = insideController.GetComponent<BoxCollider>();
        insideControllerCollider.enabled = false;
    }
   
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Debug.Log("Çarpýþma Gerçekleþti");
            rb.constraints = RigidbodyConstraints.FreezePositionZ;              
            insideControllerCollider.enabled = true;
            levelEndCoroutine = StartCoroutine(levelEnd());
        }

    }
    public IEnumerator levelEnd()
    {
        Debug.Log("Coroutine Bitti:" + Time.time);
        yield return new WaitForSeconds(2f);       
        elevator.Play("ElevatorAnim", 0, 0f);
        yield return new WaitForSeconds(2f);
        Debug.Log("Animasyon Bitti:" + Time.time);
        for (int i = 0; i < balls.Count; i++)
        {
            Destroy(balls[i]);
        }    
            yield return null;
    }

}
