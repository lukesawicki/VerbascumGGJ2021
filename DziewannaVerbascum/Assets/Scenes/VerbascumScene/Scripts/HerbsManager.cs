using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbsManager : MonoBehaviour
{

    public int herbsCounter = 0;
    public int MAX_HERBS = 5;

    // Start is called before the first frame update
    public void addHerb()
    {
        herbsCounter++;
        Debug.Log("Dodane: " + herbsCounter);
    }
    
}
