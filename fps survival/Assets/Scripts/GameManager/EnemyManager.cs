using System.Collections;
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
    // Start is called before the first frame update
    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}

