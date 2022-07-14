using System.Collections.Generic;

// NPC
// 보류
public class QuestData
{
    enum QuestLevel
    {
        Main,
        Sub
    }

    enum QuestType
    {
        Gathering,
        Talk
    }

    private int _mainQuestStep; // 퀘스트 순서
    private int _subQuestStep;
    private QuestLevel _questLevel; // 퀘스트 등급

    private string _questTitle; // 퀘스트 제목
    private string[] _questExplanation; // 수락, 설명, 진행, 완료
    private QuestType _questType; // 완료 조건
    private Dictionary<EntityInfo.ItemIndex, int> _reward; // 완료보상

    // NPC에게 말을 걸었을때 NPC에 있는 퀘스트 순서를 확인 후 퀘스트 메니저 현재 진행 퀘스트에 NPC의 퀘스트 인스턴스를 달음 
}
