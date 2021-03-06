//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Grapeshot {

class GrapeshotUploadFlatbuffersPINVOKE {

  /// For Mono AOT platforms compatibility
  /// This attribute can be defined in any assembly for Mono AOT to use it.
  public class MonoPInvokeCallbackAttribute : global::System.Attribute {
    public MonoPInvokeCallbackAttribute(global::System.Type t) {
    }
  }


  protected class SWIGExceptionHelper {
    public delegate void ExceptionDelegate(string message); 
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="SWIGRegisterExceptionCallbacks_GrapeshotUploadFlatbuffers")]
    public static extern void SWIGRegisterExceptionCallbacks_GrapeshotUploadFlatbuffers(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="SWIGRegisterExceptionArgumentCallbacks_GrapeshotUploadFlatbuffers")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_GrapeshotUploadFlatbuffers(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);


    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionDelegate))]


    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]


    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]


    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }



    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(ExceptionArgumentDelegate))]


    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_GrapeshotUploadFlatbuffers(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_GrapeshotUploadFlatbuffers(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(GrapeshotUploadFlatbuffersPINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(GrapeshotUploadFlatbuffersPINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {
    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="SWIGRegisterStringCallback_GrapeshotUploadFlatbuffers")]
    public static extern void SWIGRegisterStringCallback_GrapeshotUploadFlatbuffers(SWIGStringDelegate stringDelegate);


    [GrapeshotUploadFlatbuffersPINVOKE.MonoPInvokeCallback(typeof(SWIGStringDelegate))]


    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_GrapeshotUploadFlatbuffers(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static GrapeshotUploadFlatbuffersPINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_UploadChunkRequest_Ret_ret")]
  public static extern void UploadChunkRequest_Ret_ret(global::System.Runtime.InteropServices.HandleRef jarg1, FBIntermediateBuffer jarg2);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_new_UploadChunkRequest_Ret")]
  public static extern global::System.IntPtr new_UploadChunkRequest_Ret();

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_delete_UploadChunkRequest_Ret")]
  public static extern void delete_UploadChunkRequest_Ret(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_UploadChunkBody_Ret_ret")]
  public static extern void UploadChunkBody_Ret_ret(global::System.Runtime.InteropServices.HandleRef jarg1, FBIntermediateBuffer jarg2);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_new_UploadChunkBody_Ret")]
  public static extern global::System.IntPtr new_UploadChunkBody_Ret();

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_delete_UploadChunkBody_Ret")]
  public static extern void delete_UploadChunkBody_Ret(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_UploadAuth_Ret_ret")]
  public static extern void UploadAuth_Ret_ret(global::System.Runtime.InteropServices.HandleRef jarg1, FBIntermediateBuffer jarg2);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_new_UploadAuth_Ret")]
  public static extern global::System.IntPtr new_UploadAuth_Ret();

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_delete_UploadAuth_Ret")]
  public static extern void delete_UploadAuth_Ret(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_UploadServiceInfo_Ret_ret")]
  public static extern void UploadServiceInfo_Ret_ret(global::System.Runtime.InteropServices.HandleRef jarg1, FBIntermediateBuffer jarg2);

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_new_UploadServiceInfo_Ret")]
  public static extern global::System.IntPtr new_UploadServiceInfo_Ret();

  [global::System.Runtime.InteropServices.DllImport(Grapeshot.LibraryHelper.libraryName, EntryPoint="CSharp_Grapeshot_delete_UploadServiceInfo_Ret")]
  public static extern void delete_UploadServiceInfo_Ret(global::System.Runtime.InteropServices.HandleRef jarg1);
}

}
