using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPushSelectMenu : MonoBehaviour
{
    [SerializeField] GameObject activeTarget;
    [SerializeField] GameObject[] deactiveTargets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonPushed()
    {
        activeTarget.SetActive(true);

        for ( int i = 0; i < deactiveTargets.Length; i ++)
        {
            deactiveTargets[i].SetActive(false);
        }
    }
}
