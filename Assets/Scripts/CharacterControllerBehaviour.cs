using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerBehaviour : MonoBehaviour {

    private CharacterController _characterController;
	// Use this for initialization
	void Start () {
        _characterController = GetComponent<CharacterController>();


#if DEBUG
        Assert.IsNotNull(_characterController, "DEPENDENCY ERROR: CharacterControllerBehaviour need a CharacterControllerComponent");
#endif

    }
	
	// Update is called once per frame
	void Update () {
		
	}


}
