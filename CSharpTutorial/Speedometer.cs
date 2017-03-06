using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
	class Speedometer
	{
		private int _currentSpeed;
		public int GetCurrentSpeed()
		{
			return _currentSpeed;
		}
		public void SetCurrentSpeed(int newSpeed)
		{
			if (newSpeed < 0) return;
			if (newSpeed > 120) return;
			_currentSpeed = newSpeed;
		}
		public int CurrentSpeed
		{
			get
			{
				return _currentSpeed;
			}
			set
			{
				if (value < 0) return;
				if (value > 120) return;
				//value is a keyword used in setters representing the new value
				_currentSpeed = value;
			}
		}

	}
}
