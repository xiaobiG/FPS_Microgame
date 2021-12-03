using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    private void FixedUpdate() {

        
    }


}
