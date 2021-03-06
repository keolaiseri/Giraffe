// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on the value of a String Variable.")]
	public class StringSwitch : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
        [Tooltip("The String Variable to test.")]
        public FsmString stringVariable;
		[CompoundArray("String Switches", "Compare String", "Send Event")]
        [Tooltip("Compare to a string value.")]
        public FsmString[] compareTo;
        [Tooltip("Send this event if string matches.")]
        public FsmEvent[] sendEvent;
        [Tooltip("Repeat every frame.")]
        public bool everyFrame;

		public override void Reset()
		{
			stringVariable = null;
			compareTo = new FsmString[1];
			sendEvent = new FsmEvent[1];
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoStringSwitch();
			
			if (!everyFrame)
				Finish();
		}

		public override void OnUpdate()
		{
			DoStringSwitch();
		}
		
		void DoStringSwitch()
		{
			if (stringVariable.IsNone)
				return;
			
			for (int i = 0; i < compareTo.Length; i++) 
			{
				if (stringVariable.Value == compareTo[i].Value)
				{
					Fsm.Event(sendEvent[i]);
					return;
				}
			}
		}
	}
}