// Author: Matthew Lanteigne, Silverspun Software Solutions Inc.
// 

#region Namespace Imports

using System.Collections.Generic;
using System.Linq;
using mattlant.Imaging;

#endregion


namespace Gmf.Fpa.Imaging
{
	public class Interpolation
	{
		public static void GetInfluence(xyYColour pK,
		                         xyYColour pA,
		                         xyYColour pB,
		                         xyYColour pC,
		                         out double influenceA,
		                         out double influenceB,
		                         out double influenceC)
		{
			//1.	Get the 3 delta's (Euclidian distance) A, B, C from point K to point pA, pB, pC
			double deltaA = ColourUtil.Delta3D(pK.x, pK.y, pK.Y, pA.x, pA.y, pA.Y, 8);
			double deltaB = ColourUtil.Delta3D(pK.x, pK.y, pK.Y, pB.x, pB.y, pB.Y, 8);
			double deltaC = ColourUtil.Delta3D(pK.x, pK.y, pK.Y, pC.x, pC.y, pC.Y, 8);

			//2.	Inverse each distance and call invA, invB, invC			
			double inverseA = 1/deltaA;
			double inverseB = 1/deltaB;
			double inverseC = 1/deltaC;

			//3.	Let  t = invA + invB + invC
			double total = inverseA + inverseB + inverseC;

			//4.	divide each invA invB and invC by t. This yields the resulting influence  ia, ib, ic
			influenceA = inverseA/total;
			influenceB = inverseB/total;
			influenceC = inverseC/total;
		}

		//5.	given a point around each of pA, pB, pC called h, we get the distance to h, called hA, hB, hC

		public static double GetInterpolatedDistance(double dA,
		                                      double dB,
		                                      double dC,
		                                      double influenceA,
		                                      double influenceB,
		                                      double influenceC)
		{
			//6.	we multiply the influence for each distance and get ihA, ihB, ihC
			double idA = dA*influenceA;
			double idB = dB*influenceB;
			double idC = dC*influenceC;

			//7.	We sum ihA + ihB + ihC and that gets the final interpolated point pK
			return idA + idB + idC;
		}

		public static IEnumerable<xyYColour> GetThreeClosestColours(xyYColour refColour, ObserverData observer)
		{
			var closest = new List<xyYColour>();

			var orderedByDistance = observer.ColourData.Select(kvp => new
			                                                          	{
			                                                          		Colour = kvp.Key,
			                                                          		Distance =
			                                                          	ColourUtil.Delta3D(refColour.x, refColour.y, refColour.Y,
			                                                          	                   kvp.Key.x, kvp.Key.y, kvp.Key.Y, 8)
			                                                          	});

			orderedByDistance = orderedByDistance.OrderBy(item => item.Distance);

			return orderedByDistance.Take(3).Select(item => item.Colour);
		}

		//8.	We do this for the other 7 points around K
	}
}