// Final Print Assurance
// Copyright 2009 GMF Flexo Prepress Inc.
// Author: Matthew Lanteigne, Silverspun Software Solutions Inc.

#region Namespace Imports

using System;
using System.Collections.Generic;
using mattlant.Imaging;

#endregion


namespace RGBDiffLib
{
	public class ColourStepEngine
	{
		private readonly double _startOffset;
		private readonly double _adjustSize;

		private readonly xyYColour _controlxyYColour;

		private int _currentAngleIncremenmtIndexer;

		private xyYColour[] _currentColourOffsets;
		private int _totalAngleCount = 8;
		private const int _safetyCounterLimit = 10000;

		public ColourStepEngine(double startOffset, double adjustSize, double x, double y, double Y)
		{
			_startOffset = startOffset;
			_adjustSize = adjustSize;

			_controlxyYColour = xyYColour.FromxyY(x, y, Y);

			//Generate All colours for steps before hand!
			
			NextAngle();
		}

		public int CurrentAngle { get; private set; }
		public int CurrentAngleCounter { get; private set; }

		//Returns false if no more angles
		public bool NextAngle()
		{
			_currentAngleIncremenmtIndexer = 0;
			CurrentAngleCounter++;
			switch (CurrentAngleCounter)
			{
				case 1:
					CurrentAngle = 0;
					_currentColourOffsets = GenerateColourListFor0Degrees();
					break;
				case 2:
					CurrentAngle = 45;
					_currentColourOffsets = GenerateColourListFor45Degrees();
					break;
				case 3:
					CurrentAngle = 90;
					_currentColourOffsets = GenerateColourListFor90Degrees();
					break;
				case 4:
					CurrentAngle = 135;
					_currentColourOffsets = GenerateColourListFor135Degrees();
					break;
				case 5:
					CurrentAngle = 180;
					_currentColourOffsets = GenerateColourListFor180Degrees();
					break;
				case 6:
					CurrentAngle = 225;
					_currentColourOffsets = GenerateColourListFor225Degrees();
					break;
				case 7:
					CurrentAngle = 270;
					_currentColourOffsets = GenerateColourListFor270Degrees();
					break;
				case 8:
					CurrentAngle = 315;
					_currentColourOffsets = GenerateColourListFor315Degrees();
					break;
				default:
					return true;
			}

			return false;
		}

		#region Step Management

		public int CurrentStepIndex
		{
			get { return _currentAngleIncremenmtIndexer; }
			private set { _currentAngleIncremenmtIndexer = value; }
		}

		public int FirstStepIndex
		{
			get { return 0; }
		}

		private int LastStepIndex
		{
			get { return _currentColourOffsets.Length - 1; }
		}

		public bool IsLastStep
		{
			get { return CurrentStepIndex == LastStepIndex; }
		}

		public bool IsFirstStep
		{
			get { return CurrentStepIndex == FirstStepIndex; }
		}

		public xyYColour CurrentStepColour
		{
			get
			{
				return _currentColourOffsets[CurrentStepIndex];
			}
		}

		public void IncrementStep()
		{
			IncrementStep(1);
		}

		public void IncrementStep(int stepsToIncrement)
		{
			if (WillIncrementTooFar(stepsToIncrement))
			{
				CurrentStepIndex = LastStepIndex;
				return;
			}
			CurrentStepIndex += stepsToIncrement;
		}

		public void GotoLastStep()
		{
			_currentAngleIncremenmtIndexer = LastStepIndex;
		}

		public void DecrementStep()
		{
			DecrementStep(1);
		}

		public void DecrementStep(int stepsToDecrement)
		{
			if (WillDecrementTooFar(stepsToDecrement))
			{
				CurrentStepIndex = FirstStepIndex;
				return;
			}
			CurrentStepIndex -= stepsToDecrement;
		}

		public void GotoFirstStep()
		{
			CurrentStepIndex = FirstStepIndex;
		}

		private bool WillIncrementTooFar(int increment)
		{
			return CurrentStepIndex + increment > LastStepIndex;
		}

		private bool WillDecrementTooFar(int stepsToDecrement)
		{
			return CurrentStepIndex - stepsToDecrement < 0;
		}

		#endregion

		#region Colour Step Generators

		private xyYColour[] GenerateColourListFor0Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x;
			double y = _controlxyYColour.y - _startOffset;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (y < _controlxyYColour.y)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				y += _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		private xyYColour[] GenerateColourListFor90Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x + _startOffset;
			double y = _controlxyYColour.y;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (x > _controlxyYColour.x)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				x -= _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		private xyYColour[] GenerateColourListFor180Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x;
			double y = _controlxyYColour.y + _startOffset;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (y > _controlxyYColour.y)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				y -= _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		private xyYColour[] GenerateColourListFor270Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x - _startOffset;
			double y = _controlxyYColour.y;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (x < _controlxyYColour.x)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				x += _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		private xyYColour[] GenerateColourListFor45Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x + _startOffset;
			double y = _controlxyYColour.y - _startOffset;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (y < _controlxyYColour.y)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				x -= _adjustSize;
				y += _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		private xyYColour[] GenerateColourListFor135Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x + _startOffset;
			double y = _controlxyYColour.y + _startOffset;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (y > _controlxyYColour.y)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				x -= _adjustSize;
				y -= _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		private xyYColour[] GenerateColourListFor225Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x - _startOffset;
			double y = _controlxyYColour.y + _startOffset;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (y > _controlxyYColour.y)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				x += _adjustSize;
				y -= _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		private xyYColour[] GenerateColourListFor315Degrees()
		{
			var _colourSet = new List<xyYColour>();
			double x = _controlxyYColour.x - _startOffset;
			double y = _controlxyYColour.y - _startOffset;
			double Y = _controlxyYColour.Y;

			int safetyCounter = 0;

			while (y < _controlxyYColour.y)
			{
				_colourSet.Add(xyYColour.FromxyY(x, y, Y));
				x += _adjustSize;
				y += _adjustSize;

				if (safetyCounter++ > _safetyCounterLimit)
					throw new ApplicationException("Counter overflow");
			}

			return _colourSet.ToArray();
		}

		#endregion
	}
}