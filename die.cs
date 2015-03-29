using UnityEngine; 
using System.Collections; 
public class die : MonoBehaviour{ 
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{ 
			Destroy (col.gameObject); 
		}  
	} 
}
