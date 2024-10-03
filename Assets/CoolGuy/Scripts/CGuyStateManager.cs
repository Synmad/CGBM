using UnityEngine;

public class CGuyStateManager : MonoBehaviour
{
    public enum State
    {
        Default,
        Dashing
    }

    [field: SerializeField] public static State currentState { get; private set; }

    private void Awake() => currentState = State.Default;

    public static void ChangeState (State newState) => currentState = newState;
}
