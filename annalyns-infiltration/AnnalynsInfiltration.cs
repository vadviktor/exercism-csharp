static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake)
        {
            return false;
        }

        return true;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return !archerIsAwake && prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (
            (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent) ||
            (!knightIsAwake && archerIsAwake && !prisonerIsAwake && !petDogIsPresent) ||
            (!knightIsAwake && archerIsAwake && !prisonerIsAwake && petDogIsPresent) ||
            (!knightIsAwake && archerIsAwake && prisonerIsAwake && !petDogIsPresent) ||
            (!knightIsAwake && archerIsAwake && prisonerIsAwake && petDogIsPresent) ||
            (knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent) ||
            (knightIsAwake && !archerIsAwake && prisonerIsAwake && !petDogIsPresent) ||
            (knightIsAwake && archerIsAwake && !prisonerIsAwake && !petDogIsPresent) ||
            (knightIsAwake && archerIsAwake && !prisonerIsAwake && petDogIsPresent) ||
            (knightIsAwake && archerIsAwake && prisonerIsAwake && !petDogIsPresent) ||
            (knightIsAwake && archerIsAwake && prisonerIsAwake && petDogIsPresent)
        )
        {
            return false;
        }

        return true;
    }
}
