using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivate : MonoBehaviour
{

    private Manager managerScript;
    private Snowball snowballScript;


    private void Start()
    {
        managerScript = GameObject.FindObjectOfType<Manager>();
    }


   
        
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InvokeRepeating("ExecuteFunctionInOtherScript", 0f, 3f);
            ExecuteFunctionInOtherScript();
            //Debug.Log("Player ist im Trigger");
        }
    }

        

    private void ExecuteFunctionInOtherScript()
    {
        if (managerScript != null)
        {
            managerScript.Snowballshot();

            //Debug.Log("Befehl geht zu ManagerSkript");
        }
    }
}
