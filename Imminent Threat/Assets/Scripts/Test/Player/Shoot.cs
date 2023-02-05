using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public bool is_automatic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
	void FixedUpdate()
    {
		if(is_automatic){
			if(Input.GetKey(KeyCode.Mouse0)){
					// Bit shift the index of the layer (8) to get a bit mask
					int layerMask = 1 << 3;

					// This would cast rays only against colliders in layer 8.
					// But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
					layerMask = ~layerMask;

					RaycastHit hit;
					// Does the ray intersect any objects excluding the player layer
					if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
					{
						Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
						Debug.Log("Did Hit");
						Debug.Log(hit.transform.gameObject.name);
					}
					else
					{
						Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
						Debug.Log("Did not Hit");
					}
				}
		
		
		}else{
			if(Input.GetKeyDown(KeyCode.Mouse0)){
				// Bit shift the index of the layer (8) to get a bit mask
				int layerMask = 1 << 3;

				// This would cast rays only against colliders in layer 8.
				// But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.
				layerMask = ~layerMask;

				RaycastHit hit;
				// Does the ray intersect any objects excluding the player layer
				if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
				{
					Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
					Debug.Log("Did Hit");
					Debug.Log(hit.transform.gameObject.name);
				}
				else
				{
					Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
					Debug.Log("Did not Hit");
				}
			}
		}
	}
}
