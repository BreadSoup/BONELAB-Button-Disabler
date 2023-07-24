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

namespace ButtonDisabler
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
            foreach (Transform obj in objectsWithKeyword)
            {
                if (obj.name.Contains("FLOORS") || obj.name.Contains("LoadButtons") || obj.name.Contains("prop_bigButton") || obj.name.Contains("INTERACTION"))
                {

                    for (int i = 0; i < obj.childCount; i++)
                    {
                        Transform child = obj.GetChild(i);
                        SLZ.Interaction.ButtonToggle ButtonToggle = child.GetComponent<SLZ.Interaction.ButtonToggle>();
                        if (ButtonToggle != null && !child.name.Contains("prop_bigButton_NEXTLEVEL"))
                        {
                            ButtonToggle.enabled = false;
                        }
                    }
                }
            }
        }
    }
}
