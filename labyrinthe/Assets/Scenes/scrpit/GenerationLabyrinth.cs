using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GenerationLabyrinth : MonoBehaviour {
	public string myName;
	public int NombreCase;
    // public Rigidbody rb;
	// public float mass;
	public GameObject[] Briques;
	// Use this for initialization
	void Start () {
		Debug.Log("I am alive and my name is "+ myName);
		int ValuerAliatoire=0;
		int ValuerRotationAliatoire=0;
		int tmp1=0;
		int tmp2=0;
		 for (int i = 0; i < NombreCase*NombreCase; i++) {
			    if(tmp2==NombreCase*10){
                   tmp2=0;
				   tmp1+=10;
				}
				GameObject obj =Instantiate(Briques[ValuerAliatoire]);
				// switch (ValuerRotationAliatoire)
				// {
				// 	case 0:
				// 	obj.transform.Rotate(0.0f, 0.0f, 0.0f, Space.Self);
				// 	break;
				// 	case 1:
				// 	obj.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
				// 	break;
				// 	case 2:
				// 	obj.transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
				// 	break;
				// 	case 3:
				// 	obj.transform.Rotate(0.0f, 270.0f, 0.0f, Space.Self);
				// 	break;
				// 	default:
				// 	break;
				// };
				obj.transform.Translate(tmp1, 0, tmp2);
				ValuerAliatoire = Random.Range(0, 3);
				// ValuerRotationAliatoire = Random.Range(0, 4);
				tmp2+=10;
			}
		// foreach ( GameObject Brique in Briques) {
        //     Instantiate(Brique);
        // }
		// enemies = GameObject.FindGameObjectsWithTag("Enemy");
		// rb = GetComponent<Rigidbody>();
		// rb.mass = mass;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
// using UnityEngine;
// using System.Collections;

// public class GenerationLabyrinth : MonoBehaviour {
//     public float distancePerFrame;
    
//     void Update() {
//         transform.Translate(0, 0, distancePerFrame * Time.deltaTime);
//     }
// }
