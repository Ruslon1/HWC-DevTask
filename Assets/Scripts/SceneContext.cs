using UnityEngine;

public class SceneContext : MonoBehaviour
{
    public MoveBattleService MoveBattleService { get; private set; }
    public Battle Battle { get; private set; }

    private void Awake()
    {
        MoveBattleService = FindAnyObjectByType<MoveBattleService>();
        Battle = FindAnyObjectByType<Battle>();

        ContextBehaviour[] behaviours = FindObjectsByType<ContextBehaviour>(FindObjectsSortMode.None);
        
        foreach (var behaviour in behaviours)
        {
            behaviour.Context = this;
        }
    }
}

public class ContextBehaviour : MonoBehaviour
{
    public SceneContext Context;
}