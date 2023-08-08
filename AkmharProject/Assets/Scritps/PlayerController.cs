using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameManager manager;
    
    void Start()
    {
        manager = GameManager.getInstance();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.CompareTag("Finish")){
            manager.silenceBackgroundMusic(true);
        }
    }
}
