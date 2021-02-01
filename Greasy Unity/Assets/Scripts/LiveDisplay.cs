using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveDisplay  : MonoBehaviour {

    private int live = 3;
    public Text liveText;

    void Update() {

        liveText.text = "LIVES :" + live;
        
    }
}
