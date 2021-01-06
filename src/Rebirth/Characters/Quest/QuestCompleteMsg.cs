﻿namespace Rebirth.Characters.Quest
{
    public enum QuestCompleteMsg
    {
        QUEST_COMPLETESUCCESS = 0,
        QUEST_COMPLETEFAIL_NPC = 1,
        QUEST_COMPLETEFAIL_ITEM = 2,
        QUEST_COMPLETEFAIL_PREQUEST = 3,
        QUEST_COMPLETEFAIL_INFO = 4,
        QUEST_COMPLETEFAIL_OTHERINFO = 5,
        QUEST_COMPLETEFAIL_MOB = 6,
        QUEST_COMPLETEFAIL_PROTECTEDITEM = 7,
        QUEST_COMPLETEFAIL_PETNOEXIST = 8,
        QUEST_COMPLETEFAIL_PETCONDITION = 9,
        QUEST_COMPLETEFAIL_MESO = 0x0A,
        QUEST_COMPLETEFAIL_TIME = 0x0B,
        QUEST_COMPLETEFAIL_UNKNOWN = 0x0C,
        QUEST_COMPLETEFAIL_MORPH = 0x0D,
        QUEST_COMPLETEFAIL_BUFF = 0x0E,
        QUEST_COMPLETEFAIL_EXCEPTBUFF = 0x0F,
        QUEST_COMPLETEFAIL_LEVEL = 0x10,
        QUEST_COMPLETEFAIL_TIMEKEEP = 0x11,
        QUEST_COMPLETEFAIL_DAYOFWEEK = 0x12,
    }
}
