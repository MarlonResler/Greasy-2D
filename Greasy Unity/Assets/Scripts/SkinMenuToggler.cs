using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinMenuToggler : MonoBehaviour
{
    [SerializeField]
    GameObject menuPref;

    GameObject instMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && instMenu == null)
        {
            instMenu = Instantiate(menuPref);
            instMenu.transform.SetParent(gameObject.transform, false);            
        } else if (Input.GetKeyDown(KeyCode.Escape) && instMenu != null)
        {
            Destroy(instMenu);
        }
        
    }
}
