using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControlller : MonoBehaviour
{
    // Start is called before the first frame update
	bool is_at_door;
	Animator m_Animator;
	public LayerMask interactableLayer;
    void Start()
    {
		 m_Animator = GetComponent<Animator>();		 
        //does somethin
		//Debug.Log("Hello");
		//hey this code does this or that
		
		
    }
	

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E) && is_at_door)
		{
			Debug.Log("Door must open!!");
			m_Animator.SetBool("isopen", true);
		}
        
    }
	
	private void OnTriggerEnter(Collider other)
    {
		
		if(1 << other.gameObject.layer == interactableLayer.value){
			is_at_door = true;
		}
    }
	
	void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "FPSController"){
			is_at_door = false;
		}
    }
}
