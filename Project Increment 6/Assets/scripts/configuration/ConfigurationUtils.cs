﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Properties

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return 10; }
    }

    /// <summary>
    /// Gets the impulse force to apply to a ball
    /// to get it moving
    /// </summary>
    public static float BallImpulseForce
    {
        get { return 5; }
    }

    /// <summary>
    /// Gets how many seconds a ball stays alive
    /// </summary>
    public static float BallLifeSeconds
    {
        get { return 10; }
    }

    /// <summary>
    /// Gets the min spawn delay for ball spawning
    /// </summary>
    public static float MinSpawnDelay
    {
        get { return 5; }
    }

    /// <summary>
    /// Gets the max spawn delay for ball spawning
    /// </summary>
    public static float MaxSpawnDelay
    {
        get { return 10; }
    }

    /// <summary>
    /// Gets the number of points a standard ball is worth
    /// </summary>
    public static int StandardPoints
    {
        get { return 1; }
    }

    /// <summary>
    /// Gets the number of hits a standard ball is worth
    /// </summary>
    public static int StandardHits
    {
        get { return 1; }
    }

    /// <summary>
    /// Gets the number of points a bonus ball is worth
    /// </summary>
    public static int BonusPoints
    {
        get { return 2; }
    }

    /// <summary>
    /// Gets the number of hits a bonus ball is worth
    /// </summary>
    public static int BonusHits
    {
        get { return 2; }
    }

    /// <summary>
    /// Gets the number of seconds the freezer effect lasts
    /// </summary>
    public static float FreezerSeconds
    {
        get { return 2; }
    }

    /// <summary>
    /// Gets the probability of spawning a standard ball
    /// </summary>
    public static float StandardBallSpawnProbability
    {
        get { return 0.5f; }
     }

    /// <summary>
    /// Gets the probability of spawning a bonus ball
    /// </summary>
    public static float BonusBallSpawnProbability
    {
        get { return 0.25f; }
    }

    /// <summary>
    /// Gets the probability of spawning a freezer pickup
    /// </summary>
    public static float FreezerPickupSpawnProbability
    {
        get { return 0.25f; }
     }
 
    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {

    }
}
