// (c) Copyright HutongGames, LLC 2010-2016. All rights reserved.

using UnityEngine;
using HutongGames.PlayMaker.Actions;

namespace HutongGames.PlayMakerEditor
{
    [CustomActionEditor(typeof(GetAnimatorCurrentTransitionInfoIsUserName))]
    public class GetAnimatorCurrentTransitionInfoIsUserNameActionEditor : OnAnimatorUpdateActionEditorBase
    {

        public override bool OnGUI()
        {
            EditField("gameObject");
            EditField("layerIndex");
            EditField("userName");

            EditField("nameMatch");
            EditField("nameMatchEvent");
            EditField("nameDoNotMatchEvent");

            bool changed = EditEveryFrameField();

            return GUI.changed || changed;
        }

    }
}