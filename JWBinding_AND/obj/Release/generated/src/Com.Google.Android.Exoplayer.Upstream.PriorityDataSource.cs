using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='PriorityDataSource']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/PriorityDataSource", DoNotGenerateAcw=true)]
	public sealed partial class PriorityDataSource : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/PriorityDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PriorityDataSource); }
		}

		internal PriorityDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='PriorityDataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_read_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='PriorityDataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "")]
		public unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
