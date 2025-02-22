using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDetection : MonoBehaviour
{
    // Start is called before the first frame update
    private spike script;
    void Start()
    {
        script = GetComponentInParent<spike>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setLight(bool light)
    {
        script.setSpike(light);
    }
}
