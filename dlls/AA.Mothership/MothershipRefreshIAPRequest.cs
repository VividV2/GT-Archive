using System;
using System.Runtime.InteropServices;

public class MothershipRefreshIAPRequest : MothershipRequest
{
	private HandleRef swigCPtr;

	internal MothershipRefreshIAPRequest(IntPtr cPtr, bool cMemoryOwn)
		: base(MothershipApiPINVOKE.MothershipRefreshIAPRequest_SWIGUpcast(cPtr), cMemoryOwn)
	{
		swigCPtr = new HandleRef(this, cPtr);
	}

	internal static HandleRef getCPtr(MothershipRefreshIAPRequest obj)
	{
		return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
	}

	internal static HandleRef swigRelease(MothershipRefreshIAPRequest obj)
	{
		if (obj != null)
		{
			if (!obj.swigCMemOwn)
			{
				throw new ApplicationException("Cannot release ownership as memory is not owned");
			}
			HandleRef result = obj.swigCPtr;
			obj.swigCMemOwn = false;
			obj.Dispose();
			return result;
		}
		return new HandleRef(null, IntPtr.Zero);
	}

	protected override void Dispose(bool disposing)
	{
		lock (this)
		{
			if (swigCPtr.Handle != IntPtr.Zero)
			{
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					MothershipApiPINVOKE.delete_MothershipRefreshIAPRequest(swigCPtr);
				}
				swigCPtr = new HandleRef(null, IntPtr.Zero);
			}
			base.Dispose(disposing);
		}
	}

	public override SWIGTYPE_p_std__shared_ptrT_MothershipApi__MothershipHTTPRequest_t ToHttpRequest()
	{
		SWIGTYPE_p_std__shared_ptrT_MothershipApi__MothershipHTTPRequest_t result = new SWIGTYPE_p_std__shared_ptrT_MothershipApi__MothershipHTTPRequest_t(MothershipApiPINVOKE.MothershipRefreshIAPRequest_ToHttpRequest(swigCPtr), futureUse: true);
		if (MothershipApiPINVOKE.SWIGPendingException.Pending)
		{
			throw MothershipApiPINVOKE.SWIGPendingException.Retrieve();
		}
		return result;
	}

	public MothershipRefreshIAPRequest()
		: this(MothershipApiPINVOKE.new_MothershipRefreshIAPRequest(), cMemoryOwn: true)
	{
		if (MothershipApiPINVOKE.SWIGPendingException.Pending)
		{
			throw MothershipApiPINVOKE.SWIGPendingException.Retrieve();
		}
	}
}
public class RequestJoinGameSessionFailedError : MothershipError
{
	private HandleRef swigCPtr;

	internal RequestJoinGameSessionFailedError(IntPtr cPtr, bool cMemoryOwn)
	{
		base..ctor(MothershipApiPINVOKE.RequestJoinGameSessionFailedError_SWIGUpcast(cPtr), cMemoryOwn);
		swigCPtr = new HandleRef(this, cPtr);
	}

	internal static HandleRef getCPtr(RequestJoinGameSessionFailedError obj)
	{
		return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
	}

	internal static HandleRef swigRelease(RequestJoinGameSessionFailedError obj)
	{
		if (obj != null)
		{
			if (!obj.swigCMemOwn)
			{
				throw new ApplicationException("Cannot release ownership as memory is not owned");
			}
			result = obj.swigCPtr;
			obj.swigCMemOwn = false;
			obj.Dispose();
			return result;
		}
		return new HandleRef(null, IntPtr.Zero);
	}

	protected override void Dispose(bool disposing)
	{
		lock (this)
		{
			if (swigCPtr.Handle != IntPtr.Zero)
			{
				if (swigCMemOwn)
				{
					swigCMemOwn = false;
					MothershipApiPINVOKE.delete_RequestJoinGameSessionFailedError(swigCPtr);
				}
				swigCPtr = new HandleRef(null, IntPtr.Zero);
			}
			base.Dispose(disposing);
		}
	}

	public RequestJoinGameSessionFailedError(string message, int statusCode, string traceId, string mothershipErrorCode)
	{
		this..ctor(MothershipApiPINVOKE.new_RequestJoinGameSessionFailedError__SWIG_0(message, statusCode, traceId, mothershipErrorCode), cMemoryOwn: true);
		if (SWIGPendingException.Pending)
		{
			throw SWIGPendingException.Retrieve();
		}
	}

	public RequestJoinGameSessionFailedError(string message, int statusCode, string traceId)
	{
		this..ctor(MothershipApiPINVOKE.new_RequestJoinGameSessionFailedError__SWIG_1(message, statusCode, traceId), cMemoryOwn: true);
		if (SWIGPendingException.Pending)
		{
			throw SWIGPendingException.Retrieve();
		}
	}

	public RequestJoinGameSessionFailedError(string message, int statusCode)
	{
		this..ctor(MothershipApiPINVOKE.new_RequestJoinGameSessionFailedError__SWIG_2(message, statusCode), cMemoryOwn: true);
		if (SWIGPendingException.Pending)
		{
			throw SWIGPendingException.Retrieve();
		}
	}
}
