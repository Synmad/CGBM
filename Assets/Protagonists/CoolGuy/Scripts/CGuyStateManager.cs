using UnityEngine;

public class CGuyStateManager : MonoBehaviour
{
    public enum State
    {
        Default,
        Dashing,
        Dead
    }

    [field: SerializeField] public State currentState { get; private set; }

    private void Awake() => currentState = State.Default;

    public void ChangeState (State newState) => currentState = newState;
}
