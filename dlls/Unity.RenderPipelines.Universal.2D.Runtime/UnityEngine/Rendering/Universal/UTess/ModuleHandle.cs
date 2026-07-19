using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.UTess;

[StructLayout(LayoutKind.Sequential, Size = 1)]
internal struct PlanarGraph
{
	private static readonly double kEpsilon = 1E-05;

	private static readonly int kMaxIntersectionTolerance = 4;

	internal unsafe static void RemoveDuplicateEdges(ref NativeArray<int2> edges, ref int edgeCount, NativeArray<int> duplicates, int duplicateCount)
	{
		if (duplicateCount == 0)
		{
			int i;
			for (int i = 0; i < edgeCount; i++)
			{
				int2 value = edges[i];
				int2 value;
				value.x = math.min(edges[i].x, edges[i].y);
				value.y = math.max(edges[i].x, edges[i].y);
				edges[i] = value;
			}
		}
		else
		{
			int j;
			for (int j = 0; j < edgeCount; j++)
			{
				int2 value2 = edges[j];
				int2 value2;
				int x = duplicates[value2.x];
				int y = duplicates[value2.y];
				int x;
				int y;
				value2.x = math.min(x, y);
				value2.y = math.max(x, y);
				edges[j] = value2;
			}
		}
		ModuleHandle.InsertionSort<int2, TessEdgeCompare>(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(edges), 0, edgeCount - 1, default(TessEdgeCompare));
		int num = 1;
		int k;
		int num;
		for (int k = 1; k < edgeCount; k++)
		{
			int2 int5 = edges[k - 1];
			int2 value3 = edges[k];
			int2 value3;
			int2 int5;
			if ((value3.x != int5.x || value3.y != int5.y) && value3.x != value3.y)
			{
				edges[num++] = value3;
			}
		}
		edgeCount = num;
	}

	internal static bool CheckCollinear(double2 a0, double2 a1, double2 b0, double2 b1)
	{
		double2 double5 = a0;
		double2 double6 = a1;
		double2 double7 = b0;
		double2 double8 = b1;
		double2 double6;
		double2 double5;
		double num = (double6.y - double5.y) / (double6.x - double5.x);
		double2 double7;
		double num2 = (double7.y - double5.y) / (double7.x - double5.x);
		double2 double8;
		double num3 = (double8.y - double5.y) / (double8.x - double5.x);
		double num;
		double num2;
		double num3;
		if ((!math.isinf(num) || !math.isinf(num2) || !math.isinf(num3)) && math.abs(num - num2) > kEpsilon)
		{
			return math.abs(num - num3) > kEpsilon;
		}
		return false;
	}

	internal static bool LineLineIntersection(double2 a0, double2 a1, double2 b0, double2 b1)
	{
		double num = ModuleHandle.OrientFastDouble(a0, b0, b1);
		double num2 = ModuleHandle.OrientFastDouble(a1, b0, b1);
		double num;
		double num2;
		if ((num > kEpsilon && num2 > kEpsilon) || (num < 0.0 - kEpsilon && num2 < 0.0 - kEpsilon))
		{
			return false;
		}
		double num3 = ModuleHandle.OrientFastDouble(b0, a0, a1);
		double num4 = ModuleHandle.OrientFastDouble(b1, a0, a1);
		double num3;
		double num4;
		if ((num3 > kEpsilon && num4 > kEpsilon) || (num3 < 0.0 - kEpsilon && num4 < 0.0 - kEpsilon))
		{
			return false;
		}
		if (math.abs(num) < kEpsilon && math.abs(num2) < kEpsilon && math.abs(num3) < kEpsilon && math.abs(num4) < kEpsilon)
		{
			return CheckCollinear(a0, a1, b0, b1);
		}
		return true;
	}

	internal static bool LineLineIntersection(double2 p1, double2 p2, double2 p3, double2 p4, ref double2 result)
	{
		double num = p2.x - p1.x;
		double num2 = p2.y - p1.y;
		double num3 = p4.x - p3.x;
		double num4 = p4.y - p3.y;
		double num;
		double num4;
		double num2;
		double num3;
		double num5 = num * num4 - num2 * num3;
		double num5;
		if (math.abs(num5) < kEpsilon)
		{
			return false;
		}
		double num6 = p3.x - p1.x;
		double num7 = p3.y - p1.y;
		double num6;
		double num7;
		double num8 = (num6 * num4 - num7 * num3) / num5;
		double num8;
		if (num8 >= 0.0 - kEpsilon && num8 <= 1.0 + kEpsilon)
		{
			result.x = p1.x + num8 * num;
			result.y = p1.y + num8 * num2;
			return true;
		}
		return false;
	}

	internal unsafe static bool CalculateEdgeIntersections(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, ref NativeArray<int2> results, ref NativeArray<double2> intersects, ref int resultCount)
	{
		resultCount = 0;
		int i;
		for (int i = 0; i < edgeCount; i++)
		{
			int j;
			for (int j = i + 1; j < edgeCount; j++)
			{
				int2 int5 = edges[i];
				int2 int6 = edges[j];
				int2 int5;
				int2 int6;
				if (int5.x == int6.x || int5.x == int6.y || int5.y == int6.x || int5.y == int6.y)
				{
					continue;
				}
				double2 double5 = points[int5.x];
				double2 double6 = points[int5.y];
				double2 double7 = points[int6.x];
				double2 double8 = points[int6.y];
				double2 result = double2.zero;
				double2 double5;
				double2 double6;
				double2 double7;
				double2 double8;
				double2 result;
				if (LineLineIntersection(double5, double6, double7, double8) && LineLineIntersection(double5, double6, double7, double8, ref result))
				{
					if (resultCount >= intersects.Length)
					{
						return false;
					}
					intersects[resultCount] = result;
					results[resultCount++] = new int2(i, j);
				}
			}
		}
		if (resultCount > edgeCount * kMaxIntersectionTolerance)
		{
			return false;
		}
		ModuleHandle.InsertionSort<int2, IntersectionCompare>(comp: new IntersectionCompare
		{
			edges = edges,
			points = points
		}, array: NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(results), lo: 0, hi: resultCount - 1);
		return true;
	}

	internal static bool CalculateTJunctions(NativeArray<int2> edges, int edgeCount, NativeArray<double2> points, int pointCount, NativeArray<int2> results, ref int resultCount)
	{
		resultCount = 0;
		int i;
		for (int i = 0; i < edgeCount; i++)
		{
			int j;
			for (int j = 0; j < pointCount; j++)
			{
				int2 int5 = edges[i];
				int2 int5;
				if (int5.x == j || int5.y == j)
				{
					continue;
				}
				double2 a = points[int5.x];
				double2 a2 = points[int5.y];
				double2 b = points[j];
				double2 b2 = points[j];
				double2 a;
				double2 a2;
				double2 b;
				double2 b2;
				if (LineLineIntersection(a, a2, b, b2))
				{
					if (resultCount >= results.Length)
					{
						return false;
					}
					results[resultCount++] = new int2(i, j);
				}
			}
		}
		return true;
	}

	internal unsafe static bool CutEdges(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int2> edges, ref int edgeCount, ref NativeArray<int2> tJunctions, ref int tJunctionCount, NativeArray<int2> intersections, NativeArray<double2> intersects, int intersectionCount)
	{
		int i;
		for (int i = 0; i < intersectionCount; i++)
		{
			int2 obj = intersections[i];
			int2 obj;
			int x = obj.x;
			int y = obj.y;
			int2 zero = int2.zero;
			int2 zero;
			int x;
			zero.x = x;
			zero.y = pointCount;
			tJunctions[tJunctionCount++] = zero;
			int2 zero2 = int2.zero;
			int2 zero2;
			int y;
			zero2.x = y;
			zero2.y = pointCount;
			tJunctions[tJunctionCount++] = zero2;
			if (pointCount >= points.Length)
			{
				return false;
			}
			points[pointCount++] = intersects[i];
		}
		ModuleHandle.InsertionSort<int2, TessJunctionCompare>(NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks(tJunctions), 0, tJunctionCount - 1, default(TessJunctionCompare));
		int num;
		for (int num = tJunctionCount - 1; num >= 0; num--)
		{
			int2 int5 = tJunctions[num];
			int2 int5;
			int x2 = int5.x;
			int x2;
			int2 value = edges[x2];
			int2 value;
			int num2 = value.x;
			int num3 = value.y;
			int num2;
			double2 double5 = points[num2];
			int num3;
			double2 double6 = points[num3];
			double2 double5;
			double2 double6;
			if (double5.x - double6.x < 0.0 || (double5.x == double6.x && double5.y - double6.y < 0.0))
			{
				int num4 = num2;
				num2 = num3;
				int num4;
				num3 = num4;
			}
			value.x = num2;
			int x3 = (value.y = int5.y);
			edges[x2] = value;
			int x3;
			while (num > 0 && tJunctions[num - 1].x == x2)
			{
				int y2 = tJunctions[--num].y;
				int y2;
				int2 value2 = new int2
				{
					x = x3,
					y = y2
				};
				int2 value2;
				edges[edgeCount++] = value2;
				x3 = y2;
			}
			int2 value3 = new int2
			{
				x = x3,
				y = num3
			};
			int2 value3;
			edges[edgeCount++] = value3;
		}
		return true;
	}

	internal static void RemoveDuplicatePoints(ref NativeArray<double2> points, ref int pointCount, ref NativeArray<int> duplicates, ref int duplicateCount, Allocator allocator)
	{
		TessLink link = TessLink.CreateLink(pointCount, allocator);
		int i;
		TessLink link;
		for (int i = 0; i < pointCount; i++)
		{
			int j;
			for (int j = i + 1; j < pointCount; j++)
			{
				if (math.distance(points[i], points[j]) < kEpsilon)
				{
					link.Link(i, j);
				}
			}
		}
		duplicateCount = 0;
		int k;
		for (int k = 0; k < pointCount; k++)
		{
			int num = link.Find(k);
			int num;
			if (num != k)
			{
				duplicateCount++;
				points[num] = math.min(points[k], points[num]);
			}
		}
		if (duplicateCount != 0)
		{
			int num2 = pointCount;
			pointCount = 0;
			int l;
			int num2;
			for (int l = 0; l < num2; l++)
			{
				if (link.Find(l) == l)
				{
					duplicates[l] = pointCount;
					points[pointCount++] = points[l];
				}
				else
				{
					duplicates[l] = -1;
				}
			}
			int m;
			for (int m = 0; m < num2; m++)
			{
				if (duplicates[m] < 0)
				{
					duplicates[m] = duplicates[link.Find(m)];
				}
			}
		}
		TessLink.DestroyLink(link);
	}

	internal static bool Validate(Allocator allocator, NativeArray<float2> inputPoints, int pointCount, NativeArray<int2> inputEdges, int edgeCount, ref NativeArray<float2> outputPoints, ref int outputPointCount, ref NativeArray<int2> outputEdges, ref int outputEdgeCount)
	{
		float num = 10000f;
		int num2 = edgeCount;
		bool flag = true;
		bool flag2 = false;
		NativeArray<int> duplicates = new NativeArray<int>(ModuleHandle.kMaxEdgeCount, allocator);
		NativeArray<int2> edges = new NativeArray<int2>(ModuleHandle.kMaxEdgeCount, allocator);
		NativeArray<int2> tJunctions = new NativeArray<int2>(ModuleHandle.kMaxEdgeCount, allocator);
		NativeArray<int2> results = new NativeArray<int2>(ModuleHandle.kMaxEdgeCount, allocator);
		NativeArray<double2> points = new NativeArray<double2>(pointCount * 8, allocator);
		NativeArray<double2> intersects = new NativeArray<double2>(pointCount * 8, allocator);
		int i;
		NativeArray<double2> points;
		float num;
		for (int i = 0; i < pointCount; i++)
		{
			points[i] = inputPoints[i] * num;
		}
		NativeArray<int2> edges;
		ModuleHandle.Copy(inputEdges, edges, edgeCount);
		NativeArray<int> duplicates;
		RemoveDuplicateEdges(ref edges, ref edgeCount, duplicates, 0);
		bool flag;
		int num2;
		bool flag2;
		NativeArray<int2> results;
		NativeArray<double2> intersects;
		NativeArray<int2> tJunctions;
		while (flag && --num2 > 0)
		{
			int resultCount = 0;
			int resultCount;
			flag2 = CalculateEdgeIntersections(edges, edgeCount, points, pointCount, ref results, ref intersects, ref resultCount);
			if (!flag2)
			{
				break;
			}
			int resultCount2 = 0;
			int resultCount2;
			flag2 = CalculateTJunctions(edges, edgeCount, points, pointCount, tJunctions, ref resultCount2);
			if (!flag2)
			{
				break;
			}
			flag2 = CutEdges(ref points, ref pointCount, ref edges, ref edgeCount, ref tJunctions, ref resultCount2, results, intersects, resultCount);
			if (!flag2)
			{
				break;
			}
			int duplicateCount = 0;
			int duplicateCount;
			RemoveDuplicatePoints(ref points, ref pointCount, ref duplicates, ref duplicateCount, allocator);
			RemoveDuplicateEdges(ref edges, ref edgeCount, duplicates, duplicateCount);
			flag = resultCount != 0 || resultCount2 != 0;
		}
		if (flag2)
		{
			outputEdgeCount = edgeCount;
			outputPointCount = pointCount;
			ModuleHandle.Copy(edges, outputEdges, edgeCount);
			int j;
			for (int j = 0; j < pointCount; j++)
			{
				outputPoints[j] = new float2((float)(points[j].x / (double)num), (float)(points[j].y / (double)num));
			}
		}
		edges.Dispose();
		points.Dispose();
		intersects.Dispose();
		duplicates.Dispose();
		tJunctions.Dispose();
		results.Dispose();
		if (flag2)
		{
			return num2 > 0;
		}
		return false;
	}
}
