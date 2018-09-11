//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Aqrose.Aidi {

public class AidiSegmentRunner : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AidiSegmentRunner(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AidiSegmentRunner obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AidiSegmentRunner() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csharpaidiclientPINVOKE.delete_AidiSegmentRunner(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AidiSegmentRunner(string check_code) : this(csharpaidiclientPINVOKE.new_AidiSegmentRunner__SWIG_0(check_code), true) {
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public AidiSegmentRunner() : this(csharpaidiclientPINVOKE.new_AidiSegmentRunner__SWIG_1(), true) {
  }

  public void set_param(SegmentClientParamWrapper param) {
    csharpaidiclientPINVOKE.AidiSegmentRunner_set_param(swigCPtr, SegmentClientParamWrapper.getCPtr(param));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public void start() {
    csharpaidiclientPINVOKE.AidiSegmentRunner_start(swigCPtr);
  }

  public void release() {
    csharpaidiclientPINVOKE.AidiSegmentRunner_release(swigCPtr);
  }

  public void set_test_batch_image(BatchAidiImage batch) {
    csharpaidiclientPINVOKE.AidiSegmentRunner_set_test_batch_image(swigCPtr, BatchAidiImage.getCPtr(batch));
    if (csharpaidiclientPINVOKE.SWIGPendingException.Pending) throw csharpaidiclientPINVOKE.SWIGPendingException.Retrieve();
  }

  public BatchAidiImage get_detect_result() {
    BatchAidiImage ret = new BatchAidiImage(csharpaidiclientPINVOKE.AidiSegmentRunner_get_detect_result(swigCPtr), true);
    return ret;
  }

}

}