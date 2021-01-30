using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HerbsCounter : MonoBehaviour
{
    public Text herbsNumber;
    public HerbsManager herbsManager;
    void Update()
    {
        herbsNumber.text = herbsManager.herbsCounter.ToString();
    }
}
