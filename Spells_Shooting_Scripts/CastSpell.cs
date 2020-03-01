﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSpell : MonoBehaviour
{
    private Rigidbody myBody;
    private MeshRenderer myRend;
    private Collider myCollider;
    private GameObject firstChild; //trail renderer

    private bool dealDamage = false;
    private List<EnemyHealth> enemyHealth = new List<EnemyHealth>();

    public float damage;
    public float radius;
    public float dealDamageTimer;
    private float timer;
    public float lifeTimeTimer;
    

    public enum SpellType { Ice, Blasting, Color, Protective};
    public SpellType spellType;
    

    private void Start()
    {
        myBody = GetComponent<Rigidbody>();
        myRend = GetComponent<MeshRenderer>();
        myCollider = GetComponent<Collider>();
        firstChild = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        lifeTimeTimer -= Time.deltaTime;

        if (lifeTimeTimer <= 0)
        {
            Die();
        }

        if (dealDamage)
        {
            timer += Time.deltaTime;
            if (timer >= dealDamageTimer)
            {
                timer = 0;
                for (int i = 0; i < enemyHealth.Count; i++)
                {
                    enemyHealth[i].TakeDamage(damage, spellType);
                }
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Ground")
        {
            HideStuff();
            DoDamage();
        }
    }

    private void HideStuff()
    {
        myBody.constraints = RigidbodyConstraints.FreezeAll;
        myRend.enabled = false;
        myCollider.enabled = false;
        firstChild.SetActive(false);
    }

    private void DoDamage()
    {
        Collider[] colls = Physics.OverlapSphere(transform.position, radius);

        for (int i = 0; i < colls.Length; i++)
        {
            Collider current = colls[i];

            if (colls[i].tag == "Enemy")
            {
                GameObject go = Instantiate(current.transform.position, Quaternion.identity);
                go.transform.parent = this.transform;

                EnemyHealth currentHealth = current.GetComponent<EnemyHealth>();
                enemyHealth.Add(currentHealth);
                currentHealth.TakeDamage(damage, spellType);

            }
        }
        dealDamage = true;
    }

    private GameObject Instantiate(Vector3 position, Quaternion identity)
    {
        throw new NotImplementedException();
    }

    private void Die()
    {
        Debug.Log("--Spell Destroyed--");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<PlayerHealth>(). TakeDamage(damage);
    }


}
