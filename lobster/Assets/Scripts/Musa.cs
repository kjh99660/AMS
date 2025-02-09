﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musa : MonoBehaviour
{
    public Animator animator;

    public List<GameObject> collBear_1 = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        Stun();
       
        
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Bear_1")
        {
            collBear_1.Add(coll.gameObject);
           /* for (int i = 0; i < collBear_1.Count; i++)
            {
                if (collBear_1[i] == null) continue;
                Debug.Log("들옴");
                (collBear_1[i]).GetComponent<Bear>().Bear_time = 0;
            }
            */
        }
        if ( coll.tag == "Bear_2")
        {
            collBear_1.Add(coll.gameObject);
            /*
            for (int i = 0; i < collBear_1.Count; i++)
            {
                if (collBear_1[i] == null) continue;
                (collBear_1[i]).GetComponent<Bear_2>().Bear_time = 0;
            }
            */
        }
        if (coll.tag == "Bear_3")
        {
            collBear_1.Add(coll.gameObject);
            /*
            for (int i = 0; i < collBear_1.Count; i++)
            {
                if (collBear_1[i] == null) continue;
                (collBear_1[i]).GetComponent<Bear_3>().Bear_time = 0;
            }
            */
        }
        if (coll.tag == "Bear_4")
        {
            collBear_1.Add(coll.gameObject);
            /*
            for (int i = 0; i < collBear_1.Count; i++)
            {
                if (collBear_1[i] == null) continue;
                (collBear_1[i]).GetComponent<Bear_4>().Bear_time = 0;
            }
            */
        }
        if (coll.tag == "Bear_boss")
        {
            collBear_1.Add(coll.gameObject);
            /*
            for (int i = 0; i < collBear_1.Count; i++)
            {
                if (collBear_1[i] == null) continue;
                (collBear_1[i]).GetComponent<Bear_boss>().Bear_time = 0;
            }
            */
        }
    }

    /*
        private void OnTriggerExit2D(Collider2D coll)
        {
            for (int i = 0; i < collBear_1.Count; i++)
            {
                if (collBear_1[i] == coll.gameObject)
                {
                    collBear_1.Remove(collBear_1[i]);
                    Debug.Log("나감");
                    break;
                }
            }
        }   
          */
    // Update is called once per frame
    private IEnumerator Stun()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        for (int i = 0; i < collBear_1.Count; i++)
        {
            if (collBear_1[i] == null) continue;;
            (collBear_1[i]).GetComponent<Bear>().Bear_time = 0;
        }
        for (int i = 0; i < collBear_1.Count; i++)
        {
            if (collBear_1[i] == null) continue;
            (collBear_1[i]).GetComponent<Bear_2>().Bear_time = 0;
        }
        for (int i = 0; i < collBear_1.Count; i++)
        {
            if (collBear_1[i] == null) continue;
            (collBear_1[i]).GetComponent<Bear_3>().Bear_time = 0;
        }
        for (int i = 0; i < collBear_1.Count; i++)
        {
            if (collBear_1[i] == null) continue;
            (collBear_1[i]).GetComponent<Bear_4>().Bear_time = 0;
        }
        for (int i = 0; i < collBear_1.Count; i++)
        {
            if (collBear_1[i] == null) continue;
            (collBear_1[i]).GetComponent<Bear_boss>().Bear_time = 0;
        }
        yield return new WaitForEndOfFrame();
    }
    void EnableCol()
    {
        this.GetComponent<BoxCollider2D>().enabled = false; // 자기자신의 박스콜라이더를 끔 
    }
    private IEnumerator Attack()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1f)
        {
            for (int i = 0; i < collBear_1.Count; i++)
            {
                try
                {
                    if (collBear_1[i].tag == "Bear_1")
                    {
                        if (collBear_1[i] == null) continue;
                        if ((collBear_1[i]).GetComponent<Bear>() == null) continue;
                        Bear target = collBear_1[i].GetComponent<Bear>();
                        target.Bear1_HP -= 160;
                        Debug.Log("딜박힘");
                    }
                    if (collBear_1[i].tag == "Bear_2")
                    {
                        if (collBear_1[i] == null) continue;
                        if ((collBear_1[i]).GetComponent<Bear_2>() == null) continue;
                        Bear_2 target_2 = collBear_1[i].GetComponent<Bear_2>();
                        target_2.Bear2_HP -= 160;
                        Debug.Log("딜박힘");
                    }
                    if (collBear_1[i].tag == "Bear_3")
                    {
                        if (collBear_1[i] == null) continue;
                        if ((collBear_1[i]).GetComponent<Bear_3>() == null) continue;
                        Bear_3 target = collBear_1[i].GetComponent<Bear_3>();
                        target.Bear3_HP -= 160;
                        Debug.Log("딜박힘");
                    }
                    if (collBear_1[i].tag == "Bear_4")
                    {
                        if (collBear_1[i] == null) continue;
                        if ((collBear_1[i]).GetComponent<Bear_4>() == null) continue;
                        Bear_4 target = collBear_1[i].GetComponent<Bear_4>();
                        target.Bear4_HP -= 160;
                        Debug.Log("딜박힘");
                    }
                    if (collBear_1[i].tag == "Bear_boss")
                    {
                        if (collBear_1[i] == null) continue;
                        if ((collBear_1[i]).GetComponent<Bear_boss>() == null) continue;
                        Bear_boss target = collBear_1[i].GetComponent<Bear_boss>();
                        target.Bear_boss_HP -= 160;
                        Debug.Log("딜박힘");
                    }
                }
                catch(MissingReferenceException)
                {
                    
                }
            }
            GameManager.instance.skill = false;
            Destroy(gameObject);
            yield return new WaitForEndOfFrame();

        }
    }
    void Update()
    {
    
            StartCoroutine("Attack");
   
       

    }
}
