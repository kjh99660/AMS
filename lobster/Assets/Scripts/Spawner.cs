﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CreateBear = null;
    public GameObject CreateBear_2 = null;
    public GameObject CreateBear_3 = null;
    public GameObject CreateBear_4 = null;
    public GameObject CreateBear_5 = null;

    public List<GameObject> Fake_Bear1 = new List<GameObject>();
    public List<GameObject> Fake_Bear2 = new List<GameObject>();
    public List<GameObject> Fake_Bear3 = new List<GameObject>();
    public List<GameObject> Fake_Bear4 = new List<GameObject>();
    public List<GameObject> Fake_Bear5 = new List<GameObject>();

    public int Bear1_numbering = 0;
    public int Bear2_numbering = 0;
    public int Bear3_numbering = 0;
    public int Bear4_numbering = 0;
    public int Bear5_numbering = 0;

    public int count = 0;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Bear4_numbering; i++)
        {

            if (Fake_Bear4[i] == null) continue;
            if ((Fake_Bear4[i]).GetComponent<Bear_4>() == null) continue;
            if ((Fake_Bear4[i]).GetComponent<Bear_4>().Bear4_HP <= 0)
            {
                Destroy(Fake_Bear4[i].gameObject);
                GameManager.instance.Money += 40;
                count++;
            }
        }
        for (int i = 0; i < Bear1_numbering; i++)
        {
            if (Fake_Bear1[i] == null) continue;
            if ((Fake_Bear1[i]).GetComponent<Bear>() == null) continue;
            if ((Fake_Bear1[i]).GetComponent<Bear>().Bear1_HP <= 0)
            {
                Destroy(Fake_Bear1[i].gameObject);
                GameManager.instance.Money += 20;
                count++;
            }
        }
        for (int i = 0; i < Bear2_numbering; i++)
        {
            if (Fake_Bear2[i] == null) continue;
            if ((Fake_Bear2[i]).GetComponent<Bear_2>() == null) continue;
            if ((Fake_Bear2[i]).GetComponent<Bear_2>().Bear2_HP <= 0)
            {
                Destroy(Fake_Bear2[i].gameObject);
                GameManager.instance.Money += 30;
                count++;
            }
        }
        for (int i = 0; i < Bear3_numbering; i++)
        {
            if (Fake_Bear3[i] == null) continue;
            if ((Fake_Bear3[i]).GetComponent<Bear_3>() == null) continue;
            if ((Fake_Bear3[i]).GetComponent<Bear_3>().Bear3_HP <= 0)
            {
                Destroy(Fake_Bear3[i].gameObject);
                GameManager.instance.Money += 35;
                count++;
            }
        }
        for (int i = 0; i < Bear5_numbering; i++)
        {
            if (Fake_Bear5[i] == null) continue;
            if ((Fake_Bear5[i]).GetComponent<Bear_boss>() == null) continue;
            if ((Fake_Bear5[i]).GetComponent<Bear_boss>().Bear_boss_HP <= 0)
            {
                Destroy(Fake_Bear5[i].gameObject);
                GameManager.instance.Money += 0;
                count++;
            }
        }


        GameManager.instance.Spown_term -= Time.deltaTime;  //곰 1 리스폰 시간을 깍음. 
        GameManager.instance.Spown_term_2 -= Time.deltaTime; //곰 2 리스폰 시간을 깍음.
        GameManager.instance.Spown_term_3 -= Time.deltaTime; //곰 3 리스폰 시간을 깍음.
        GameManager.instance.Spown_term_4 -= Time.deltaTime; //곰 4 리스폰 시간을 깍음.
        GameManager.instance.Spown_term_b -= Time.deltaTime; //보스곰 리스폰 시간을 깍음.

        if (GameManager.instance.Spown_term < 0 && GameManager.instance.Bear_number > 0)// 리스폰 시간이 0이 되었는지 검사 
        {
            if (GameManager.instance.stage_level == 1)
            {
                GameObject newBear = Instantiate(CreateBear, new Vector3(-6.5f, 7.8f, -4), Quaternion.identity); //곰 1 생성
                Fake_Bear1.Add(newBear);

                GameManager.instance.Spown_term = 3.0f;
                GameManager.instance.Bear_number--;//곰 1 리스폰 시간 및 소환 수 처리

                Bear1_numbering++;


            }
            if (GameManager.instance.stage_level == 2)
            {
                GameObject newBear = Instantiate(CreateBear, new Vector3(1.58f, 28.63f, -4), Quaternion.identity); //곰 1 생성
                Fake_Bear1.Add(newBear);

                GameManager.instance.Spown_term = 3.0f;
                GameManager.instance.Bear_number--;//곰 1 리스폰 시간 및 소환 수 처리

                Bear1_numbering++;


            }
            if (GameManager.instance.stage_level == 3)
            {
                GameObject newBear = Instantiate(CreateBear, new Vector3(-11.46f, 22.12f, -4), Quaternion.identity); // 생성
                Fake_Bear1.Add(newBear);

                GameManager.instance.Spown_term = 3.5f;// 리스폰시간 초기화
                GameManager.instance.Bear_number--;
                Bear1_numbering++;

            }
            if (GameManager.instance.stage_level == 4)
            {
                GameObject newBear = Instantiate(CreateBear, new Vector3(-17.45f, -4.04f, -4), Quaternion.identity); // 생성
                Fake_Bear1.Add(newBear);

                GameManager.instance.Spown_term = 3.0f;// 리스폰시간 초기화
                GameManager.instance.Bear_number--;
                Bear1_numbering++;

            }

        }
        if (GameManager.instance.Spown_term_2 < 0 && GameManager.instance.Bear_2_number > 0)// 리스폰 시간이 0이 되었는지 검사
        {
            if (GameManager.instance.stage_level == 1)
            {
                GameObject newBear_2 = Instantiate(CreateBear_2, new Vector3(-6.5f, 7.8f, -4), Quaternion.identity); //곰 2 생성
                Fake_Bear2.Add(newBear_2);

                GameManager.instance.Spown_term_2 = 5.5f;
                GameManager.instance.Bear_2_number--;//곰 2 리스폰 시간 및 소환 수 처리

                Bear2_numbering++;


            }
            if (GameManager.instance.stage_level == 2)
            {
                GameObject newBear_2 = Instantiate(CreateBear_2, new Vector3(1.58f, 28.63f, -4), Quaternion.identity); //곰 2 생성
                Fake_Bear2.Add(newBear_2);

                GameManager.instance.Spown_term_2 = 5.5f;
                GameManager.instance.Bear_2_number--;//곰 2 리스폰 시간 및 소환 수 처리

                Bear2_numbering++;


            }

            if (GameManager.instance.stage_level == 3)
            {
                GameObject newBear_2 = Instantiate(CreateBear_2, new Vector3(-11.46f, 22.12f, -4), Quaternion.identity); // 생성
                Fake_Bear2.Add(newBear_2);

                GameManager.instance.Spown_term_2 = 5.5f;
                GameManager.instance.Bear_2_number--;//곰 2 리스폰 시간 및 소환 수 처리

                Bear2_numbering++;

            }
            if (GameManager.instance.stage_level == 4)
            {
                GameObject newBear_2 = Instantiate(CreateBear_2, new Vector3(-17.45f, -4.04f, -4), Quaternion.identity); // 생성
                Fake_Bear2.Add(newBear_2);

                GameManager.instance.Spown_term_2 = 5.5f;
                GameManager.instance.Bear_2_number--;//곰 2 리스폰 시간 및 소환 수 처리

                Bear2_numbering++;
            }
        }
        if (GameManager.instance.Spown_term_3 < 0 && GameManager.instance.Bear_3_number > 0)// 리스폰 시간이 0이 되었는지 검사 
        {
            if (GameManager.instance.stage_level == 1)
            {
                GameObject newBear_3 = Instantiate(CreateBear_3, new Vector3(-6.5f, 7.8f, -4), Quaternion.identity); //곰 3 생성
                Fake_Bear3.Add(newBear_3);

                GameManager.instance.Spown_term_3 = 3.0f;
                GameManager.instance.Bear_3_number--;//곰 3 리스폰 시간 및 소환 수 처리

                Bear3_numbering++;
            }
            if (GameManager.instance.stage_level == 2)
            {
                GameObject newBear_3 = Instantiate(CreateBear_3, new Vector3(1.58f, 28.63f, -4), Quaternion.identity); //곰 3 생성
                Fake_Bear3.Add(newBear_3);

                GameManager.instance.Spown_term_3 = 4.5f;
                GameManager.instance.Bear_3_number--;//곰 3 리스폰 시간 및 소환 수 처리

                Bear3_numbering++;

            }
            if (GameManager.instance.stage_level == 3)
            {
                GameObject newBear_3 = Instantiate(CreateBear_3, new Vector3(-11.46f, 22.12f, -4), Quaternion.identity); // 생성
                Fake_Bear3.Add(newBear_3);

                GameManager.instance.Spown_term_3 = 4.5f;// 리스폰시간 초기화
                GameManager.instance.Bear_3_number--;
                Bear3_numbering++;
            }
            if (GameManager.instance.stage_level == 4)
            {
                GameObject newBear_3 = Instantiate(CreateBear_3, new Vector3(-17.45f, -4.04f, -4), Quaternion.identity); // 생성
                Fake_Bear3.Add(newBear_3);

                GameManager.instance.Spown_term_3 = 4.5f;// 리스폰시간 초기화
                GameManager.instance.Bear_3_number--;
                Bear3_numbering++;
            }
        }
        if (GameManager.instance.Spown_term_4 < 0 && GameManager.instance.Bear_4_number > 0)// 리스폰 시간이 0이 되었는지 검사 
        {
            if (GameManager.instance.stage_level == 1)
            {
                GameObject newBear_4 = Instantiate(CreateBear_4, new Vector3(-6.5f, 7.8f, -4), Quaternion.identity); //곰 4 생성
                Fake_Bear4.Add(newBear_4);

                GameManager.instance.Spown_term_4 = 3.0f;
                GameManager.instance.Bear_4_number--;//곰 1 리스폰 시간 및 소환 수 처리

                Bear4_numbering++;

            }
            if (GameManager.instance.stage_level == 2)
            {
                GameObject newBear_4 = Instantiate(CreateBear_4, new Vector3(1.58f, 28.63f, -4), Quaternion.identity); //곰 4 생성
                Fake_Bear4.Add(newBear_4);

                GameManager.instance.Spown_term_4 = 3.0f;
                GameManager.instance.Bear_4_number--;//곰 1 리스폰 시간 및 소환 수 처리

                Bear4_numbering++;

            }
            if (GameManager.instance.stage_level == 3)
            {
                GameObject newBear_4 = Instantiate(CreateBear_4, new Vector3(-11.46f, 22.12f, -4), Quaternion.identity); // 생성
                Fake_Bear4.Add(newBear_4);

                GameManager.instance.Spown_term_4 = 5.5f;// 리스폰시간 초기화
                GameManager.instance.Bear_4_number--;
                Bear4_numbering++;
            }
            if (GameManager.instance.stage_level == 4)
            {
                GameObject newBear_4 = Instantiate(CreateBear_4, new Vector3(-17.45f, -4.04f, -4), Quaternion.identity); // 생성
                Fake_Bear4.Add(newBear_4);

                GameManager.instance.Spown_term_4 = 3.0f;// 리스폰시간 초기화
                GameManager.instance.Bear_4_number--;
                Bear4_numbering++;
            }


        }
        if (GameManager.instance.Spown_term_b < 0 && GameManager.instance.Bear_b_number > 0)// 리스폰 시간이 0이 되었는지 검사 
        {
            if (GameManager.instance.stage_level == 4)
            {
                GameObject newBear_5 = Instantiate(CreateBear_5, new Vector3(-17.45f, -4.04f, -4), Quaternion.identity); // 생성
                Fake_Bear5.Add(newBear_5);


                GameManager.instance.Bear_b_number--;
                Bear5_numbering++;
            }




        }
    }
}
