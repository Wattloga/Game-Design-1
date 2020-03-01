﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public GameObject spellPrefab;
    public float throwForce;
    public Transform spawnPoint;


    private void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GameObject spellGo = Instantiate(spellPrefab, spawnPoint.position, spawnPoint.rotation);
            spellGo.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * throwForce, ForceMode.Impulse);
        }
    }

    public class SpellType
    {
        internal static SpellType Ice;
    }

}
