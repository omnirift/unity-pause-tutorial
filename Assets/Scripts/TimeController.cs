using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class TimeController : MonoBehaviour {

    private bool paused = false;

    #region Monobehaviour API

	void Update ()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            if (paused)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;

            paused = !paused;
        }
    }

    #endregion
}
