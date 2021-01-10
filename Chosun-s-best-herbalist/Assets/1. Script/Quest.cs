using System.Collections;
using System.Collections.Generic;


public class Quest
{
    private int questType;  // 퀘스트 조건
    public int number;  // 퀘스트 번호(순서)
    public int NPCId;  // 의뢰한 NPC
    public string[] detail;  // 설명
    public Dictionary<int, int> condition;  // 완료 조건
    public Dictionary<int, int> reward;  // 보상
}
