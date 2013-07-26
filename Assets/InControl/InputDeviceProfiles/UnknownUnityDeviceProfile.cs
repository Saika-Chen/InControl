using System;
using System.Collections;
using System.Collections.Generic;


namespace InControl
{
	public class UnknownUnityDeviceProfile : InputDeviceProfile
	{
		public const int MaxUnityButtons = 20;
		public const int MaxUnityAnalogs = 10;


		public UnknownUnityDeviceProfile( string joystickName )
		{
			Name = "Unknown Device";
			if (joystickName != "")
			{
				Name += " (" + joystickName + ")";
			}

			Meta = "";
			Sensitivity = 1.0f;
			DeadZone = 0.2f;

			SupportedPlatforms = null;
			JoystickNames = new List<string>() { joystickName };

			AnalogMappings = new InputControlAnalogMapping[ MaxUnityAnalogs ];
			for (int i = 0; i < MaxUnityAnalogs; i++)
			{
				AnalogMappings[i] = new InputControlAnalogMapping( i );
			}

			ButtonMappings = new InputControlButtonMapping[ MaxUnityButtons ];
			for (int i = 0; i < MaxUnityButtons; i++)
			{
				ButtonMappings[i] = new InputControlButtonMapping( i );
			}
		}
	}
}

