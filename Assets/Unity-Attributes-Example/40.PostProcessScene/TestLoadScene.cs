﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAttributesExample {

    public class TestLoadScene : MonoBehaviour {

        public int sceneIndex;

        void OnGUI() {

            if (GUILayout.Button("Load Scene")) {
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
            }

        }

    }

}
