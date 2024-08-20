using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;

public class galleryController : MonoBehaviour { 

//PSEUDO CODE: Declare(Create) a public variable for an array, Type: GameObject 
//FUNCTION: Can Populate(Initialize) in Inspector Box and hold multiple Game Objects.... 
public GameObject[] MecaBrickItems; 
//PSEUDO CODE: Declare(Create) and Initialize(give value) a public variable for counting 
//FUNCTION: Starts at 0, used to access array items in sequence.... 
public int current = 0; 

void Update() { 
    if (Input.GetKeyDown(KeyCode.Alpha1)) { 
        if (current <= MecaBrickItems.Length - 1) 
            { 
                current++; 
            } 
        if (current == MecaBrickItems.Length) 
            { 
                current = 0; 
            } 
    } 

    if (Input.GetKeyDown(KeyCode.Alpha2)) { 
        if (current >= 0) 
            { 
                current--; 
            } 
        if (current == -1) 
            { 
                current = MecaBrickItems.Length - 1; 
            } 
    } 
    Debug.Log("Current" + current); 
    
    for (int i = 0; i<MecaBrickItems.Length; i++) { 
        if (i != current) 
            {  
                MecaBrickItems[i].SetActive(false); 
            } 
        else 
            { 
                MecaBrickItems[current].SetActive(true); 
            } 
    } 
    } 
 } 
