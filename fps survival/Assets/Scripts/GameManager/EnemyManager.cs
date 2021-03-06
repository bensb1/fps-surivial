﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;
    [SerializeField]
    private GameObject cannibal_Prefab;
    public Transform[] cannibal_SpawnPoints;
    [SerializeField]
    private int cannibal_Enemy_Count;
    private int initial_Cannibal_Count;
    public float wait_Before_Spawn_Enemies_Time = 10f;
    int j = 0;
    // Start is called before the first frame update
    void Awake()
    {
        MakeInstance();
    }
     void Start()
    {
        initial_Cannibal_Count = cannibal_Enemy_Count;
        SpawnEnemies();
        StartCoroutine("CheckToSpawnEnemies");
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }
    void SpawnEnemies()
    {
        SpawnCannibals();
    }
        void SpawnCannibals()
        {
        
        for (int i = 0; i < cannibal_Enemy_Count; i++)
        {
            if(j >= cannibal_SpawnPoints.Length)
            {
                j = 0;
            }
            Instantiate(cannibal_Prefab, cannibal_SpawnPoints[j].position, Quaternion.identity);
            j++;
        }
        cannibal_Enemy_Count = 0;
        }
         IEnumerator CheckToSpawnEnemies()
    {
        yield return new WaitForSeconds(wait_Before_Spawn_Enemies_Time);
        SpawnCannibals();

    }
    public void EnemyDied(bool cannibal)
    {
        if(cannibal)
        {
            cannibal_Enemy_Count++;
            if(cannibal_Enemy_Count > initial_Cannibal_Count)
            {
                cannibal_Enemy_Count = initial_Cannibal_Count;
            }
        }
    }
    public void StopSpawning()
    {
        StopCoroutine("CheckToSpawnEnemies");
    }
    }




