using System;

public static class EventManager {
    
    /// <summary>
    /// Resets all events
    /// </summary>
    public static void Reset() {
        OnPlayerHurt = null;
        OnPlayerRecovered = null;
        OnPlayerInvincible = null;
        OnPlayerNotInvincible = null;
    }
    
    /// <summary>
    /// Event triggered when the Player gets hurt
    /// </summary>
    public static event Action OnPlayerHurt;

    /// <summary>
    /// Invokes the OnPlayerHurt event
    /// </summary>
    public static void InvokeOnPlayerHurt() {
        OnPlayerHurt.Invoke();
    }

    /// <summary>
    /// Event triggered when the Player recovered
    /// </summary>
    public static event Action OnPlayerRecovered;

    /// <summary>
    /// Invokes the OnPlayerRecovered event
    /// </summary>
    public static void InvokeOnPlayerRecovered() {
        OnPlayerRecovered.Invoke();
    }

    public static event Action OnPlayerInvincible;

    /// <summary>
    /// Invokes the OnPlayerInvincible event
    /// </summary>
    public static void InvokeOnPlayerInvincible() {
        OnPlayerInvincible.Invoke();
    }


    public static event Action OnPlayerNotInvincible;

    /// <summary>
    /// Invokes the OnPlayerNotInvincible event
    /// </summary>
    public static void InvokeOnPlayerNotInvincible() {
        OnPlayerNotInvincible.Invoke();
    }
}