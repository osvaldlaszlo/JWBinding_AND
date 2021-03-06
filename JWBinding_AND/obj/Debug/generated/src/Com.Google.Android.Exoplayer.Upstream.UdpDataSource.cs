using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/UdpDataSource", DoNotGenerateAcw=true)]
	public sealed partial class UdpDataSource : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/field[@name='DEAFULT_SOCKET_TIMEOUT_MILLIS']"
		[Register ("DEAFULT_SOCKET_TIMEOUT_MILLIS")]
		public const int DeafultSocketTimeoutMillis = (int) 8000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/field[@name='DEFAULT_MAX_PACKET_SIZE']"
		[Register ("DEFAULT_MAX_PACKET_SIZE")]
		public const int DefaultMaxPacketSize = (int) 2000;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource.UdpDataSourceException']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/UdpDataSource$UdpDataSourceException", DoNotGenerateAcw=true)]
		public sealed partial class UdpDataSourceException : global::Java.IO.IOException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/UdpDataSource$UdpDataSourceException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UdpDataSourceException); }
			}

			internal UdpDataSourceException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource.UdpDataSourceException']/constructor[@name='UdpDataSource.UdpDataSourceException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe UdpDataSourceException (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (UdpDataSourceException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_ctor_Ljava_io_IOException_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource.UdpDataSourceException']/constructor[@name='UdpDataSource.UdpDataSourceException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
			[Register (".ctor", "(Ljava/io/IOException;)V", "")]
			public unsafe UdpDataSourceException (global::Java.IO.IOException p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (UdpDataSourceException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/IOException;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/io/IOException;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_IOException_ == IntPtr.Zero)
						id_ctor_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/IOException;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_IOException_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_io_IOException_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/UdpDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UdpDataSource); }
		}

		internal UdpDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/constructor[@name='UdpDataSource' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.upstream.TransferListener'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/google/android/exoplayer/upstream/TransferListener;II)V", "")]
		public unsafe UdpDataSource (global::Com.Google.Android.Exoplayer.Upstream.ITransferListener p0, int p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (UdpDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/android/exoplayer/upstream/TransferListener;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/android/exoplayer/upstream/TransferListener;II)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_II == IntPtr.Zero)
					id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/exoplayer/upstream/TransferListener;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_II, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/constructor[@name='UdpDataSource' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.upstream.TransferListener'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/google/android/exoplayer/upstream/TransferListener;I)V", "")]
		public unsafe UdpDataSource (global::Com.Google.Android.Exoplayer.Upstream.ITransferListener p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UdpDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/android/exoplayer/upstream/TransferListener;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/android/exoplayer/upstream/TransferListener;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_I == IntPtr.Zero)
					id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/exoplayer/upstream/TransferListener;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/constructor[@name='UdpDataSource' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.TransferListener']]"
		[Register (".ctor", "(Lcom/google/android/exoplayer/upstream/TransferListener;)V", "")]
		public unsafe UdpDataSource (global::Com.Google.Android.Exoplayer.Upstream.ITransferListener p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (UdpDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/android/exoplayer/upstream/TransferListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/android/exoplayer/upstream/TransferListener;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_ == IntPtr.Zero)
					id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/exoplayer/upstream/TransferListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_TransferListener_, __args);
			} finally {
			}
		}

		static IntPtr id_getUri;
		public unsafe string Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
			get {
				if (id_getUri == IntPtr.Zero)
					id_getUri = JNIEnv.GetMethodID (class_ref, "getUri", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUri), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/method[@name='close' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UdpDataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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
