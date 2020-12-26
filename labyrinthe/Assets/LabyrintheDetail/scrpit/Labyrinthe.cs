using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labyrinthe : MonoBehaviour
{
    public int taille;
    
    public LigneLabyrinthe[] labyrinthe;
    // Start is called before the first frame update
    void Start()
    {
		
		int tmp1=0;
		int tmp2=0;
        // int i=0;
        // int j=0;
         for (int i = 0; i < 10; i++){
             for (int j = 0; j < 10; j++){
                GameObject Case =Instantiate(labyrinthe[i].Ligne[j].Case);
                Case.transform.Translate(tmp1, 0, tmp2);
                tmp2+=10;
             }
            tmp2=0;
			tmp1+=10;
         }
        //  foreach (LigneLabyrinthe LBLinges in labyrinthe)
        // {
        //     if (LBLinges!=null)
        //     {
        //         foreach (CaseLabyrinthe LBLCases in LBLinges){
        //             GameObject Case =Instantiate(LBLCases);
        //             Case.transform.Translate(tmp1, 0, tmp2);
        //             tmp2+=10;
        //             j++;
        //             }
        //         }
        //     tmp2=0;
		// 	tmp1+=10;
        //     i++;
        // }
		
        // List gs = new List();
        // Transform[] ts = labyrinthe.GetComponentsInChildren<Transform>();
        // if (ts == null)
        //     return gs;
        // foreach (Transform t in ts)
        // {
        //     // if (t != null && t.gameobject != null)
        //     //     gs.Add(t.gameobject);
        //     Debug.Log(t);
        // }
        // return gs;
        // GameObject hinge = labyrinthe.GetComponentInChildren(typeof(HingeJoint)) as GameObject;

        // if (hinge != null)
        // {
        //     hinge.useSpring = false;
        //     Debug.Log(hinge);
        // }
        // else
        // {
        //     // Try again, looking for inactive GameObjects
        //     HingeJoint hingeInactive = labyrinthe.GetComponentInChildren(typeof(HingeJoint), true) as HingeJoint;

        //     if (hingeInactive != null)
        //     {
        //         hingeInactive.useSpring = false;
        //         Debug.Log(hingeInactive);
        //     }
        // }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
