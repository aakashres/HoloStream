using System;

namespace HoloStream
{
    public struct CameraParameters
    {
        public CapturePixelFormat pixelFormat;

        public int cameraResolutionHeight;

        public int cameraResolutionWidth;

        public int frameRate;

		public bool rotateImage180Degrees;

        public float hologramOpacity;
		public bool enableHolograms
		{
			get {	throw new NotImplementedException(); }
			set {	throw new NotImplementedException(); }
		}

 		public int videoStabilizationBufferSize;
		public bool enableVideoStabilization
		{
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public bool recordingIndicatorVisible;

        public CameraParameters(
            CapturePixelFormat pixelFormat = CapturePixelFormat.BGRA32,
            int cameraResolutionHeight = 720,
            int cameraResolutionWidth = 1280,
            int frameRate = 30,
			bool rotateImage180Degrees = true,
            bool recordingIndicatorVisible=true)
        { throw new NotImplementedException(); }
    }
}
