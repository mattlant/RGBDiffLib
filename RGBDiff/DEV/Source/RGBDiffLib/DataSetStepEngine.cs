using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mattlant.Imaging;
using silverspun.RGBDiff.Dal.EntityClasses;
using silverspun.RGBDiff.Dal.Linq;

namespace RGBDiffLib
{
	public class DataSetStepEngine
	{
		private int _controlSetUID;
		private readonly double _startOffset;
		private readonly double _adjustSize;

		private readonly xyYColour[] _controlColours;

		public int CurrentStep { get; private set; }
		public int TotalSteps { get; private set; }
		private int _currentControlColourIndex = 0;

		private readonly ObserverDataSetEntity _observerDataSet;

		public float PercentComplete
		{
			get
			{ return (float) CurrentStep/(float) TotalSteps; }
		}

		public ColourStepEngine ColourStepEngine { get; private set; }

		public DataSetStepEngine(int controlSetUID, double startOffset, double adjustSize)
		{
			_controlSetUID = controlSetUID;
			_startOffset = startOffset;
			_adjustSize = adjustSize;

			LinqMetaData meta = new LinqMetaData();

			_controlColours =
				meta.ControlSetColour.Where(csc => csc.ControlSetUID == controlSetUID && csc.SkipForObserverInput == false).Select(
					csc => xyYColour.FromxyY(csc.XyY_x, csc.XyY_y, csc.XyY_YY)).ToArray();

			CurrentStep = 0;
			TotalSteps = _controlColours.Length*8;

			_currentControlColourIndex = -1;

			_observerDataSet = new ObserverDataSetEntity
			                   	{
			                   		ControlSetUID = controlSetUID,
			                   		StartDateTime = DateTime.Now,
			                   		EndDateTime = DateTime.Now
			                   	};
			//_observerDataSet.Save();

			SetNextControlColour();

		}

		private bool SetNextControlColour()
		{
			if(CurrentControlColourIndex == _controlColours.Length - 1)
				return true;
			_currentControlColourIndex = CurrentControlColourIndex + 1;

			xyYColour currentColour = _controlColours[CurrentControlColourIndex];
			ColourStepEngine = new ColourStepEngine(StartOffset, AdjustSize, currentColour.x, currentColour.y, currentColour.Y);
			return false;
		}

		public xyYColour CurrentControlColour
		{
			get { return _controlColours[CurrentControlColourIndex]; }
		}

		public xyYColour CurrentObserverColour
		{
			get { return this.ColourStepEngine.CurrentStepColour; }
		}

		public int CurrentControlColourIndex
		{
			get { return _currentControlColourIndex; }
		}

		public double StartOffset
		{
			get { return _startOffset; }
		}

		public double AdjustSize
		{
			get { return _adjustSize; }
		}

		public bool AcceptColourAtAngle()
		{
			CurrentStep++;
			xyYColour currentColour = CurrentControlColour;
			xyYColour acceptedCOlour = ColourStepEngine.CurrentStepColour;

			ObserverDataSetColourEntity observerDataSetColourEntity = new ObserverDataSetColourEntity();
			//observerDataSetColourEntity.ObserverDataSetUID = _observerDataSet.UID;
			//observerDataSetColourEntity.ObserverDataSet = _observerDataSet;
			observerDataSetColourEntity.ControlSetColourUID = 0;
			observerDataSetColourEntity.SubmitDateTime = DateTime.Now;
			//TODO: Do Not Accept Out Of Gamut
			observerDataSetColourEntity.OutOfGamut = false;
			observerDataSetColourEntity.Angle = ColourStepEngine.CurrentAngle;
			observerDataSetColourEntity.ControlxyY_x = currentColour.x;
			observerDataSetColourEntity.ControlxyY_y = currentColour.y;
			observerDataSetColourEntity.ControlxyY_YY = currentColour.Y;
			observerDataSetColourEntity.XyY_x = acceptedCOlour.x;
			observerDataSetColourEntity.XyY_y = acceptedCOlour.y;
			observerDataSetColourEntity.XyY_YY = acceptedCOlour.Y;

			_observerDataSet.ObserverDataSetColourCollection.Add(observerDataSetColourEntity);
			//observerDataSetColourEntity.Save();

			if (!this.ColourStepEngine.NextAngle())
				return false;

			bool done = SetNextControlColour();
			if (done)
			{
				//Email Dave
				_observerDataSet.EndDateTime = DateTime.Now;
				_observerDataSet.Save(true);
			}

			return done;
		}
	}
}
