using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager manager;
    
    private static Vector3 originalPosition;
    void Start()
    {
        originalPosition = transform.position;
        
        manager = GameManager.getInstance();
        Debug.Log("ok");
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.Escape)){
        //     Debug.Log("ok");
        //     transform.position = originalPosition;
        //     GetComponent<Rigidbody>().velocity=new();
        // } 

    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.CompareTag("Finish")){
            manager.silenceBackgroundMusic(true);
        }
    }
}
