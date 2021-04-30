using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    private readonly int[] _levelStep = { 10 , 15, 20, 25, int.MaxValue };

    [SerializeField] private int experience;  // 경험치
    [SerializeField] private int level;  // 레벨
    [SerializeField] private int stamina;  // 스태미나, 체력
    [SerializeField] private int admissionLevel;  // 맵 이동 레벨
    
    void Start()
    {
        level = 1;
        experience = 0;
        stamina = 100;
        admissionLevel = 0;
    }
    
    void UpdateExp(int point)
    {
        experience += point;
        if (experience > _levelStep[level - 1])
        {
            level++;
        }
    }
}
