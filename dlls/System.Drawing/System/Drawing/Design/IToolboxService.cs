using System.Runtime.InteropServices;

namespace System.Drawing.Drawing2D;

/// <summary>Encapsulates a 3-by-3 affine matrix that represents a geometric transform. This class cannot be inherited.</summary>
public sealed class Matrix : MarshalByRefObject, IDisposable
{
	internal IntPtr nativeMatrix;

	/// <summary>Gets an array of floating-point values that represents the elements of this <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
	/// <returns>An array of floating-point values that represents the elements of this <see cref="T:System.Drawing.Drawing2D.Matrix" />.</returns>
	public float[] Elements
	{
		get
		{
			float[] array = new float[6];
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(float)) * 6);
			try
			{
				GDIPlus.CheckStatus(GDIPlus.GdipGetMatrixElements(nativeMatrix, intPtr));
				Marshal.Copy(intPtr, array, 0, 6);
				return array;
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	/// <summary>Gets a value indicating whether this <see cref="T:System.Drawing.Drawing2D.Matrix" /> is the identity matrix.</summary>
	/// <returns>This property is <see langword="true" /> if this <see cref="T:System.Drawing.Drawing2D.Matrix" /> is identity; otherwise, <see langword="false" />.</returns>
	public bool IsIdentity
	{
		get
		{
			GDIPlus.CheckStatus(GDIPlus.GdipIsMatrixIdentity(nativeMatrix, out var result));
			return result;
		}
	}

	/// <summary>Gets a value indicating whether this <see cref="T:System.Drawing.Drawing2D.Matrix" /> is invertible.</summary>
	/// <returns>This property is <see langword="true" /> if this <see cref="T:System.Drawing.Drawing2D.Matrix" /> is invertible; otherwise, <see langword="false" />.</returns>
	public bool IsInvertible
	{
		get
		{
			GDIPlus.CheckStatus(GDIPlus.GdipIsMatrixInvertible(nativeMatrix, out var result));
			return result;
		}
	}

	/// <summary>Gets the x translation value (the dx value, or the element in the third row and first column) of this <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
	/// <returns>The x translation value of this <see cref="T:System.Drawing.Drawing2D.Matrix" />.</returns>
	public float OffsetX => Elements[4];

	/// <summary>Gets the y translation value (the dy value, or the element in the third row and second column) of this <see cref="T:System.Drawing.Drawing2D.Matrix" />.</summary>
	/// <returns>The y translation value of this <see cref="T:System.Drawing.Drawing2D.Matrix" />.</returns>
	public float OffsetY => Elements[5];

	internal IntPtr NativeObject
	{
		get
		{
			return nativeMatrix;
		}
		set
		{
			nativeMatrix = value;
		}
	}

	internal Matrix(IntPtr ptr)
	{
		nativeMatrix = ptr;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Drawing2D.Matrix" /> class as the identity matrix.</summary>
	public Matrix()
	{
		GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix(out nativeMatrix));
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Drawing2D.Matrix" /> class to the geometric transform defined by the specified rectangle and array of points.</summary>
	/// <param name="rect">A <see cref="T:System.Drawing.Rectangle" /> structure that represents the rectangle to be transformed.</param>
	/// <param name="plgpts">An array of three <see cref="T:System.Drawing.Point" /> structures that represents the points of a parallelogram to which the upper-left, upper-right, and lower-left corners of the rectangle is to be transformed. The lower-right corner of the parallelogram is implied by the first three corners.</param>
	public Matrix(Rectangle rect, Point[] plgpts)
	{
		if (plgpts == null)
		{
			throw new ArgumentNullException("plgpts");
		}
		if (plgpts.Length != 3)
		{
			throw new ArgumentException("plgpts");
		}
		GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix3I(ref rect, plgpts, out nativeMatrix));
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Drawing.Drawing2D.Matrix" /> class to the geometric transform defined by the specified rectangle and array of points.</summary>
	/// <param name="rect">A <see cref="T:System.Drawing.RectangleF" /> structure that represents the rectangle to be transformed.</param>
	/// <param name="plgpts">An array of three <see cref="T:System.Drawing.PointF" /> structures that represents the points of a parallelogram to which the upper-left, upper-right, and lower-left corners of the rectangle is to be transformed. The lower-right corner of the parallelogram is implied by the first three corners.</param>
	public Matrix(RectangleF rect, PointF[] plgpts)
	{
		if (plgpts == null)
		{
			throw new ArgumentNullException("plgpts");
		}
		if (plgpts.Length != 3)
		{
			throw new ArgumentException("plgpts");
		}
		GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix3(ref rect, plgpts, out nativeMatrix));
	}

	public Matrix(float m11, float m12, float m21, float m22, float dx, float dy)
	{
		GDIPlus.CheckStatus(GDIPlus.GdipCreateMatrix2(m11, m12, m21, m22, dx, dy, out nativeMatrix));
	}

	public Matrix Clone()
	{
		GDIPlus.CheckStatus(GDIPlus.GdipCloneMatrix(nativeMatrix, out var cloneMatrix));
		return new Matrix(cloneMatrix);
	}

	public void Dispose()
	{
		if (nativeMatrix != IntPtr.Zero)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipDeleteMatrix(nativeMatrix));
			nativeMatrix = IntPtr.Zero;
		}
		GC.SuppressFinalize(this);
	}

	public override bool Equals(object obj)
	{
		if (obj is Matrix matrix)
		{
			GDIPlus.CheckStatus(GDIPlus.GdipIsMatrixEqual(nativeMatrix, matrix.nativeMatrix, out var result));
			return result;
		}
		return false;
	}

	~Matrix()
	{
		Dispose();
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}

	public void Invert()
	{
		GDIPlus.CheckStatus(GDIPlus.GdipInvertMatrix(nativeMatrix));
	}

	public void Multiply(Matrix matrix)
	{
		Multiply(matrix, MatrixOrder.Prepend);
	}

	public void Multiply(Matrix matrix, MatrixOrder order)
	{
		if (matrix == null)
		{
			throw new ArgumentNullException("matrix");
		}
		GDIPlus.CheckStatus(GDIPlus.GdipMultiplyMatrix(nativeMatrix, matrix.nativeMatrix, order));
	}

	public void Reset()
	{
		GDIPlus.CheckStatus(GDIPlus.GdipSetMatrixElements(nativeMatrix, 1f, 0f, 0f, 1f, 0f, 0f));
	}

	public void Rotate(float angle)
	{
		Rotate(angle, MatrixOrder.Prepend);
	}

	public void Rotate(float angle, MatrixOrder order)
	{
		GDIPlus.CheckStatus(GDIPlus.GdipRotateMatrix(nativeMatrix, angle, order));
	}

	public void RotateAt(float angle, PointF point)
	{
		RotateAt(angle, point, MatrixOrder.Prepend);
	}

	public void RotateAt(float angle, PointF point, MatrixOrder order)
	{
		if (order < MatrixOrder.Prepend || order > MatrixOrder.Append)
		{
			throw new ArgumentException("order");
		}
		angle *= MathF.PI / 180f;
		float num = (float)Math.Cos(angle);
		float num2 = (float)Math.Sin(angle);
		float num3 = 0f - point.X * num + point.Y * num2 + point.X;
		float num4 = 0f - point.X * num2 - point.Y * num + point.Y;
		float[] elements = Elements;
		Status status = order != MatrixOrder.Prepend ? GDIPlus.GdipSetMatrixElements(nativeMatrix, elements[0] * num + elements[1] * 0f - num2, elements[0] * num2 + elements[1] * num, elements[2] * num + elements[3] * 0f - num2, elements[2] * num2 + elements[3] * num, elements[4] * num + elements[5] * 0f - num2 + num3, elements[4] * num2 + elements[5] * num + num4) : GDIPlus.GdipSetMatrixElements(nativeMatrix, num * elements[0] + num2 * elements[2], num * elements[1] + num2 * elements[3], 0f - num2 * elements[0] + num * elements[2], 0f - num2 * elements[1] + num * elements[3], num3 * elements[0] + num4 * elements[2] + elements[4], num3 * elements[1] + num4 * elements[3] + elements[5]);
		GDIPlus.CheckStatus(status);
	}

	public void Scale(float scaleX, float scaleY)
	{
		Scale(scaleX, scaleY, MatrixOrder.Prepend);
	}

	public void Scale(float scaleX, float scaleY, MatrixOrder order)
	{
		GDIPlus.CheckStatus(GDIPlus.GdipScaleMatrix(nativeMatrix, scaleX, scaleY, order));
	}

	public void Shear(float shearX, float shearY)
	{
		Shear(shearX, shearY, MatrixOrder.Prepend);
	}

	public void Shear(float shearX, float shearY, MatrixOrder order)
	{
		GDIPlus.CheckStatus(GDIPlus.GdipShearMatrix(nativeMatrix, shearX, shearY, order));
	}

	public void TransformPoints(Point[] pts)
	{
		if (pts == null)
		{
			throw new ArgumentNullException("pts");
		}
		GDIPlus.CheckStatus(GDIPlus.GdipTransformMatrixPointsI(nativeMatrix, pts, pts.Length));
	}

	public void TransformPoints(PointF[] pts)
	{
		if (pts == null)
		{
			throw new ArgumentNullException("pts");
		}
		GDIPlus.CheckStatus(GDIPlus.GdipTransformMatrixPoints(nativeMatrix, pts, pts.Length));
	}

	public void TransformVectors(Point[] pts)
	{
		if (pts == null)
		{
			throw new ArgumentNullException("pts");
		}
		GDIPlus.CheckStatus(GDIPlus.GdipVectorTransformMatrixPointsI(nativeMatrix, pts, pts.Length));
	}

	public void TransformVectors(PointF[] pts)
	{
		if (pts == null)
		{
			throw new ArgumentNullException("pts");
		}
		GDIPlus.CheckStatus(GDIPlus.GdipVectorTransformMatrixPoints(nativeMatrix, pts, pts.Length));
	}

	public void Translate(float offsetX, float offsetY)
	{
		Translate(offsetX, offsetY, MatrixOrder.Prepend);
	}

	public void Translate(float offsetX, float offsetY, MatrixOrder order)
	{
		GDIPlus.CheckStatus(GDIPlus.GdipTranslateMatrix(nativeMatrix, offsetX, offsetY, order));
	}

	public void VectorTransformPoints(Point[] pts)
	{
		TransformVectors(pts);
	}
}
