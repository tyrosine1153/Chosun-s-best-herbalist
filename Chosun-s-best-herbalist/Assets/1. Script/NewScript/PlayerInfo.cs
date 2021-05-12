using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// System Object
public class PlayerInfo : Singleton<PlayerInfo>
{
    private readonly int[] _levelStep = { 10 , 15, 20, 25, int.MaxValue };

    [SerializeField] private int experience;  // 경험치
    [SerializeField] private int level;  // 레벨
    [SerializeField] private int stamina;  // 스태미나, 체력
    [SerializeField] private int admissionLevel;  // 맵 이동 레벨

    public int AdmissionLevel => admissionLevel;

    void Start()
    {
        level = 1;
        experience = 0;
        stamina = 100;
        admissionLevel = 0;
    }
    
    // 경험치 상승
    public void UpdateExp(int point)
    {
        experience += point;
        if (experience > _levelStep[level - 1])
        {
            level++;
        }
    }
}
