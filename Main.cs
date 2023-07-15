using MelonLoader;
using UnityEngine;
using System.IO;
using BoneLib.BoneMenu;
using System;
using BoneLib.BoneMenu.Elements;

using System.Runtime.CompilerServices;
using BoneLib;
using SLZ.VRMK;
using System.Security.Policy;
using System.Collections.Generic;

namespace bonelab_template
{
    internal partial class Main : MelonMod
    {

        public override void OnInitializeMelon()
        {
            Hooking.OnLevelInitialized += (_) => { OnSceneAwake(); };
        }

        private static void OnSceneAwake()
        {
            var objectsWithKeyword = Transform.FindObjectsOfType<Transform>(true);
            var ryrjytrty = GameObject.FindObjectsOfType<GameObject>(true);
            foreach (Transform obj in objectsWithKeyword)
            {
                if (obj.name.Contains("FLOORS") || obj.name.Contains("LoadButtons"))
                {
                    if (obj.name.Contains("NEXTLEVEL"))
                    {
                        continue;
                    }
                   
                    for (int i = 0; i < obj.childCount; i++)
                    {
                        if (i == 10 || i == 11)
                        {
                            continue;
                        }
                        Transform child = obj.GetChild(i);
                        SLZ.Interaction.ButtonToggle ButtonToggle = child.GetComponent<SLZ.Interaction.ButtonToggle>();
                        if (ButtonToggle != null)
                        {
                            ButtonToggle.enabled = false;
                        }
                    }
                }
            }
        }
    }
}
