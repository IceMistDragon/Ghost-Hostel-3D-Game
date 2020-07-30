﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterPaper : MonoBehaviour

{

    //要被生成的怪物物件

    public GameObject Monster;

    void Start()

    {

        //執行生成怪物程式碼(每秒一次)

        InvokeRepeating("CreatMoneter", 1, 10);     // *-*

    }

    public void CreatMoneter()

    {

        int MonsterNum;

        //隨機決定要生成幾個怪物(0-2個隨機)

        MonsterNum = Random.Range(0, 3);

        //開始生成怪物

        for (int i = 0; i < MonsterNum; i++)

        {

            //宣告生成的X座標

            float x;

            //產生隨機的X座標(-6到5之間)

            x = Random.Range(-6, 6);

            //生成怪物

            Instantiate(Monster, new Vector3(x, 2.8f, 0), Quaternion.identity);

        }

    }

}
