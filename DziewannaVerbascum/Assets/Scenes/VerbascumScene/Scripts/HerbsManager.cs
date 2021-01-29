using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbsManager : MonoBehaviour
{

    //public int herbsCount = 0;
    public Dictionary<string, int> herbsBag = new Dictionary<string, int>();
    // Start is called before the first frame update
    public void addHerb(GameObject herb)
    {
        Debug.Log("Hwytam ziele");
        int dotPosition = herb.name.IndexOf(".");
        string herbName = herb.name.Substring(0, dotPosition);

        if (herbsBag.ContainsKey(herbName))
        {
            herbsBag[herb.tag]++;
        }
        else
        {
            herbsBag.Add(herb.tag, 1);
        }

        foreach (KeyValuePair<string, int> herbInBag in herbsBag)
        {
            Debug.Log(herbInBag.Key + ": " + herbInBag.Value);
        }
    }
    
}
