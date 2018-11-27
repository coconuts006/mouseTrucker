using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DexteritySelectControl : MonoBehaviour {
    static public int root_decterity;
    static public bool isSetDexterity = false;
    Button next;

    // Use this for initialization
    void Start()
    {
        next = GameObject.Find("Next").GetComponent<Button>();
        next.interactable = false;
    }

    private void Update()
    {
        if(isSetDexterity)
        {
            next.interactable = true;
        }
        else
        {
            next.interactable = false;
        }
    }

    public void OnClickDexteritySelect()
    {
        if (transform.name == "left")
        {
            Debug.Log("left");
            root_decterity = 0;
            isSetDexterity = true;
        }
        else if (transform.name == "right")
        {
            Debug.Log("right");
            root_decterity = 1;
            isSetDexterity = true;
        }
    }
}
