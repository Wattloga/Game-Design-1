﻿using UnityEngine;

public class Health : MonoBehaviour
{
    public FloatData healthData;
    public FloatData[] damagerList;
    private NameID otherNameID;
    private void OnTriggerEnter(Collider other)
    {
        otherNameID = other.GetComponent<BehaviourID>().nameIdObj;
        ChangeHealth();
    }

    public void ChangeHealth()
    {
       foreach(var damager in damagerList)
       {
            if (damager == otherNameID)
            {
                healthData.UpdateValue(damager.Value);
            }

        }
            
        
    }


}
